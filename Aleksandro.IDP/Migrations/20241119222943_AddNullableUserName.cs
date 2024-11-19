using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Aleksandro.IDP.Migrations
{
    /// <inheritdoc />
    public partial class AddNullableUserName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("38a8ffe9-75f6-4731-8d56-cfc72387b0f8"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("4750af95-6900-43c1-a378-b14cca3ccd1b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("5fed1901-8570-4b1a-8007-8e0cebf4c91a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("67d6a046-1987-496f-9add-2fa9aa10286e"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("80d33f0d-33f9-4a2e-afc3-94fd1025661e"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("bd0f60fe-c854-48a0-87e5-63807e50d3ae"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("d3501de2-ac7a-46c0-b923-ba89f82e8047"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("f2b672e1-6ca4-48bb-ba72-c721b8c57e34"));

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SecurityCodeExpirationDate",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200);

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("35af4346-f328-4972-a209-9c8fcb3415b1"), "b45eaa25-20a5-4193-a61a-5ef3991fc827", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("53e522c6-0b48-4308-bed8-8af514ee4697"), "20126148-530f-40fa-aeca-d617511dfcaa", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("5c8d8519-1e15-4eb1-8421-60c4b6f79be1"), "4f8a9720-8520-4b13-9bd1-b1c3754cbbe9", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("644fbf86-a921-44ce-83e9-5b472ad72f4d"), "051ce912-9899-4485-8966-a596b098058e", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("916f0ec6-863e-43aa-90a1-7aa387a8e62e"), "3d9ecef6-81b7-45f6-8592-73bfdb63d04f", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("ac81c5de-d03e-4a3f-84fe-198690b619b5"), "19ef5326-6b06-48d0-b39e-54e050b706c2", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("e24bd121-7717-4c63-b012-5fb0d3108fdd"), "3133d3be-1a23-4054-b7f9-e4508b58a217", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("fb9141ee-e93f-45f9-be7e-8092efaaa0d9"), "8b58501b-e50d-4846-ba80-50ab2659eb8a", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                columns: new[] { "ConcurrencyStamp", "SecurityCodeExpirationDate" },
                values: new object[] { "46a48d1b-908b-4b39-9d6c-f860b4ebbf3c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                columns: new[] { "ConcurrencyStamp", "SecurityCodeExpirationDate" },
                values: new object[] { "8cd7d891-31fa-4b51-b6ff-747a34f88c43", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("35af4346-f328-4972-a209-9c8fcb3415b1"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("53e522c6-0b48-4308-bed8-8af514ee4697"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("5c8d8519-1e15-4eb1-8421-60c4b6f79be1"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("644fbf86-a921-44ce-83e9-5b472ad72f4d"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("916f0ec6-863e-43aa-90a1-7aa387a8e62e"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("ac81c5de-d03e-4a3f-84fe-198690b619b5"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("e24bd121-7717-4c63-b012-5fb0d3108fdd"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("fb9141ee-e93f-45f9-be7e-8092efaaa0d9"));

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SecurityCodeExpirationDate",
                table: "Users",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("38a8ffe9-75f6-4731-8d56-cfc72387b0f8"), "848208ab-5ca4-466b-8b88-781ae82e830b", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("4750af95-6900-43c1-a378-b14cca3ccd1b"), "df635818-231f-4763-9b05-97850607c472", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("5fed1901-8570-4b1a-8007-8e0cebf4c91a"), "bc6bc345-b29f-4543-b86d-d0733d98e3b9", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("67d6a046-1987-496f-9add-2fa9aa10286e"), "22db86f2-ee18-4a0a-90d0-9f2c64ba6277", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("80d33f0d-33f9-4a2e-afc3-94fd1025661e"), "71bdd1d5-2a3f-417e-a5e5-8ada42e977a4", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("bd0f60fe-c854-48a0-87e5-63807e50d3ae"), "3bdd37f0-bceb-4058-97d7-2d373c41b7bf", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("d3501de2-ac7a-46c0-b923-ba89f82e8047"), "61153df6-b981-442c-9b06-6ea1efab4576", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("f2b672e1-6ca4-48bb-ba72-c721b8c57e34"), "18a78e62-d3f4-479c-b020-08b33e37f32a", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                columns: new[] { "ConcurrencyStamp", "SecurityCodeExpirationDate" },
                values: new object[] { "bc57db4d-5dbb-4aec-9a95-66091a770ab6", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                columns: new[] { "ConcurrencyStamp", "SecurityCodeExpirationDate" },
                values: new object[] { "67e22b75-e42d-48ac-9b12-8a9e717acd16", null });
        }
    }
}
