using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Orion.Migrations
{
    /// <inheritdoc />
    public partial class OrionUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Employees_AdminId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Employees_OfficeWorkerId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Websites_WebsiteId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Employees_AdminId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Employees_OfficeWorkerId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Freelancers_Employees_SupervisorId",
                table: "Freelancers");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Booths_BoothId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Employees_DeliveryId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Employees_SupervisorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Freelancers_Above12Id",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Websites_Employees_OfficeWorkerId",
                table: "Websites");

            migrationBuilder.DropIndex(
                name: "IX_Orders_BoothId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_DeliveryId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Freelancers_SupervisorId",
                table: "Freelancers");

            migrationBuilder.DropIndex(
                name: "IX_Employees_WebsiteId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "BoothId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeliveryId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShippingFees",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "SupervisorId",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "DeliveryLicense",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DeliveryShift",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DeviceId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "OfficeWorkerDepartment",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "OfficeWorker_DeviceId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "VechileNumber",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "WebsiteId",
                table: "Employees");

            migrationBuilder.CreateTable(
                name: "Above12s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Earnings = table.Column<int>(type: "integer", nullable: false),
                    OrphansNumber = table.Column<int>(type: "integer", nullable: false),
                    ProductType = table.Column<string>(type: "text", nullable: false),
                    OrphanageId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Above12s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Above12s_Orphanages_OrphanageId",
                        column: x => x.OrphanageId,
                        principalTable: "Orphanages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    WebsiteId = table.Column<int>(type: "integer", nullable: false),
                    DeviceId = table.Column<int>(type: "integer", nullable: false),
                    EmployeePension = table.Column<string>(type: "text", nullable: false),
                    EmployeeInsurance = table.Column<int>(type: "integer", nullable: false),
                    EmployeeRole = table.Column<string>(type: "text", nullable: false),
                    EmployeeSalary = table.Column<int>(type: "integer", nullable: false),
                    EmployeeDateOfJoin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EmployeeStatus = table.Column<string>(type: "text", nullable: false),
                    EmployeeQualifications = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admins_Websites_WebsiteId",
                        column: x => x.WebsiteId,
                        principalTable: "Websites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BoothOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    BoothId = table.Column<int>(type: "integer", nullable: false),
                    OrderPrice = table.Column<int>(type: "integer", nullable: false),
                    OrderQuantity = table.Column<int>(type: "integer", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    OrderAmount = table.Column<int>(type: "integer", nullable: false),
                    OrderComments = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoothOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoothOrders_Booths_BoothId",
                        column: x => x.BoothId,
                        principalTable: "Booths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    EmployeePension = table.Column<string>(type: "text", nullable: false),
                    EmployeeInsurance = table.Column<int>(type: "integer", nullable: false),
                    EmployeeRole = table.Column<string>(type: "text", nullable: false),
                    EmployeeSalary = table.Column<int>(type: "integer", nullable: false),
                    EmployeeDateOfJoin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EmployeeStatus = table.Column<string>(type: "text", nullable: false),
                    EmployeeQualifications = table.Column<string>(type: "text", nullable: false),
                    DeliveryShift = table.Column<string>(type: "text", nullable: false),
                    VechileNumber = table.Column<int>(type: "integer", nullable: false),
                    DeliveryLicense = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfficeWorkers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    OfficeWorkerDepartment = table.Column<string>(type: "text", nullable: false),
                    DeviceId = table.Column<int>(type: "integer", nullable: false),
                    EmployeePension = table.Column<string>(type: "text", nullable: false),
                    EmployeeInsurance = table.Column<int>(type: "integer", nullable: false),
                    EmployeeRole = table.Column<string>(type: "text", nullable: false),
                    EmployeeSalary = table.Column<int>(type: "integer", nullable: false),
                    EmployeeDateOfJoin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EmployeeStatus = table.Column<string>(type: "text", nullable: false),
                    EmployeeQualifications = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeWorkers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supervisors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    EmployeePension = table.Column<string>(type: "text", nullable: false),
                    EmployeeInsurance = table.Column<int>(type: "integer", nullable: false),
                    EmployeeRole = table.Column<string>(type: "text", nullable: false),
                    EmployeeSalary = table.Column<int>(type: "integer", nullable: false),
                    EmployeeDateOfJoin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EmployeeStatus = table.Column<string>(type: "text", nullable: false),
                    EmployeeQualifications = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supervisors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ShippingFees = table.Column<double>(type: "double precision", nullable: false),
                    DeliveryId = table.Column<int>(type: "integer", nullable: false),
                    OrderPrice = table.Column<int>(type: "integer", nullable: false),
                    OrderQuantity = table.Column<int>(type: "integer", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    OrderAmount = table.Column<int>(type: "integer", nullable: false),
                    OrderComments = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeliveryOrders_Deliveries_DeliveryId",
                        column: x => x.DeliveryId,
                        principalTable: "Deliveries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Under12s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Earnings = table.Column<int>(type: "integer", nullable: false),
                    OrphansNumber = table.Column<int>(type: "integer", nullable: false),
                    ProductType = table.Column<string>(type: "text", nullable: false),
                    SupervisorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Under12s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Under12s_Supervisors_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Supervisors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Above12s_OrphanageId",
                table: "Above12s",
                column: "OrphanageId");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_WebsiteId",
                table: "Admins",
                column: "WebsiteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BoothOrders_BoothId",
                table: "BoothOrders",
                column: "BoothId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryOrders_DeliveryId",
                table: "DeliveryOrders",
                column: "DeliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_Under12s_SupervisorId",
                table: "Under12s",
                column: "SupervisorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Admins_AdminId",
                table: "Devices",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_OfficeWorkers_OfficeWorkerId",
                table: "Devices",
                column: "OfficeWorkerId",
                principalTable: "OfficeWorkers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Admins_AdminId",
                table: "Feedbacks",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_OfficeWorkers_OfficeWorkerId",
                table: "Feedbacks",
                column: "OfficeWorkerId",
                principalTable: "OfficeWorkers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Above12s_Above12Id",
                table: "Products",
                column: "Above12Id",
                principalTable: "Above12s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Supervisors_SupervisorId",
                table: "Products",
                column: "SupervisorId",
                principalTable: "Supervisors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Websites_OfficeWorkers_OfficeWorkerId",
                table: "Websites",
                column: "OfficeWorkerId",
                principalTable: "OfficeWorkers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Admins_AdminId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Devices_OfficeWorkers_OfficeWorkerId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Admins_AdminId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_OfficeWorkers_OfficeWorkerId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Above12s_Above12Id",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Supervisors_SupervisorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Websites_OfficeWorkers_OfficeWorkerId",
                table: "Websites");

            migrationBuilder.DropTable(
                name: "Above12s");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "BoothOrders");

            migrationBuilder.DropTable(
                name: "DeliveryOrders");

            migrationBuilder.DropTable(
                name: "OfficeWorkers");

            migrationBuilder.DropTable(
                name: "Under12s");

            migrationBuilder.DropTable(
                name: "Deliveries");

            migrationBuilder.DropTable(
                name: "Supervisors");

            migrationBuilder.AddColumn<int>(
                name: "BoothId",
                table: "Orders",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryId",
                table: "Orders",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Orders",
                type: "character varying(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "ShippingFees",
                table: "Orders",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Freelancers",
                type: "character varying(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SupervisorId",
                table: "Freelancers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryLicense",
                table: "Employees",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryShift",
                table: "Employees",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeviceId",
                table: "Employees",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Employees",
                type: "character varying(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OfficeWorkerDepartment",
                table: "Employees",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OfficeWorker_DeviceId",
                table: "Employees",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VechileNumber",
                table: "Employees",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WebsiteId",
                table: "Employees",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BoothId",
                table: "Orders",
                column: "BoothId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DeliveryId",
                table: "Orders",
                column: "DeliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_Freelancers_SupervisorId",
                table: "Freelancers",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_WebsiteId",
                table: "Employees",
                column: "WebsiteId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Employees_AdminId",
                table: "Devices",
                column: "AdminId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Employees_OfficeWorkerId",
                table: "Devices",
                column: "OfficeWorkerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Websites_WebsiteId",
                table: "Employees",
                column: "WebsiteId",
                principalTable: "Websites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Employees_AdminId",
                table: "Feedbacks",
                column: "AdminId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Employees_OfficeWorkerId",
                table: "Feedbacks",
                column: "OfficeWorkerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Freelancers_Employees_SupervisorId",
                table: "Freelancers",
                column: "SupervisorId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Booths_BoothId",
                table: "Orders",
                column: "BoothId",
                principalTable: "Booths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Employees_DeliveryId",
                table: "Orders",
                column: "DeliveryId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Employees_SupervisorId",
                table: "Products",
                column: "SupervisorId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Freelancers_Above12Id",
                table: "Products",
                column: "Above12Id",
                principalTable: "Freelancers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Websites_Employees_OfficeWorkerId",
                table: "Websites",
                column: "OfficeWorkerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
