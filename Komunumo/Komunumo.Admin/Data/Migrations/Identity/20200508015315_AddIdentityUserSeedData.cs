using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Komunumo.Admin.Data.Migrations.Identity
{
    public partial class AddIdentityUserSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("400afb64-4711-4fd5-9d02-289187aafbb6"), 0, "808cf95e-3518-4b6d-a33e-407399194f36", "user0@gmail.com", false, false, null, "USER0@GMAIL.COM", "USER0", "AQAAAAEAACcQAAAAEAOKlqy9BDCdJI7zl/Hzh9l1d+cgkgZw/STMYHhzkTaAA2Xe1Eb8iV8QjswQa8PjtQ==", null, false, "324c283d-6e47-43ff-89ed-0394c2bbdf66", false, "user0" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d74f5053-f8b2-48ff-8efb-0c2696dc5288"), 0, "6b2dc844-2e19-46a8-a165-0d1b9eb78349", "user72@gmail.com", false, false, null, "USER72@GMAIL.COM", "USER72", "AQAAAAEAACcQAAAAEDKQBSAOfBOLEZDohVlJiI5Gzz/mfizvFhQ9TCYifVRqPBrEvrrPCLQkUQft5EfO5g==", null, false, "c129cf90-52d9-41ce-b4c5-f9ac3880a419", false, "user72" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("b05499c4-c748-4fe1-bf81-c0e5070a8c66"), 0, "9f63e770-0976-441e-8bcf-a460f1aabf47", "user71@gmail.com", false, false, null, "USER71@GMAIL.COM", "USER71", "AQAAAAEAACcQAAAAEFbtuRJsmzv5GK4OsB1rvFyWP9fY/MZ8AwuTLdjpYrisSFdupObxG1dY9ozoUUWYKw==", null, false, "9e064ebe-c342-4c07-ba11-3daeccf3b98d", false, "user71" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("677b03f4-34ec-43aa-9763-80f1c95aa742"), 0, "cfb0d90c-30ac-4c59-8cdc-d9a3142f9472", "user70@gmail.com", false, false, null, "USER70@GMAIL.COM", "USER70", "AQAAAAEAACcQAAAAEBQhvlf/s8E9l3wpe+5v1BipYeYSF1GKCBG0sO5gyuaaekHmp6JAuT2+dkjCzLI/Ug==", null, false, "4e2b1f38-a13f-4bf7-ba86-a6d6820f82b8", false, "user70" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("86aadce6-2de2-4e06-a90e-279eef332bbd"), 0, "2d4b6bb6-b632-4b54-a811-bdcfa2791cb5", "user69@gmail.com", false, false, null, "USER69@GMAIL.COM", "USER69", "AQAAAAEAACcQAAAAEE99HGzgmJex8HEsoJ8NgGwpOSHYJ8fkVCiKzqC12ug+ok6ho5+LCBDV7FnDdWzQFQ==", null, false, "b4a9aff5-8999-46bd-b367-4c704f556121", false, "user69" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("89ebfddb-995a-4195-b6ed-df8a3e3461f4"), 0, "fe73c64a-d114-4436-99d1-ea38b83d701a", "user68@gmail.com", false, false, null, "USER68@GMAIL.COM", "USER68", "AQAAAAEAACcQAAAAECSgK/LvBMHeSeMoy+BKJyTNX8VqzN3Z25yu07S9343AWlpSVWtPffwAKoJqp2ygQw==", null, false, "cb0d779d-fbc3-45d1-911d-12573ddb0d57", false, "user68" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("5d370b9a-939a-4f88-8888-e4102a123e3d"), 0, "e388c3bb-80fc-4267-acee-158c586a99bf", "user67@gmail.com", false, false, null, "USER67@GMAIL.COM", "USER67", "AQAAAAEAACcQAAAAEJ1p7gczy91MP1N3uI2AleNwp2sk97V+5Up9/oYAcwwyiMVF0q8Rljdnjw7QUgBZSw==", null, false, "d70f4736-effd-41a4-bf2f-8de2f4333bd4", false, "user67" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d7eddbdc-e829-4e89-98b7-d62f7dd266cc"), 0, "865d7699-3f0f-4999-85ba-26275cbd2e0c", "user66@gmail.com", false, false, null, "USER66@GMAIL.COM", "USER66", "AQAAAAEAACcQAAAAEEkFaoG358lGoB7Em755YsYhfvgoagvUHfJQIFThNeNmQ7mYTr0Z7Rc7qAeDCQOR/A==", null, false, "4ad7e15a-b0a1-43de-a22b-67b693bc215b", false, "user66" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f7d05861-0d44-43d7-8aa8-b0696b04583e"), 0, "274bd764-7cd4-4fd8-91b1-607cc27f2668", "user65@gmail.com", false, false, null, "USER65@GMAIL.COM", "USER65", "AQAAAAEAACcQAAAAELx0g2tNl5IwAHSycJva9CuK3FvMa419ej9Svno2vYV64uG9ekQWD4UmlEUkNXBGEA==", null, false, "d570712c-175b-4cc9-b905-aa43ac559c95", false, "user65" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7252719b-c558-4d92-9f6d-fd9d7b400bd6"), 0, "3c558c91-0adf-47e1-89da-ee976b100d15", "user64@gmail.com", false, false, null, "USER64@GMAIL.COM", "USER64", "AQAAAAEAACcQAAAAEHH89ws2pI/8oiMY+DMOtTPE/7PunUtNJ6/JcgZMMxVJsqnsG7cc+CwtY3qJ2iYSHg==", null, false, "c9600e8b-34e3-433c-87f3-8b9cabd04cec", false, "user64" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("25993e7e-5316-49b9-be67-5f30473f2d69"), 0, "8bcf19a5-adde-4ee7-9559-bbf35c3375c6", "user63@gmail.com", false, false, null, "USER63@GMAIL.COM", "USER63", "AQAAAAEAACcQAAAAEFR7+qCps8l50xJwL8/XSfue9lPcnhzRZ3WT/6fQ1F04woS07oAQ/x2nIClOMJad5g==", null, false, "e14b987a-dcdd-46c1-9af7-d5790d0512f5", false, "user63" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f4fb2a4e-d1ab-497a-8ffa-0f070b0d985c"), 0, "5dd7f32b-3804-4bcb-835d-a6b136f15bfa", "user62@gmail.com", false, false, null, "USER62@GMAIL.COM", "USER62", "AQAAAAEAACcQAAAAEAdWBBtmHs0g8utap3Ls3MotpnVkI66DJpLIIib6eB+0QbG8T/qB2sVchh1FXK2mtA==", null, false, "e526753b-6eee-4495-9442-efb77f4ebc12", false, "user62" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("5a6fae2f-5f8b-4355-bde3-1ca1d8bc5568"), 0, "5edfb509-4cf3-462c-b4b0-993a41c248c0", "user61@gmail.com", false, false, null, "USER61@GMAIL.COM", "USER61", "AQAAAAEAACcQAAAAEOJkp4kTxJ7JvC8liA4xA4IYBt4rQ72gryCOgTUZWsNaRaPSgfj/WDN20nf7p13hFw==", null, false, "676cb52c-f2bc-4aa9-bed0-289ffb55af63", false, "user61" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("c39298de-dc10-4734-baa2-67334afcd794"), 0, "d3744646-297f-4c52-a3da-2b153af1ae58", "user60@gmail.com", false, false, null, "USER60@GMAIL.COM", "USER60", "AQAAAAEAACcQAAAAEGdTWNprAL0IUdoXncvEqFhz2LKxYSKISnxl0kjebibTTBUAUrJ+kBKDnaWtkQfMjA==", null, false, "de2e20f0-9299-487b-b305-758177aa595f", false, "user60" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d0bf492d-2a91-4a38-abe6-584ac3c42752"), 0, "b92b4641-8f8b-453e-9224-09db53e1f66f", "user59@gmail.com", false, false, null, "USER59@GMAIL.COM", "USER59", "AQAAAAEAACcQAAAAEAzEXB2YwuNeN3/0MVQY9Q2VsEh+0NkP0oVmTaQEp/P/b3qHQPT+Ei/VarfVUMBNQA==", null, false, "d13b9640-412a-49eb-b07b-090820bc7d37", false, "user59" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("ac5c2b5e-cd18-40d4-8e91-21c719365673"), 0, "1df97fdf-aca8-4904-9301-a3401eed9149", "user58@gmail.com", false, false, null, "USER58@GMAIL.COM", "USER58", "AQAAAAEAACcQAAAAEETqWW2y81tYiIceMnZYvZkEQz721PySGlG2i0WK8Ts2/5BZLpijPkE74yNqsGy6UA==", null, false, "a05662e0-8335-49cf-b1f4-333a2c138212", false, "user58" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("948bca64-f7d2-457e-a2e7-9aaf5d32cc5c"), 0, "bce03004-e738-4543-856a-69c74288abc8", "user57@gmail.com", false, false, null, "USER57@GMAIL.COM", "USER57", "AQAAAAEAACcQAAAAEIPbDkKkjTv93Mwiu/qosakOw/L1azlnldvFG4/s88iyzfzCp/TCbL8yOX5XBKfj6Q==", null, false, "f27cff7a-8cd8-4408-a0ec-11450709c24b", false, "user57" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d9646528-4803-4960-8677-d4f664e8a27c"), 0, "3be9a04a-eaad-4dcd-bb14-e918f8b0595d", "user56@gmail.com", false, false, null, "USER56@GMAIL.COM", "USER56", "AQAAAAEAACcQAAAAEIefFoXVEQPoBP+OHMb5XpU4xRKJZSaVsgKIhFE7Ks6dIi/b0wyhCvp+aInLaao3Zg==", null, false, "09ab0eea-ee30-4766-a90a-c8bee7507864", false, "user56" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("aa6338af-1dbe-4dea-a2bb-19eb6789298f"), 0, "49c5218c-a373-49a5-88b0-64c57d90e64f", "user55@gmail.com", false, false, null, "USER55@GMAIL.COM", "USER55", "AQAAAAEAACcQAAAAEC7ToNAgKyU6IULbsM9N4+PdiDWyiC+3hDVwjxyCt0VERTNsRGz1hOM3MxbzSZwzEA==", null, false, "4b0d91ab-cea5-42c8-94f7-b465e3133ae6", false, "user55" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("33516dee-2753-410f-ab83-8ff1c463ea0f"), 0, "4b299c10-fadd-4553-94eb-e0c2282e3516", "user54@gmail.com", false, false, null, "USER54@GMAIL.COM", "USER54", "AQAAAAEAACcQAAAAELsrLglSe085m+EWovoQp5y7+wI+QQhE8FsNR80DCEHUwJXtVjPy5fKGC2J6zmoURw==", null, false, "f721669d-49e1-40a0-989c-8e5674d0264e", false, "user54" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("0a730ae6-3a8f-49a4-b4bd-1a4027162905"), 0, "d10bc7db-7a71-4291-b080-7f7b632c6de3", "user53@gmail.com", false, false, null, "USER53@GMAIL.COM", "USER53", "AQAAAAEAACcQAAAAEAZNDG6Aoyikp2PnVsq7h7G/t4ZP5SiGAkVTZ3PXZGchE6KZZpmiXBae/1zQgtJJlQ==", null, false, "a95ed1ec-3ceb-4c72-88c6-dad92e14b04c", false, "user53" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("b524972d-8f75-45b0-a6b4-35df08de7c1b"), 0, "4a073a95-56cb-46ca-b13e-8f15fd87816d", "user52@gmail.com", false, false, null, "USER52@GMAIL.COM", "USER52", "AQAAAAEAACcQAAAAEM27CeZfdMcmD6knOGndONdIkl4RwRwJkhGgysOe7CuXpyhdry0s/STlnS8m2pqHdQ==", null, false, "76c6d91f-5fe0-4d2f-ace7-5bb4790663eb", false, "user52" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("a1a87345-33b4-436a-9a10-1536d7d73a60"), 0, "87ebda85-d44b-497f-bf34-9a743896a13d", "user73@gmail.com", false, false, null, "USER73@GMAIL.COM", "USER73", "AQAAAAEAACcQAAAAEM4PMdF0APWHPqUT9gU+YlYgjXpgvOlJrxQ/tOIFzgcamJatSrVaHdRbo3FmqWBWQA==", null, false, "8a422b68-891b-40d0-bd97-a2f8f699bc4e", false, "user73" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f73c2694-5b0d-4dc1-9920-b1a54ab86844"), 0, "a0b4bd7b-4ede-4db7-94d3-2b06cceedc8f", "user51@gmail.com", false, false, null, "USER51@GMAIL.COM", "USER51", "AQAAAAEAACcQAAAAEENn8cFJZGu6p4qA0DPK/dRWKa6UVIAxPVSv4v1+SqnX4iaQ8zFpZys51P7BMWEmgQ==", null, false, "39794bbb-b719-425c-ae27-64256591b2e8", false, "user51" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("26596f9f-ae0a-4b16-a368-34515f396eab"), 0, "75844254-5a77-481f-83f9-4c3c87cd0547", "user74@gmail.com", false, false, null, "USER74@GMAIL.COM", "USER74", "AQAAAAEAACcQAAAAELrrc4Oim8OiR2jFbtNLrekbjiv6uLGPK5py4PrH9ij72FpDgyuZ0cR2ZzmBv/C+Vw==", null, false, "94f0a670-8dab-4b6e-a640-b4510ec5501b", false, "user74" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("226808e7-4caf-4461-8a13-ebeb46e9bb73"), 0, "fc025368-1ef6-4ff5-b0b5-3cd172e2e4b8", "user76@gmail.com", false, false, null, "USER76@GMAIL.COM", "USER76", "AQAAAAEAACcQAAAAEEHXOuk+c6xqUE2NCxxBguOgzuOdR/QogAodc0RMUEgTPZxw01yzsb8fLrDMvtsJXA==", null, false, "13ce17a8-2bdb-4e4e-bb39-d04cd737632d", false, "user76" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("9d681558-2426-4c07-9f09-decd8cd5e307"), 0, "181779d7-9077-4a7c-9af7-f7d4cc6f8b43", "user97@gmail.com", false, false, null, "USER97@GMAIL.COM", "USER97", "AQAAAAEAACcQAAAAEIe+VVqlEfqDq7L0MzbX8MQoGWBf2USPeJkSEYz8DblVV5Dn/RR1NRKMQmf5TZGYnQ==", null, false, "aea27313-665d-4f34-8566-d64f3f08024b", false, "user97" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("9f0a4f61-2b92-4731-913a-9a288424dcc4"), 0, "a7256080-e198-4b3f-8830-c5e9bed74d2e", "user96@gmail.com", false, false, null, "USER96@GMAIL.COM", "USER96", "AQAAAAEAACcQAAAAEPs3nzH+jHHNW2yVMwhqXMfGn4hBNaN59xuSfj3e2pMbU+S9nOSrwcEWM22kEgPTzQ==", null, false, "30aab642-bcc6-48cf-bad8-fd9792789c6f", false, "user96" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("36cb9e5e-af0e-4379-b788-b1018a3535ee"), 0, "13e94b90-6185-47c8-b4ef-7996538e2303", "user95@gmail.com", false, false, null, "USER95@GMAIL.COM", "USER95", "AQAAAAEAACcQAAAAEALQMeRwI4PBwBjStYA8rcscsiac/4s3wbg5AaWiPs3NFbsGKXtwIMBJc35hmTWdMw==", null, false, "65ca8cc2-a781-465f-9f7a-adfa3277e092", false, "user95" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d7a79608-8f20-4fd2-ac41-0d98700690be"), 0, "dc57aeae-df28-4d53-98cb-e40503e52b40", "user94@gmail.com", false, false, null, "USER94@GMAIL.COM", "USER94", "AQAAAAEAACcQAAAAEOa3kyBRzIDBv0OBN0VsB4uddT6lwN2RUJMVpr45FSng6s9qXQ8wvoC3pkilsqlt9Q==", null, false, "0ea319e9-fc29-4215-9f52-c71f0df8f1ee", false, "user94" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("edf85368-db3d-456d-a4ac-fe77089198e0"), 0, "18627522-5c66-4178-bd5f-a70d62bfb8b4", "user93@gmail.com", false, false, null, "USER93@GMAIL.COM", "USER93", "AQAAAAEAACcQAAAAEGWwXb6pjiDMW4PnVqkXdVZ/1IU8gdaaMQj4Yw7hytFU+ndUa+kadnC/3ymS0M2M4w==", null, false, "ad941bc7-80cc-4564-a083-1b0f9c98dd60", false, "user93" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("4051c142-06e4-44a7-8ee1-d36fc256dd2d"), 0, "a869af0a-400e-4be6-921c-7de644161f3b", "user92@gmail.com", false, false, null, "USER92@GMAIL.COM", "USER92", "AQAAAAEAACcQAAAAEAJiu9ZY91IlU2NT9JhopVHmQGVVMC5OCbZ+Zdwmtm3fs72B1agwGG3C3YUb1KxsCQ==", null, false, "89e0dd03-9519-488a-8a81-6a61b9912aa6", false, "user92" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("3f29ebb0-e29e-42c6-a365-257baa041c29"), 0, "ab919131-f8f5-48ac-96c4-8463979d201a", "user91@gmail.com", false, false, null, "USER91@GMAIL.COM", "USER91", "AQAAAAEAACcQAAAAEJJ1zOx7eRFB153Vg2QajhKTYB1j1JgNdrVF5r3iRfkHyrdNp1DlJRXPu50uPY/01A==", null, false, "3a6ab3a0-ef2b-427f-9408-b083ab3d31ce", false, "user91" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("be9028d4-2672-4683-b08c-edadda40ec08"), 0, "2fe73fcb-1e0e-470e-80c5-e6669c288fc3", "user90@gmail.com", false, false, null, "USER90@GMAIL.COM", "USER90", "AQAAAAEAACcQAAAAEBMyMCu+QJNy5yG5nKllfICQ0hgrrIurMv8M8KfIdQi/ZKsuGne+lIJ8Z/DCTCXBWg==", null, false, "851dc5a3-2b89-44fe-b31c-905e6d4adba2", false, "user90" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7bc709b4-1472-4404-9931-ea4f2b8810b9"), 0, "0ffabd95-d9c9-47e8-8be9-8e4fb0190f2f", "user89@gmail.com", false, false, null, "USER89@GMAIL.COM", "USER89", "AQAAAAEAACcQAAAAEHP2QsgOkxisgSaIGfq0JlNPvLOEc1DQut/pFOud3Wg7s8Z7dQAEdDKbqQ2NpRvnpg==", null, false, "8380a3ed-9474-4775-94e0-452028287268", false, "user89" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("ff3e8fce-5a73-450e-9a1a-28943b78f11f"), 0, "d3e1e84d-2d17-4a18-a14a-256052f74851", "user88@gmail.com", false, false, null, "USER88@GMAIL.COM", "USER88", "AQAAAAEAACcQAAAAEHyHIV7+bahroSnGvcnd1iwaRXvl+ck/CO4ANthGtoIAz7iy1X6mRSposepK2xggxw==", null, false, "ad662761-89cc-4404-8687-2a3cb7383435", false, "user88" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("72e1c812-b16e-4b8f-b582-89fc8b64c232"), 0, "d0700d14-407e-4f0a-9eb9-b1c6e777afee", "user87@gmail.com", false, false, null, "USER87@GMAIL.COM", "USER87", "AQAAAAEAACcQAAAAEERdyiesVb7CC+5MLMFlFjNr9ofRWvj+lglmpvQzRKZ8K1WXJ7Ve5NEvEj6rqHIJkg==", null, false, "9d86fe74-d41e-40e2-8629-24688b20a2fd", false, "user87" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("8003128d-038e-4ce3-bb56-bda63ae38969"), 0, "e3bd2438-07c6-4603-a525-5c4ffca26841", "user86@gmail.com", false, false, null, "USER86@GMAIL.COM", "USER86", "AQAAAAEAACcQAAAAECi8uMGArtGVMrGAk1DjvvxC7Oq1wrxl0eH59jkix3cO0QTnYrr3JPltUnBmpHESMw==", null, false, "ead9613f-c6f2-4b69-9b02-a4ecd53dff15", false, "user86" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("20ae605b-0a65-422a-be5c-e098dda414df"), 0, "d4e256eb-d48c-48b0-9395-d5ca2ca28d9e", "user85@gmail.com", false, false, null, "USER85@GMAIL.COM", "USER85", "AQAAAAEAACcQAAAAEOV2ayTv4YIxIkeNJAZYfCGCkO4woQJhho+7pa3hDXzk0EJ4LVY0HRTAZaR30Ne4Sw==", null, false, "201f205f-3b33-4fb2-b38e-7b5862d6fce5", false, "user85" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7955b711-7b7b-432b-bb1c-b68c86fe95df"), 0, "221dd794-d5b8-4409-9528-2cf31b78105d", "user84@gmail.com", false, false, null, "USER84@GMAIL.COM", "USER84", "AQAAAAEAACcQAAAAEGb+hC1RnXTxt7WqNCEG9k5Ge/7zm/E7aMw3edtXxAeSrC6L3mGaNuzJHw2E1p7TBA==", null, false, "7942d56c-5739-46b5-a80a-bf9ce1cc2705", false, "user84" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("5f11cec2-fbcb-463f-9c40-5688d2e0b755"), 0, "545eb43e-6707-4761-a489-1295981f40f6", "user83@gmail.com", false, false, null, "USER83@GMAIL.COM", "USER83", "AQAAAAEAACcQAAAAEJ764FLJb8WoYubo5jk9StqK5jDHL6R/HXF8KvxsL/taZl5WjY/ye1O7lXXagWbYIg==", null, false, "6a924a07-5a8a-443e-8ab7-d8e62f4ea8c9", false, "user83" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("2e5b1f30-1636-4da9-ba38-07750fb86abe"), 0, "ef15d755-a954-49c9-a65f-790404610bfc", "user82@gmail.com", false, false, null, "USER82@GMAIL.COM", "USER82", "AQAAAAEAACcQAAAAEJy7AD4AU5Si6LgExdo/3qT5B5QxOeczvOiRDe76QjcKVN3XOuhC7RfmBg6v3RD1Qg==", null, false, "b50f6a21-84f6-4268-85a5-3f259d30ddea", false, "user82" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("9de78e0e-3168-453d-adf9-9aa0666ab4ce"), 0, "44bdb28f-7340-4b4b-bb4f-d717c41f5051", "user81@gmail.com", false, false, null, "USER81@GMAIL.COM", "USER81", "AQAAAAEAACcQAAAAEPaF9Qfvop3NY2cW9bMw+3SSoKUcIf/0THPw6nod5TIXh9C349qGI/im4jjaX0MSVQ==", null, false, "8a6c1c72-559f-4d9c-a101-764eddc83cbe", false, "user81" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("3672d839-40d4-4849-b3de-5557a43ced20"), 0, "0469d793-0e87-417d-8c31-832618d33436", "user80@gmail.com", false, false, null, "USER80@GMAIL.COM", "USER80", "AQAAAAEAACcQAAAAEEdD9CC3OejLFXN9oJM2W2ADsyZxtL7pz8siHfTUCZTDh2ILzsyaQJrPekbeYmWAkA==", null, false, "10742b4e-fb5a-4f17-83f5-6dd401fc3092", false, "user80" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("98cdaf88-3088-4189-a66b-3dec3bda9fa6"), 0, "58d066c2-6bb1-4681-90c8-ec5b91fe2840", "user79@gmail.com", false, false, null, "USER79@GMAIL.COM", "USER79", "AQAAAAEAACcQAAAAEE9ReFJss4JrxNejuntF2305TjyrzJI0IOuDRgmMLovPkPyuSGguPaj6k9X1ARaMuQ==", null, false, "4226fcce-0aa6-4023-87fc-f350ca590145", false, "user79" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("b8e5ee18-a69e-453a-a21e-4a2b951114a7"), 0, "ce37e638-1844-41dd-a127-9271d40f3447", "user78@gmail.com", false, false, null, "USER78@GMAIL.COM", "USER78", "AQAAAAEAACcQAAAAELj8sPsuKXVT50NUS4o1D5Bo2XaqkKf9KtMvW0o5WT+Tad4unbLksLXirJgmaaMZQg==", null, false, "1f1b487c-7c8e-47c8-a4f1-fcbcd1a0338e", false, "user78" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7205c1e1-79a7-41d8-83d9-e4cb909393cf"), 0, "fcc6b347-e24f-4d78-a66e-e045673b62ce", "user77@gmail.com", false, false, null, "USER77@GMAIL.COM", "USER77", "AQAAAAEAACcQAAAAEMAXbHDXXk4SdJJ51j2vGNIv85Gc8HBHRul28woM517DlmjysIFc4Zn3e+fhKAOfAA==", null, false, "3f00d6ca-e81c-4d20-8ae3-e43e5ab49f8d", false, "user77" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("dc1d050c-1525-4c59-a543-a135bf51c777"), 0, "6a89e976-fe9a-423e-9fed-c2722d63c38e", "user75@gmail.com", false, false, null, "USER75@GMAIL.COM", "USER75", "AQAAAAEAACcQAAAAEA5BEMp3D928P7UvGMQdKXfEI34tHLPBYVplwjXRwb1DG/i0XsTi/xks931tyvwasQ==", null, false, "d249d770-7310-4ec9-819c-eb70a67062fa", false, "user75" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("82a994db-d871-4639-908c-8b585d658440"), 0, "7888f67c-1d9e-4a11-b8a2-de775a91c119", "user50@gmail.com", false, false, null, "USER50@GMAIL.COM", "USER50", "AQAAAAEAACcQAAAAEK2zgAsIpMeWil9H3pdnH2Tg16kCbrP0ym3fcJFO3/FdNwgwzkl9BAk/94+LDFz/Cw==", null, false, "7bfc07a1-88d7-4b36-84ce-e85635694413", false, "user50" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("33203f6c-cfb8-4303-8074-dcb6ce416c2b"), 0, "9185e33a-e0ca-44fe-950c-a999ecf0425d", "user49@gmail.com", false, false, null, "USER49@GMAIL.COM", "USER49", "AQAAAAEAACcQAAAAEKpWJ67AvQ2v5f/RKnwRJWuEgXRjY6vYNnrBSZZZsCHA/H9OyUahkv04+EWtjF31BA==", null, false, "f033c3ce-416d-47d2-a943-a0d4f519343c", false, "user49" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("b3139a47-4ea5-4ae6-9400-ab7bb969d74c"), 0, "774ebc66-a7de-4fa1-992d-7ae471966a1d", "user48@gmail.com", false, false, null, "USER48@GMAIL.COM", "USER48", "AQAAAAEAACcQAAAAEPEd3qUWx1vIcgILUbDqVfQQFF/Ld7SFoPXiIGxXgJEvuAfKtVGOIxNU4ZrbIqu2QQ==", null, false, "f25d98d4-a4ea-4bc9-ade1-007ebea8a0a6", false, "user48" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("81569702-5fa9-4378-a568-1024cfeff93e"), 0, "90114224-38fe-4362-8ce3-76b31ee54859", "user21@gmail.com", false, false, null, "USER21@GMAIL.COM", "USER21", "AQAAAAEAACcQAAAAEDilo2mRkVlj56gzITdLHwmE7hdKfOjCoUaqBmX1cG52i4PRpvPKCbggd0Lyc4tGOA==", null, false, "a08bd211-489e-4bef-841c-c877c6f52c02", false, "user21" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d004ee46-e90b-4ee4-86ab-364ac7ed58ea"), 0, "7f2ae0a9-b091-4ea4-ba48-cc574a048ecf", "user20@gmail.com", false, false, null, "USER20@GMAIL.COM", "USER20", "AQAAAAEAACcQAAAAEMfjjRazFgocCzcMU5znOSl0lKofy2HPICurOL5TjRx8SOnkCgbSIWWXDAyUD1ktUQ==", null, false, "56de085e-adce-4f11-a18e-2dd2d3a27f5e", false, "user20" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("e649d65a-5619-4dca-a17f-9fef36f724b5"), 0, "1a24790c-a847-4b05-8958-8afe9a629d2a", "user19@gmail.com", false, false, null, "USER19@GMAIL.COM", "USER19", "AQAAAAEAACcQAAAAEHBsMbageMkLEIivIL/CHbjp+gMcmh3PF8h1bYTNQcVFiVK/nEEztpng8lowJhLZsw==", null, false, "ee6d895d-5f22-4f30-a735-05c44d3eb888", false, "user19" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("e0c9a0e9-0ea2-45ad-ae18-395c898e1dfc"), 0, "7717510f-8ab3-454e-a6fa-883ebeea6a18", "user18@gmail.com", false, false, null, "USER18@GMAIL.COM", "USER18", "AQAAAAEAACcQAAAAEM2IBkyZxDwkFjzroRPv+yt8OtinNurGzGCpN9bjZnHeT2X6tbFUWdUfqk1lyE2aTA==", null, false, "3172947e-0e3f-434e-86ab-eb659e250ba3", false, "user18" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("8a0af2a5-7b3b-4a66-a2e2-9439099dee39"), 0, "174c0711-7d53-401e-9cff-2c329f785478", "user17@gmail.com", false, false, null, "USER17@GMAIL.COM", "USER17", "AQAAAAEAACcQAAAAEMAhRWeFjYscdo45r1r7syGydTX2MjmrthcHHmbTt5iFsCoUv9Hhotn7z5QoyTJWgg==", null, false, "e0992058-a1a8-4cdf-be76-72fd0a236dc3", false, "user17" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("078b6926-237d-491d-b162-15beb6aef10a"), 0, "49972a38-38f2-41ac-acd0-02d5f22412be", "user16@gmail.com", false, false, null, "USER16@GMAIL.COM", "USER16", "AQAAAAEAACcQAAAAEHTHxHUoft1Ao0qBwwAaZNFp+MqH5weKhNoVM+fwIXpv8LHf5DCjjMpSTIKQj2o/1A==", null, false, "c6b940fd-d357-4b76-a9d2-47bccb454b52", false, "user16" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("1e33f8ab-400f-46a7-bc27-34ac5a649bcb"), 0, "cb9ec9e8-1712-41b2-95db-d888e2390732", "user15@gmail.com", false, false, null, "USER15@GMAIL.COM", "USER15", "AQAAAAEAACcQAAAAEAql8uxpU37h85c2fEsCP6sLrUVCXhA6A1m5WWeAgIs0s0I4gI2mJEkOzCwXf26QhA==", null, false, "dfa09c21-7278-457b-a4e0-838d221f3e68", false, "user15" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("a7f16555-0652-4fd4-818c-2a6ababc0e18"), 0, "6b95990f-ccbd-48f8-a42f-7c3ccf30783b", "user14@gmail.com", false, false, null, "USER14@GMAIL.COM", "USER14", "AQAAAAEAACcQAAAAEFl2pAvWp8vlj1wolTaTEe+rrgvFNKjp5vIyyqv+acgI6VCu+BngHZHQB8aUwza/vQ==", null, false, "304f8bda-98e3-40a7-a528-ae2ff4679eec", false, "user14" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("47e831c8-0f42-48f8-ab07-cb9757ce22b2"), 0, "ec241bc9-ad8c-40f0-becc-eed56532c701", "user13@gmail.com", false, false, null, "USER13@GMAIL.COM", "USER13", "AQAAAAEAACcQAAAAEOqCx33DrSWmTDtwOXKPCLpm7JZNd37GmkDgnCuJPjAj8HcHSDBe3n3DrqC0wlHpfQ==", null, false, "738eba8d-e94b-4af3-84aa-2351ad633b1c", false, "user13" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("9a31e8d6-fc78-4744-abd3-2c3497b7fa41"), 0, "67a833ee-5d92-4ef9-ab9e-ca4d19f1afbc", "user12@gmail.com", false, false, null, "USER12@GMAIL.COM", "USER12", "AQAAAAEAACcQAAAAENoKDTMpjKS5RuJ6zdftIJ+DQqvGTx7UGe+0P2/FxZn+X8Ir65NSilmEicopOexfLA==", null, false, "ab20d2a7-74fc-4b0a-bde6-06d2a1f4cd19", false, "user12" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("b476ac10-7399-4bb6-9115-0285727d876b"), 0, "5e7f6132-0f10-4c37-9a3f-0d82a9df963b", "user11@gmail.com", false, false, null, "USER11@GMAIL.COM", "USER11", "AQAAAAEAACcQAAAAEG7Q71i7OcpPfNskg5nVnDx49phgubxuyd4PDI+IANFsrxvgvMzFVwsGH3z4mEI02w==", null, false, "7218a082-b284-423b-8070-d7b4fd3526a4", false, "user11" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d63b80f8-ae6e-4e1f-9254-4aac6c256784"), 0, "06b9aec9-eb53-4d37-841f-36e760b584be", "user10@gmail.com", false, false, null, "USER10@GMAIL.COM", "USER10", "AQAAAAEAACcQAAAAENgCbWPjRILWDXXiGU+He9bZoftjIl2mT4fqfajZwz7fYIm7JQVvCKwwXRiFSSpZwg==", null, false, "1aaddae4-7a03-4597-8e11-b580c1dee55e", false, "user10" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("214c4746-72b4-4bbb-b2f9-8c4e68b9f983"), 0, "00e83bd3-f27a-4b67-baee-d95ec1010a0c", "user9@gmail.com", false, false, null, "USER9@GMAIL.COM", "USER9", "AQAAAAEAACcQAAAAEJWZGUFpSZk/n8F3ZdH42TjOQbo8R0pdavDLZIB7t+vpCKWGMZXsXrLR5+aCgOrfXg==", null, false, "87a23ad1-7635-41d8-8962-27767fee1642", false, "user9" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("a18ef52a-6091-4665-b946-78b9f1cb60b7"), 0, "39356213-8e0d-42cd-bc9e-c1588a55c587", "user8@gmail.com", false, false, null, "USER8@GMAIL.COM", "USER8", "AQAAAAEAACcQAAAAEOJidQqMZzpNA7xBbBTBM45NgF3vkEXzwQ9yCS22o1jceQhMyhdvB8WIj8EN07cmCA==", null, false, "0cb196a8-8d5e-45c1-bcec-fb3cba537a1e", false, "user8" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("b892ebbe-9dcd-4bec-9a4a-b2da8013bc4f"), 0, "42d59829-52d9-4559-bde2-a6614d5bd24f", "user7@gmail.com", false, false, null, "USER7@GMAIL.COM", "USER7", "AQAAAAEAACcQAAAAEOAZ678kEXN6OSSlP/2Ys/Ueh9sSvFFbNbKmUua6tUKIEywZ6y34IE5ZQJtXwQyQgg==", null, false, "e196e390-723c-43fb-8400-de83c9f6dd3e", false, "user7" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("6c431117-c51f-4e39-9c87-5a53c5ff47af"), 0, "6f212c72-8660-40d7-ae1b-9aab0a1f2111", "user6@gmail.com", false, false, null, "USER6@GMAIL.COM", "USER6", "AQAAAAEAACcQAAAAELzVPQyz4h9sI8ilrqDWsI5ZqzzdcAjGRtytGjisSxQdu6rDA7M6aCkvl7GJvIQhQA==", null, false, "6d6c3085-7c6b-4166-bd03-f7c769ca9800", false, "user6" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("a38873db-adfd-4584-aff7-756085ea7b7c"), 0, "aeb933d6-dd7b-4d2e-a243-31f4972ea46e", "user5@gmail.com", false, false, null, "USER5@GMAIL.COM", "USER5", "AQAAAAEAACcQAAAAEKDXd0Yjcm2VsKnrZ1T+OaQo/PDlK9cUVHrkkOSOHC6nlsIjlXmhWdAmHvND5xWCNw==", null, false, "a4bccede-9ada-4f55-92e4-e09ec7652f7a", false, "user5" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("38ece001-9103-4a4a-9a07-ebec3dcaeb78"), 0, "eb112639-9d65-4cfe-9834-c6a79ab1b528", "user4@gmail.com", false, false, null, "USER4@GMAIL.COM", "USER4", "AQAAAAEAACcQAAAAEPC+4WWpZnk4fvEXpup0lNocKVt6eyokDAv4HV/gwhTM0pkOeRnscyq88u6WLpWYOg==", null, false, "43a5b289-d218-445f-9477-f7670b272100", false, "user4" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("ea3dc1dd-3b33-45a0-90ae-ff73134c329e"), 0, "37bde8c0-17f9-4e69-8cf0-b0733f241809", "user3@gmail.com", false, false, null, "USER3@GMAIL.COM", "USER3", "AQAAAAEAACcQAAAAEKxnlSeT9NZEwLX0R9L87o1H04AkJzXaUG0vBRYajKyD2/FOIMdq4Pmt77USEVTd0A==", null, false, "723efb58-c826-42c4-8f9f-4271788c890d", false, "user3" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("961a3f2c-6b42-4550-b583-ed872142afd0"), 0, "f32be428-31e3-4e06-afd9-42409cea0029", "user2@gmail.com", false, false, null, "USER2@GMAIL.COM", "USER2", "AQAAAAEAACcQAAAAEA40IEoiggVWCqm2F9dgYZCKtzSiAQ711MoJCtHHpI6BABaa/EHMGJqV9mWwYHlUNw==", null, false, "0d55c022-450d-4308-adb3-f1b234a3755e", false, "user2" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("b9125656-d278-449e-8e9f-af52e05f7822"), 0, "2f925720-69b4-4aa1-a2e3-84324af9bec6", "user1@gmail.com", false, false, null, "USER1@GMAIL.COM", "USER1", "AQAAAAEAACcQAAAAEMA05QcPA1S3NctqcArKrlwzciypExs2YRS8UFaAo/0dO7L4LSNm1hLCvz7gY1474Q==", null, false, "aa0b3772-9a96-428e-95d8-28b9ceea7d8b", false, "user1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("8499610f-10eb-412b-8fea-f5ce8c0583c2"), 0, "e82e2936-77f6-42cf-8a56-ec5e79e8ef27", "user22@gmail.com", false, false, null, "USER22@GMAIL.COM", "USER22", "AQAAAAEAACcQAAAAENu07SNGCEKbqA4R50pqix9SLFQ1/4C/gO21sbwhM7Yru+GMZAz85n2vLWazyP9nKw==", null, false, "225bb0df-fdb6-4c8e-b607-c526573c19d4", false, "user22" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("acd7fa80-757a-42d6-bb78-1247c22c34ec"), 0, "fd48e435-d4ff-4406-88c4-55aeb5c41dcc", "user23@gmail.com", false, false, null, "USER23@GMAIL.COM", "USER23", "AQAAAAEAACcQAAAAEFSlB7GzZi0H/pNNWiUOAbJNK5ViNjL3AsOb3b1vlxjjPddtukNlySs5ZfzY+UIyxA==", null, false, "704e837e-9498-49e7-a393-8175bebe6377", false, "user23" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f2c6f0fb-a99c-4e79-951a-3fcf52469ec3"), 0, "784ec43e-a411-46e7-b7ee-2a2c63b12e1c", "user24@gmail.com", false, false, null, "USER24@GMAIL.COM", "USER24", "AQAAAAEAACcQAAAAEA0v2+qMKhJcEAxnzm5+QUdzRg2X+Wf/l6dzT3wfHWcgD8g8Ud5PXIZrHmiQwSdNgA==", null, false, "10f1eb38-e0c6-4482-8a60-db74594c13f3", false, "user24" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("6bd6c231-36ed-497d-ba49-947d8a9b4e01"), 0, "46fd423c-9d8e-42b5-b736-4be77645c3f9", "user25@gmail.com", false, false, null, "USER25@GMAIL.COM", "USER25", "AQAAAAEAACcQAAAAEBAayvz4c62G1TZAurLJf2q9IqJkde6Tw8CdThlSYPSs9Lnc8CwX5oRKYz4br8JMsg==", null, false, "8ea6582a-4e4d-487d-a64c-5bf08c7319fa", false, "user25" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("cc4bfaf6-ad9d-4765-aaf0-ad8664e300c7"), 0, "06e5065f-df45-462c-acab-ac7b127477d5", "user47@gmail.com", false, false, null, "USER47@GMAIL.COM", "USER47", "AQAAAAEAACcQAAAAELRcBvZPLyeEb60h2pnanJR+jF4v7LGiBz8U4v6zCo43j8wj4Qj7EkWwSelUkzeNwQ==", null, false, "a3287507-8a21-4ab7-a117-b11856a77036", false, "user47" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("c5c14717-dc0a-4230-be5d-2e10a7648ecb"), 0, "a85a32ae-b38f-4fd7-9587-5bc1d11b79a6", "user46@gmail.com", false, false, null, "USER46@GMAIL.COM", "USER46", "AQAAAAEAACcQAAAAEKhwN08VpJwdGRjaxtNSymgr9kVEPKn1NiGcKF0llNRJl8QkcpMO9gu1krCcUxR3fw==", null, false, "88088328-c396-40c2-ae44-c89a09c74627", false, "user46" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("bd6bf576-cc9b-4f9b-bee1-6a38360a511b"), 0, "25b1d710-8a18-46a8-b05e-912ede0a2318", "user45@gmail.com", false, false, null, "USER45@GMAIL.COM", "USER45", "AQAAAAEAACcQAAAAEBFHNkPp8LeNyeTcCN6OQFS8BaG/3Hd7NkdgVO1B9hfnR4zHNW5LMrDIz1/1hnLsZw==", null, false, "fb9d9467-aeea-4c9d-9bb8-3d323912d121", false, "user45" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7d1abff8-8245-4136-8521-e0b823513122"), 0, "872840ac-c087-417e-b12e-4c4b326db35d", "user44@gmail.com", false, false, null, "USER44@GMAIL.COM", "USER44", "AQAAAAEAACcQAAAAEGSLBKIecjLP9dN5rP0p3cOv4T8hCYFz9m5a8y0GI3SpvPoqXqp8+3E+vYXk2cPgQQ==", null, false, "bb7f2ca6-6130-4ab9-ba2f-ccdc1a460c1b", false, "user44" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("8db6ce9b-b79f-49be-8f15-29fbde93ac5f"), 0, "d7fe1ec8-4984-40e6-9f9e-2c4e2c2f8f89", "user43@gmail.com", false, false, null, "USER43@GMAIL.COM", "USER43", "AQAAAAEAACcQAAAAEOa3CxMYYOpJGQJAgCk4SStJikXPeIsl4XmdAvJokynYGL3GFD9N4Y5Vgd2yRGZtoQ==", null, false, "2ebfe428-0188-4123-8a99-ec6dd4b9ebbd", false, "user43" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("aa25d88b-cd10-4562-a4a2-d398f98bea1c"), 0, "2ba54b63-2548-49c2-a8a2-dfa0e7efc4c7", "user42@gmail.com", false, false, null, "USER42@GMAIL.COM", "USER42", "AQAAAAEAACcQAAAAENlN5EE15u6gCUWcx3oYRfAeCocU9NIPu8cnykJ9jMHQI36JrN21wdxNYBg80zga8Q==", null, false, "9d5d31cc-4d25-4712-a120-79f33b37b6ca", false, "user42" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("50f2c0d8-3502-4930-bce3-a209e2abd90d"), 0, "99b6e8f8-85a0-400d-a3fb-78ce986b5872", "user41@gmail.com", false, false, null, "USER41@GMAIL.COM", "USER41", "AQAAAAEAACcQAAAAELbR0GbXReGOYBOPFSQhidSz+SetJn9EB9VFep56VKUSzxCKV25LzQZu2aWUk+Ot9g==", null, false, "1ec64b64-366e-4ab9-9f06-5471e5816894", false, "user41" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("5b3e08dd-4daa-448a-8d7c-5aa24ec06ce8"), 0, "2c9bc0d0-9b86-43da-94cb-d95735355f6e", "user40@gmail.com", false, false, null, "USER40@GMAIL.COM", "USER40", "AQAAAAEAACcQAAAAEONwDadeMsMGnXTuoI2P6bQ1mpJtTWUi+mtSqhe85pE4IfffjOY2Ta5EAUTImZyR/Q==", null, false, "dd4ff9ae-b972-4ebe-a1ac-b45613b1ec43", false, "user40" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("ebb0b732-a3db-41ed-9069-18798b61b112"), 0, "99ac8f1e-235e-4b4c-a700-c44ff81c8711", "user39@gmail.com", false, false, null, "USER39@GMAIL.COM", "USER39", "AQAAAAEAACcQAAAAEEWXt3M+p0ScTyj7Xq/aMSWLHKHa3MBTPuX6BHEGreD1cUDzYXRK9I/FiZ2EjgsiDA==", null, false, "bde4fa7c-3459-4a15-86cc-7ac46f5686af", false, "user39" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("02dfa7b7-917e-490b-9e85-a0785c45955a"), 0, "db06ad60-220c-444f-9947-4a9a51066a85", "user38@gmail.com", false, false, null, "USER38@GMAIL.COM", "USER38", "AQAAAAEAACcQAAAAEJ4ndKIdsGjW1u+GijAfbhPw/FUU86cMlDIWh4qxUX48bggMhED0XwlRzhC7pz2S1g==", null, false, "cd73e528-c225-443c-91dc-f2d93118490a", false, "user38" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("0fa7c72f-2b63-477b-bac9-c34dd513fbc8"), 0, "27d491b7-2d2f-4480-a886-f6d57d78acb0", "user98@gmail.com", false, false, null, "USER98@GMAIL.COM", "USER98", "AQAAAAEAACcQAAAAEEbZZJn5Pt2sHXdlBbwSGe/gu3KOHIij7em0GppwNhOKV6rNutBLXgRBfxwcHrKUtg==", null, false, "957c4862-17ba-4df7-b9a1-7031d945c104", false, "user98" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("2f9e00b4-c3ec-471d-96e8-0908028c66aa"), 0, "a2c395cc-d95b-4814-b148-82af4ffc5edf", "user37@gmail.com", false, false, null, "USER37@GMAIL.COM", "USER37", "AQAAAAEAACcQAAAAEE7uzXQtGVJLI0yO8CteUKXgpR3JRQXnHibAAdp3/zJe7GErSvxnf5xwh6R+YrqgKA==", null, false, "00f0894c-1f41-41e5-b5ad-fb7678c34b88", false, "user37" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("97d7a67b-f7c9-4b2a-87c7-61ebcbca65ae"), 0, "ec982134-0833-47e6-ba68-867a7369c075", "user35@gmail.com", false, false, null, "USER35@GMAIL.COM", "USER35", "AQAAAAEAACcQAAAAEC3NxArpaqEr5UuSV5nMVomR3HgS3bL/6DnyQaXy84wJvOMRwKldDS01w17viJ8ceA==", null, false, "4be20312-f8e5-4a04-8e3a-287f5d38d779", false, "user35" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7a39a5d3-b008-4b9e-ad1c-07914090da8c"), 0, "01d3a2b7-94fd-4f5d-b25a-33a13dd306c8", "user34@gmail.com", false, false, null, "USER34@GMAIL.COM", "USER34", "AQAAAAEAACcQAAAAEE/lx/MzpVwYth7Kt6mtKfuyXlQMzTS58sHcwOoe/f3HwQsc9ldfKPYa2W7s0pQ9ug==", null, false, "b385764e-6088-4caa-949c-095ad8bfbd21", false, "user34" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("b97d82ba-8db7-4520-be7e-411ae4a9fe86"), 0, "c3a6707b-d4b5-42e8-ba38-1a44816fd23f", "user33@gmail.com", false, false, null, "USER33@GMAIL.COM", "USER33", "AQAAAAEAACcQAAAAENMZfb2ECEItUN22p5iOxBJFI+Eu3UhDtrXKueN8ifMnMd1lMNyVJxpAdQ3iPu+aEg==", null, false, "52acefaa-8707-453d-aeed-956be774391e", false, "user33" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("ea1b0fb8-1b43-4308-886a-8605cdf5e916"), 0, "f412e311-9a5c-4948-bb2d-8cbaf043c45e", "user32@gmail.com", false, false, null, "USER32@GMAIL.COM", "USER32", "AQAAAAEAACcQAAAAEAPHUZlqtb38qSlr/vRYL5tlMXFf6T+ilAVJXupYraMXNg8OcmTuhbRhC0r0ohFdwg==", null, false, "3a69072f-6548-4fb1-b14f-28d1e9d48298", false, "user32" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("bd795fa0-6d37-4149-8e64-a243c4c3c956"), 0, "cdf52301-6836-4ef8-9b97-a1f2643029c4", "user31@gmail.com", false, false, null, "USER31@GMAIL.COM", "USER31", "AQAAAAEAACcQAAAAEJtYC3wctyI02K2g4fWB76VGtIimvYdGh2lywrLZvwdpqOAsjGNHRU+UcQ9R+iBfuw==", null, false, "df2f3330-224c-4385-a5b8-d12a1251ca1d", false, "user31" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("4abb15b6-67c8-449d-bcbd-f1a72a060f39"), 0, "2e007192-2d75-456c-96fd-2c87984d688d", "user30@gmail.com", false, false, null, "USER30@GMAIL.COM", "USER30", "AQAAAAEAACcQAAAAEAHOJuXGFU7PHp96bP9n3KW5w4G1zqbeguSZWT5esGRjGcskpsbgkFCgr1AitEQK6Q==", null, false, "86e36f0f-ed5e-4ed0-842f-697254fed5f0", false, "user30" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("6cfa4d0a-8db6-44b1-885b-5e149055868e"), 0, "bc64686e-cd58-4458-9c54-adb4217ed242", "user29@gmail.com", false, false, null, "USER29@GMAIL.COM", "USER29", "AQAAAAEAACcQAAAAEJuXEOIIGV9gHI+Nl5VGOBKU0ui4Y8ugztQLER/hHuwjBuHCC8ZjzpL5gdeVTdionA==", null, false, "225fb115-15b2-4ac9-8adb-ecf79b06b653", false, "user29" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("eae0f4f3-d570-4b7a-881b-a0f0f3b340eb"), 0, "09f3db78-03dc-44a5-a63c-3e5da60377b5", "user28@gmail.com", false, false, null, "USER28@GMAIL.COM", "USER28", "AQAAAAEAACcQAAAAEPU2pGELS/AjbBN5Ac+IUuCNAiISe53C5yx+HheF+L2/GPT8lugUBxchwU/sPNjfKw==", null, false, "85c1fbe3-110e-49a6-b22b-fb9fe78088fb", false, "user28" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("78702bd5-4593-4ee4-90b9-61878f6d1cdc"), 0, "479dabc6-32ef-49b0-a8ec-ce77530afc0c", "user27@gmail.com", false, false, null, "USER27@GMAIL.COM", "USER27", "AQAAAAEAACcQAAAAECUrW4ugfKVFfqVJrKceWvwqVVp956hEr77JhTiisq9B369pVoRwAgLRny1u2IYjTA==", null, false, "4ed2beff-9723-479a-8ffa-73bbbae5a9c6", false, "user27" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("9ff79fbc-b003-4199-a695-68399f388a4c"), 0, "81612cbd-bf5c-484c-bb23-76e10c877ba2", "user26@gmail.com", false, false, null, "USER26@GMAIL.COM", "USER26", "AQAAAAEAACcQAAAAEC2NA/sh53lg+ASFGDUnrm7Pr6VfbDo3Ed7B7kXNNtKS/SypZ7oltf7b2BeOTIXm/Q==", null, false, "e92a8677-a4ec-457c-90e8-b6fb597828eb", false, "user26" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("52b762ef-c314-42a6-83ad-4ab2fa7c5cc6"), 0, "9ee4e5cd-7e61-4e29-a75b-b7a740ff207e", "user36@gmail.com", false, false, null, "USER36@GMAIL.COM", "USER36", "AQAAAAEAACcQAAAAEIoguJvXboBw2rBBOAbhBtIE8M2eilSXl2NIVBpChadczcMj95JLaDSpzmgviZ0VjQ==", null, false, "7eb99813-9f0a-46b6-8d6c-e9e4282b987c", false, "user36" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("4def59ef-efdf-4eea-89ad-d7fcd6e59bbe"), 0, "f6809f02-ae1b-4b00-bf23-68254766dc3a", "user99@gmail.com", false, false, null, "USER99@GMAIL.COM", "USER99", "AQAAAAEAACcQAAAAEOmiOzvhfDbGVostEB7t0iRBNyg4I4CAYafUx1uNzW3ozZfwsdXaR7B+NTHajJRDJA==", null, false, "751b8642-6e27-49a1-907f-0848150ee560", false, "user99" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("02dfa7b7-917e-490b-9e85-a0785c45955a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("078b6926-237d-491d-b162-15beb6aef10a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0a730ae6-3a8f-49a4-b4bd-1a4027162905"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0fa7c72f-2b63-477b-bac9-c34dd513fbc8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e33f8ab-400f-46a7-bc27-34ac5a649bcb"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("20ae605b-0a65-422a-be5c-e098dda414df"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("214c4746-72b4-4bbb-b2f9-8c4e68b9f983"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("226808e7-4caf-4461-8a13-ebeb46e9bb73"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("25993e7e-5316-49b9-be67-5f30473f2d69"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("26596f9f-ae0a-4b16-a368-34515f396eab"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e5b1f30-1636-4da9-ba38-07750fb86abe"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2f9e00b4-c3ec-471d-96e8-0908028c66aa"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("33203f6c-cfb8-4303-8074-dcb6ce416c2b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("33516dee-2753-410f-ab83-8ff1c463ea0f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3672d839-40d4-4849-b3de-5557a43ced20"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("36cb9e5e-af0e-4379-b788-b1018a3535ee"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38ece001-9103-4a4a-9a07-ebec3dcaeb78"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3f29ebb0-e29e-42c6-a365-257baa041c29"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("400afb64-4711-4fd5-9d02-289187aafbb6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4051c142-06e4-44a7-8ee1-d36fc256dd2d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("47e831c8-0f42-48f8-ab07-cb9757ce22b2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4abb15b6-67c8-449d-bcbd-f1a72a060f39"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4def59ef-efdf-4eea-89ad-d7fcd6e59bbe"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("50f2c0d8-3502-4930-bce3-a209e2abd90d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("52b762ef-c314-42a6-83ad-4ab2fa7c5cc6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5a6fae2f-5f8b-4355-bde3-1ca1d8bc5568"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b3e08dd-4daa-448a-8d7c-5aa24ec06ce8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5d370b9a-939a-4f88-8888-e4102a123e3d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5f11cec2-fbcb-463f-9c40-5688d2e0b755"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("677b03f4-34ec-43aa-9763-80f1c95aa742"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6bd6c231-36ed-497d-ba49-947d8a9b4e01"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6c431117-c51f-4e39-9c87-5a53c5ff47af"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6cfa4d0a-8db6-44b1-885b-5e149055868e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7205c1e1-79a7-41d8-83d9-e4cb909393cf"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7252719b-c558-4d92-9f6d-fd9d7b400bd6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72e1c812-b16e-4b8f-b582-89fc8b64c232"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("78702bd5-4593-4ee4-90b9-61878f6d1cdc"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7955b711-7b7b-432b-bb1c-b68c86fe95df"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a39a5d3-b008-4b9e-ad1c-07914090da8c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7bc709b4-1472-4404-9931-ea4f2b8810b9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7d1abff8-8245-4136-8521-e0b823513122"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8003128d-038e-4ce3-bb56-bda63ae38969"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("81569702-5fa9-4378-a568-1024cfeff93e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("82a994db-d871-4639-908c-8b585d658440"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8499610f-10eb-412b-8fea-f5ce8c0583c2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("86aadce6-2de2-4e06-a90e-279eef332bbd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89ebfddb-995a-4195-b6ed-df8a3e3461f4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a0af2a5-7b3b-4a66-a2e2-9439099dee39"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8db6ce9b-b79f-49be-8f15-29fbde93ac5f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("948bca64-f7d2-457e-a2e7-9aaf5d32cc5c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("961a3f2c-6b42-4550-b583-ed872142afd0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97d7a67b-f7c9-4b2a-87c7-61ebcbca65ae"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("98cdaf88-3088-4189-a66b-3dec3bda9fa6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9a31e8d6-fc78-4744-abd3-2c3497b7fa41"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d681558-2426-4c07-9f09-decd8cd5e307"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9de78e0e-3168-453d-adf9-9aa0666ab4ce"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f0a4f61-2b92-4731-913a-9a288424dcc4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9ff79fbc-b003-4199-a695-68399f388a4c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a18ef52a-6091-4665-b946-78b9f1cb60b7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a1a87345-33b4-436a-9a10-1536d7d73a60"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a38873db-adfd-4584-aff7-756085ea7b7c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a7f16555-0652-4fd4-818c-2a6ababc0e18"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aa25d88b-cd10-4562-a4a2-d398f98bea1c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aa6338af-1dbe-4dea-a2bb-19eb6789298f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ac5c2b5e-cd18-40d4-8e91-21c719365673"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("acd7fa80-757a-42d6-bb78-1247c22c34ec"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b05499c4-c748-4fe1-bf81-c0e5070a8c66"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b3139a47-4ea5-4ae6-9400-ab7bb969d74c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b476ac10-7399-4bb6-9115-0285727d876b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b524972d-8f75-45b0-a6b4-35df08de7c1b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b892ebbe-9dcd-4bec-9a4a-b2da8013bc4f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b8e5ee18-a69e-453a-a21e-4a2b951114a7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b9125656-d278-449e-8e9f-af52e05f7822"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b97d82ba-8db7-4520-be7e-411ae4a9fe86"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bd6bf576-cc9b-4f9b-bee1-6a38360a511b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bd795fa0-6d37-4149-8e64-a243c4c3c956"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("be9028d4-2672-4683-b08c-edadda40ec08"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c39298de-dc10-4734-baa2-67334afcd794"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c5c14717-dc0a-4230-be5d-2e10a7648ecb"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cc4bfaf6-ad9d-4765-aaf0-ad8664e300c7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d004ee46-e90b-4ee4-86ab-364ac7ed58ea"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d0bf492d-2a91-4a38-abe6-584ac3c42752"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d63b80f8-ae6e-4e1f-9254-4aac6c256784"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d74f5053-f8b2-48ff-8efb-0c2696dc5288"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d7a79608-8f20-4fd2-ac41-0d98700690be"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d7eddbdc-e829-4e89-98b7-d62f7dd266cc"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9646528-4803-4960-8677-d4f664e8a27c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dc1d050c-1525-4c59-a543-a135bf51c777"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e0c9a0e9-0ea2-45ad-ae18-395c898e1dfc"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e649d65a-5619-4dca-a17f-9fef36f724b5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea1b0fb8-1b43-4308-886a-8605cdf5e916"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea3dc1dd-3b33-45a0-90ae-ff73134c329e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("eae0f4f3-d570-4b7a-881b-a0f0f3b340eb"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ebb0b732-a3db-41ed-9069-18798b61b112"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("edf85368-db3d-456d-a4ac-fe77089198e0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2c6f0fb-a99c-4e79-951a-3fcf52469ec3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4fb2a4e-d1ab-497a-8ffa-0f070b0d985c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f73c2694-5b0d-4dc1-9920-b1a54ab86844"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f7d05861-0d44-43d7-8aa8-b0696b04583e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ff3e8fce-5a73-450e-9a1a-28943b78f11f"));
        }
    }
}
