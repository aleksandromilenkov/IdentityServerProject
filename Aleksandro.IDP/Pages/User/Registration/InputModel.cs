using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Aleksandro.IDP.Pages.User.Registration
{
    public class InputModel
    {
        public string ReturnUrl { get; set; }

        [MaxLength(200)]
        [Display(Name ="Username")]
        public string UserName { get; set; }

        [MaxLength(200)]
        [DataType(DataType.Password)]
        [Display(Name ="Password")] 
        public string Password { get; set; }

        [Required]
        [MaxLength(200)]
        [Display(Name = "Given name")]
        public string GivenName { get; set; }

        [Required]
        [MaxLength(200)]
        [Display(Name = "Family name")]
        public string FamilyName { get; set; }

        [Required]
        [MaxLength(200)]
        [Display(Name = "Country")]
        public string Country { get; set; }

        public SelectList CountryCodes { get; set; } =
            new(new[]
            {
                new {Id = "be", Value ="Belgium"},
                new {Id = "us", Value ="United States of America"},
                new {Id = "mk", Value ="Macedonia"} },
                "Id",
                "Value"
            );
    }
}
