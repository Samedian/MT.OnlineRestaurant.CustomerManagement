using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MT.OnlineRestaurant.DataLayer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoggingInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValueSql: "('')"),
                    ControllerName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, defaultValueSql: "('')"),
                    ActionName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, defaultValueSql: "('')"),
                    RecordTimeStamp = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoggingInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblCustomer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: false, defaultValueSql: "('')"),
                    LastName = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: false, defaultValueSql: "('')"),
                    Email = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: false, defaultValueSql: "('')"),
                    MobileNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    Password = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: false, defaultValueSql: "('')"),
                    PasswordKey = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: false, defaultValueSql: "('')"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "('')"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    UserCreated = table.Column<int>(type: "int", nullable: false),
                    UserModified = table.Column<int>(type: "int", nullable: false),
                    RecordTimeStamp = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "((0))"),
                    RecordTimeStampCreated = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "((0))"),
                    Totalorders = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCustomer", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoggingInfo");

            migrationBuilder.DropTable(
                name: "tblCustomer");
        }
    }
}
