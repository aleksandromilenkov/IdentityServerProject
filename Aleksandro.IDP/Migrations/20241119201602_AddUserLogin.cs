using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Aleksandro.IDP.Migrations
{
    /// <inheritdoc />
    public partial class AddUserLogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Provider = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    ProviderIdentityKey = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                column: "ConcurrencyStamp",
                value: "bc57db4d-5dbb-4aec-9a95-66091a770ab6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "67e22b75-e42d-48ac-9b12-8a9e717acd16");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserLogins");

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
                column: "ConcurrencyStamp",
                value: "6ff7ffbd-f408-4178-98d8-5366208c87cc");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "20b55ca5-f782-4f86-bc64-ddc6c316479e");
        }
    }
}
