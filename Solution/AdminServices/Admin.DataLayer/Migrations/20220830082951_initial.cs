using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Admin.DataLayer.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Policies",
                columns: table => new
                {
                    PolicyKey = table.Column<string>(nullable: false),
                    QuoteId = table.Column<int>(nullable: false),
                    PolicyEffectiveDate = table.Column<DateTime>(nullable: false),
                    PolicyEndDate = table.Column<DateTime>(nullable: false),
                    PolicyTerm = table.Column<int>(nullable: false),
                    PolicyStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policies", x => x.PolicyKey);
                });

            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    QuoteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Premium = table.Column<double>(nullable: false),
                    Dwelling = table.Column<double>(nullable: false),
                    DetachedStructure = table.Column<double>(nullable: false),
                    PersonalProperty = table.Column<double>(nullable: false),
                    AdditionalLivingproperty = table.Column<double>(nullable: false),
                    MedicalExpense = table.Column<double>(nullable: false),
                    Deductable = table.Column<double>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.QuoteId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    IsRetired = table.Column<bool>(nullable: false),
                    IsValid = table.Column<bool>(nullable: false),
                    SocialSecurityNumber = table.Column<int>(nullable: false),
                    UserType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Policies");

            migrationBuilder.DropTable(
                name: "Quotes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
