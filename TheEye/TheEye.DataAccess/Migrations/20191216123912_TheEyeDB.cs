using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheEye.DataAccess.Migrations
{
    public partial class TheEyeDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(nullable: true),
                    CompanyPhone = table.Column<string>(nullable: true),
                    CompanyMail = table.Column<string>(nullable: true),
                    CompanyAdress = table.Column<string>(nullable: true),
                    CompanyCity = table.Column<string>(nullable: true),
                    CompanyDistrict = table.Column<string>(nullable: true),
                    CompanyTime = table.Column<DateTime>(nullable: true),
                    CompanyType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    UserYears = table.Column<DateTime>(nullable: true),
                    UserGender = table.Column<bool>(nullable: true),
                    UserPassword = table.Column<string>(nullable: true),
                    UserPhone = table.Column<string>(nullable: true),
                    UserMail = table.Column<string>(nullable: true),
                    UserCity = table.Column<string>(nullable: true),
                    UserDistrict = table.Column<string>(nullable: true),
                    UserAdress = table.Column<string>(nullable: true),
                    UserType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "CarParks",
                columns: table => new
                {
                    CarParkId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarParkMax = table.Column<int>(nullable: true),
                    CarParkDisabled = table.Column<bool>(nullable: true),
                    CarParkWashing = table.Column<string>(nullable: true),
                    CarParkTire = table.Column<string>(nullable: true),
                    CarParkFloor = table.Column<byte>(nullable: true),
                    CompanyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarParks", x => x.CarParkId);
                    table.ForeignKey(
                        name: "FK_CarParks_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    MedicineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MedicineName = table.Column<string>(nullable: true),
                    MedicinePrescription = table.Column<string>(nullable: true),
                    MedicineType = table.Column<string>(nullable: true),
                    MedicinePiece = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.MedicineId);
                    table.ForeignKey(
                        name: "FK_Medicines_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PetrolStations",
                columns: table => new
                {
                    PetrolId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PetrolFuelType = table.Column<string>(nullable: true),
                    PetrolMarkets = table.Column<string>(nullable: true),
                    PetrolWashing = table.Column<string>(nullable: true),
                    PetrolTire = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetrolStations", x => x.PetrolId);
                    table.ForeignKey(
                        name: "FK_PetrolStations_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ssn",
                columns: table => new
                {
                    SsnId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ssn", x => x.SsnId);
                    table.ForeignKey(
                        name: "FK_Ssn_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ssn_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReservationTime = table.Column<DateTime>(nullable: true),
                    CarParkId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservations_CarParks_CarParkId",
                        column: x => x.CarParkId,
                        principalTable: "CarParks",
                        principalColumn: "CarParkId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    RequestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RequestTime = table.Column<DateTime>(nullable: true),
                    RequestAmaunt = table.Column<string>(nullable: true),
                    RequestActive = table.Column<bool>(nullable: true),
                    MedicineId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.RequestId);
                    table.ForeignKey(
                        name: "FK_Requests_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "MedicineId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sss",
                columns: table => new
                {
                    SssId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SssQuestion = table.Column<string>(nullable: true),
                    SssReply = table.Column<string>(nullable: true),
                    SsnId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sss", x => x.SssId);
                    table.ForeignKey(
                        name: "FK_Sss_Ssn_SsnId",
                        column: x => x.SsnId,
                        principalTable: "Ssn",
                        principalColumn: "SsnId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarParks_CompanyId",
                table: "CarParks",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_CompanyId",
                table: "Medicines",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_PetrolStations_CompanyId",
                table: "PetrolStations",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_MedicineId",
                table: "Requests",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_UserId",
                table: "Requests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CarParkId",
                table: "Reservations",
                column: "CarParkId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ssn_CompanyId",
                table: "Ssn",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Ssn_UserId",
                table: "Ssn",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sss_SsnId",
                table: "Sss",
                column: "SsnId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PetrolStations");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Sss");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "CarParks");

            migrationBuilder.DropTable(
                name: "Ssn");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
