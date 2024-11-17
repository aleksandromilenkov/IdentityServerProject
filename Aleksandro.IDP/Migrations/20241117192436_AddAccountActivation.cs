using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Aleksandro.IDP.Migrations
{
    /// <inheritdoc />
    public partial class AddAccountActivation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("25fb2252-146d-40e1-8f46-066ceb02b1de"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("4827335d-aedf-43d8-96ae-c5a1cdc55b49"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("51d145cd-6f2f-41da-ae34-f0c9abde6be6"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("63df6f41-a981-4700-b7ea-758a7ed261d8"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("8bc8f297-2ab2-4ffa-a191-272d7aba3d62"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("8ebd0b2c-f075-4787-9e7b-e4505116be7b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("a66c640f-5280-4388-a1b9-5a9bfb468f20"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("c423c543-f0c3-4cb2-8ce6-32e8286607f6"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecurityCode",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SecurityCodeExpirationDate",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("04e54795-384b-4892-b916-f0f27eaf4a19"), "fe1db11a-02b8-42a9-99e8-1a763de902c9", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("64270b1c-6614-4987-a26b-a2945ebbdd75"), "0a17a9e0-4fe1-4c0b-8743-f44d6f5f2a03", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("64fe2a4f-e658-4a99-8fc5-f03bcd879461"), "a78bdc56-2124-4a01-a61f-fc89d1884b77", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("9cae5c15-a0e1-43ff-ba18-486caf7af21c"), "3b7ff113-d54a-4933-8f8a-160c382c6cf9", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("a1daea0e-9ca3-4f1d-a77f-f232db703e80"), "29456d60-c5bb-494b-be76-933de6ffa0f1", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("bd577f81-8ea7-4139-8778-756c7a29f433"), "24c79815-aff1-4207-bb50-24832604426f", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("e3f7edd7-18a5-49f2-9bb2-7986a542d6bd"), "5683177e-cb5f-4bd8-a58e-edd45a71deb9", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("e74a95a2-837e-4835-a21a-a8aeab4e1667"), "d44f0575-41f7-43c3-abc0-05ba16d24599", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityCode", "SecurityCodeExpirationDate" },
                values: new object[] { "6ff7ffbd-f408-4178-98d8-5366208c87cc", "david@test.com", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityCode", "SecurityCodeExpirationDate" },
                values: new object[] { "20b55ca5-f782-4f86-bc64-ddc6c316479e", "ema@test.com", null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("04e54795-384b-4892-b916-f0f27eaf4a19"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("64270b1c-6614-4987-a26b-a2945ebbdd75"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("64fe2a4f-e658-4a99-8fc5-f03bcd879461"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("9cae5c15-a0e1-43ff-ba18-486caf7af21c"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("a1daea0e-9ca3-4f1d-a77f-f232db703e80"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("bd577f81-8ea7-4139-8778-756c7a29f433"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("e3f7edd7-18a5-49f2-9bb2-7986a542d6bd"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("e74a95a2-837e-4835-a21a-a8aeab4e1667"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCodeExpirationDate",
                table: "Users");

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("25fb2252-146d-40e1-8f46-066ceb02b1de"), "c4a5688f-7f8d-4278-a158-ef178425c6c6", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("4827335d-aedf-43d8-96ae-c5a1cdc55b49"), "30b6174e-6990-4931-adcf-8d9357e4acc0", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("51d145cd-6f2f-41da-ae34-f0c9abde6be6"), "6f80a9fc-7c7b-4407-ba4b-cf9cbfb51ed1", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("63df6f41-a981-4700-b7ea-758a7ed261d8"), "488696b3-34e0-4b40-9e18-2e1192e548de", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("8bc8f297-2ab2-4ffa-a191-272d7aba3d62"), "79900950-c8f8-4453-9e9a-67cc85eab142", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("8ebd0b2c-f075-4787-9e7b-e4505116be7b"), "a58d8b7e-5cf8-47db-aa6e-36efbad56088", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("a66c640f-5280-4388-a1b9-5a9bfb468f20"), "951cf9ec-5749-4b02-a566-c16cc22e40f3", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("c423c543-f0c3-4cb2-8ce6-32e8286607f6"), "738effb6-54bc-4829-b57e-dba69643f084", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "cfde5b16-6829-444c-a246-bf4db2f61c4e");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "ebdc49f3-9803-4ecb-89be-25902615c7ae");
        }
    }
}
