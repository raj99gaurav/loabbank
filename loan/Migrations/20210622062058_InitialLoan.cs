using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace loan.Migrations
{
    public partial class InitialLoan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoanType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoanAmount = table.Column<double>(type: "float", nullable: false),
                    LoanApplyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LoanIssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RateOfInterest = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    CourseFee = table.Column<int>(type: "int", nullable: false),
                    Course = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherExperience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RationCardNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnnualIncome = table.Column<double>(type: "float", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalExperiance = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loans");
        }
    }
}
