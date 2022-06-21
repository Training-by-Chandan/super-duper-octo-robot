using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Octo.ECom.Data.Migrations
{
    public partial class functionAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "826d6171-a044-4f4c-b0b6-2979e0bb53ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4679d2ff-efa2-496e-aa14-92531de3be6a", "AQAAAAEAACcQAAAAEFErG84Sx9ETLiCWjAa8vzftym0ER1jBbCjyzm6SbisIt+5Fo8xW4UmjcrZ8qMNxNw==", "b5ebcd9b-d08d-4fe7-9e18-92570b8aa5fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95119256-753e-4d5c-a1bf-b307200b64b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79c51ea3-57ab-449c-8d5d-7f45c9c24576", "AQAAAAEAACcQAAAAEGaH+XhyDXDDcIGq0Rg/gH8EKmS4HfUeaat40eVtoPvMlGD8VXYJdHaAKdsxd4bLVg==", "f66e174f-b75f-499d-9502-b48a3082cce7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "826d6171-a044-4f4c-b0b6-2979e0bb53ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5569e10a-0f68-4217-b85d-0cebc66646e7", "AQAAAAEAACcQAAAAENonMaubhAIfSjbYpArZxN1gUPNSyZvgJACstbLsO9KBkGYUphfxRgLmU4Rj0CP0hw==", "1cc35525-072d-43f9-9e8b-7e0218deb56f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95119256-753e-4d5c-a1bf-b307200b64b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36ac8127-957e-46ff-a08d-30fc89806650", "AQAAAAEAACcQAAAAENZ9WyyTxpeoU9LNBgYJfmpp2iEV3iwExRUOLp261R2VMYPTHnICWuh/0ZtOpricug==", "355000d0-e638-4e2a-bf7d-8bdb7079f3a6" });
        }
    }
}
