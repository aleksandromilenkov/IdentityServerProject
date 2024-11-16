using Aleksandro.IDP.Services;
using Duende.IdentityServer;
using Duende.IdentityServer.Services;
using IdentityModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aleksandro.IDP.Pages.User.Registration
{
    [AllowAnonymous]
    [SecurityHeaders]
    public class IndexModel : PageModel
    {
        private readonly ILocalUserService _localUserService;
        private readonly IIdentityServerInteractionService _interaction;
        public IndexModel(ILocalUserService localUserService, IIdentityServerInteractionService interaction)
        {
            _localUserService = localUserService;
            _interaction = interaction;
        }

        [BindProperty]
        public InputModel Input { get; set; }
        public IActionResult OnGet(string returnUrl)
        {
            BuildModel(returnUrl);
            return Page();
        }

        private void BuildModel(string returnUrl)
        {
            Input = new InputModel
            {
                ReturnUrl = returnUrl,
            };
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                // something went wrong, show form with error
                BuildModel(Input.ReturnUrl);
                return Page();
            }

            // create user & claims
            var userToCreate = new Entities.User
            {
                Password = Input.Password,
                UserName = Input.UserName,
                Subject = Guid.NewGuid().ToString(),
                Active = true
            };
            userToCreate.Claims.Add(new Entities.UserClaim()
            {
                Type = "country",
                Value = Input.Country
            });

            userToCreate.Claims.Add(new Entities.UserClaim()
            {
                Type = JwtClaimTypes.GivenName,
                Value = Input.GivenName
            });

            userToCreate.Claims.Add(new Entities.UserClaim()
            {
                Type = JwtClaimTypes.FamilyName,
                Value = Input.FamilyName
            });

            _localUserService.AddUser(userToCreate);
            await _localUserService.SaveChangesAsync();

            // Issue authentication cookie (log the user in)
            var isUser = new IdentityServerUser(userToCreate.Subject)
            {
                DisplayName = userToCreate.UserName
            };
            await HttpContext.SignInAsync(isUser);

            // continue with the flow     
            if (_interaction.IsValidReturnUrl(Input.ReturnUrl)
                || Url.IsLocalUrl(Input.ReturnUrl))
            {
                return Redirect(Input.ReturnUrl);
            }

            return Redirect("~/");


        }

    }
}
