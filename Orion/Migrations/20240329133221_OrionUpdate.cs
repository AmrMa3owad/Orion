using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Orion.Migrations
{
    /// <inheritdoc />
    public partial class OrionUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAdvertisements_Users_CustomerId",
                table: "CustomerAdvertisements");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerEvent_Users_CustomersId",
                table: "CustomerEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerProducts_Users_CustomerId",
                table: "CustomerProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Users_AdminId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Users_OfficeWorkerId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Users_AdminId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Users_CustomerId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Users_OfficeWorkerId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_DeliveryId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Users_Above12Id",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Users_SupervisorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Crafts_CraftId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Donations_DonationId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Orphanages_OrphanageId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Payments_PaymentId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_PreCommunities_PreCommunityId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_SupervisorId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Websites_Customer_WebsiteId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Websites_WebsiteId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Websites_Users_OfficeWorkerId",
                table: "Websites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CraftId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Customer_WebsiteId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_DonationId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_OrphanageId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PaymentId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_SupervisorId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_WebsiteId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CraftId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Customer_WebsiteId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeliveryLicense",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeliveryShift",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeviceId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DonationId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Earnings",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EmployeeDateOfJoin",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EmployeeInsurance",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EmployeePension",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EmployeeQualifications",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EmployeeRole",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EmployeeSalary",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EmployeeStatus",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MentorArea",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OfficeWorkerDepartment",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OfficeWorker_DeviceId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OrphanNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OrphanageId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OrphansNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ProductType",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SupervisorId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "VechileNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "VisitNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "WebsiteId",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "PremiumUsers");

            migrationBuilder.RenameIndex(
                name: "IX_Users_PreCommunityId",
                table: "PremiumUsers",
                newName: "IX_PremiumUsers_PreCommunityId");

            migrationBuilder.AlterColumn<int>(
                name: "PreCommunityId",
                table: "PremiumUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Fees",
                table: "PremiumUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PremiumUsers",
                table: "PremiumUsers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DonationId = table.Column<int>(type: "integer", nullable: false),
                    PaymentId = table.Column<int>(type: "integer", nullable: false),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    WebsiteId = table.Column<int>(type: "integer", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Donations_DonationId",
                        column: x => x.DonationId,
                        principalTable: "Donations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_Websites_WebsiteId",
                        column: x => x.WebsiteId,
                        principalTable: "Websites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
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
                    Discriminator = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    WebsiteId = table.Column<int>(type: "integer", nullable: true),
                    DeviceId = table.Column<int>(type: "integer", nullable: true),
                    DeliveryShift = table.Column<string>(type: "text", nullable: true),
                    VechileNumber = table.Column<int>(type: "integer", nullable: true),
                    DeliveryLicense = table.Column<string>(type: "text", nullable: true),
                    OfficeWorkerDepartment = table.Column<string>(type: "text", nullable: true),
                    OfficeWorker_DeviceId = table.Column<int>(type: "integer", nullable: true),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Websites_WebsiteId",
                        column: x => x.WebsiteId,
                        principalTable: "Websites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mentors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    MentorArea = table.Column<string>(type: "text", nullable: false),
                    OrphanNumber = table.Column<int>(type: "integer", nullable: false),
                    VisitNumber = table.Column<int>(type: "integer", nullable: false),
                    CraftId = table.Column<int>(type: "integer", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mentors_Crafts_CraftId",
                        column: x => x.CraftId,
                        principalTable: "Crafts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Freelancers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Earnings = table.Column<int>(type: "integer", nullable: false),
                    OrphansNumber = table.Column<int>(type: "integer", nullable: false),
                    ProductType = table.Column<string>(type: "text", nullable: false),
                    OrphanageId = table.Column<int>(type: "integer", nullable: false),
                    Discriminator = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    SupervisorId = table.Column<int>(type: "integer", nullable: true),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Freelancers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Freelancers_Employees_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Freelancers_Orphanages_OrphanageId",
                        column: x => x.OrphanageId,
                        principalTable: "Orphanages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_DonationId",
                table: "Customers",
                column: "DonationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PaymentId",
                table: "Customers",
                column: "PaymentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_WebsiteId",
                table: "Customers",
                column: "WebsiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_WebsiteId",
                table: "Employees",
                column: "WebsiteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Freelancers_OrphanageId",
                table: "Freelancers",
                column: "OrphanageId");

            migrationBuilder.CreateIndex(
                name: "IX_Freelancers_SupervisorId",
                table: "Freelancers",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Mentors_CraftId",
                table: "Mentors",
                column: "CraftId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAdvertisements_Customers_CustomerId",
                table: "CustomerAdvertisements",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerEvent_Customers_CustomersId",
                table: "CustomerEvent",
                column: "CustomersId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerProducts_Customers_CustomerId",
                table: "CustomerProducts",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Feedbacks_Customers_CustomerId",
                table: "Feedbacks",
                column: "CustomerId",
                principalTable: "Customers",
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
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
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
                name: "FK_PremiumUsers_PreCommunities_PreCommunityId",
                table: "PremiumUsers",
                column: "PreCommunityId",
                principalTable: "PreCommunities",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAdvertisements_Customers_CustomerId",
                table: "CustomerAdvertisements");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerEvent_Customers_CustomersId",
                table: "CustomerEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerProducts_Customers_CustomerId",
                table: "CustomerProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Employees_AdminId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Employees_OfficeWorkerId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Customers_CustomerId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Employees_AdminId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Employees_OfficeWorkerId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Employees_DeliveryId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_PremiumUsers_PreCommunities_PreCommunityId",
                table: "PremiumUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Employees_SupervisorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Freelancers_Above12Id",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Websites_Employees_OfficeWorkerId",
                table: "Websites");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Freelancers");

            migrationBuilder.DropTable(
                name: "Mentors");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PremiumUsers",
                table: "PremiumUsers");

            migrationBuilder.RenameTable(
                name: "PremiumUsers",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_PremiumUsers_PreCommunityId",
                table: "Users",
                newName: "IX_Users_PreCommunityId");

            migrationBuilder.AlterColumn<int>(
                name: "PreCommunityId",
                table: "Users",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "Fees",
                table: "Users",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CraftId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Customer_WebsiteId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryLicense",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryShift",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeviceId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Users",
                type: "character varying(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DonationId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Earnings",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EmployeeDateOfJoin",
                table: "Users",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeInsurance",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeePension",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeQualifications",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeRole",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeSalary",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeStatus",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MentorArea",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficeWorkerDepartment",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OfficeWorker_DeviceId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrphanNumber",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrphanageId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrphansNumber",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductType",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupervisorId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VechileNumber",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VisitNumber",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WebsiteId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CraftId",
                table: "Users",
                column: "CraftId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Customer_WebsiteId",
                table: "Users",
                column: "Customer_WebsiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DonationId",
                table: "Users",
                column: "DonationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_OrphanageId",
                table: "Users",
                column: "OrphanageId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PaymentId",
                table: "Users",
                column: "PaymentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_SupervisorId",
                table: "Users",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_WebsiteId",
                table: "Users",
                column: "WebsiteId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAdvertisements_Users_CustomerId",
                table: "CustomerAdvertisements",
                column: "CustomerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerEvent_Users_CustomersId",
                table: "CustomerEvent",
                column: "CustomersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerProducts_Users_CustomerId",
                table: "CustomerProducts",
                column: "CustomerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Users_AdminId",
                table: "Devices",
                column: "AdminId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Users_OfficeWorkerId",
                table: "Devices",
                column: "OfficeWorkerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Users_AdminId",
                table: "Feedbacks",
                column: "AdminId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Users_CustomerId",
                table: "Feedbacks",
                column: "CustomerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Users_OfficeWorkerId",
                table: "Feedbacks",
                column: "OfficeWorkerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_DeliveryId",
                table: "Orders",
                column: "DeliveryId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Users_Above12Id",
                table: "Products",
                column: "Above12Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Users_SupervisorId",
                table: "Products",
                column: "SupervisorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Crafts_CraftId",
                table: "Users",
                column: "CraftId",
                principalTable: "Crafts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Donations_DonationId",
                table: "Users",
                column: "DonationId",
                principalTable: "Donations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Orphanages_OrphanageId",
                table: "Users",
                column: "OrphanageId",
                principalTable: "Orphanages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Payments_PaymentId",
                table: "Users",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_PreCommunities_PreCommunityId",
                table: "Users",
                column: "PreCommunityId",
                principalTable: "PreCommunities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_SupervisorId",
                table: "Users",
                column: "SupervisorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Websites_Customer_WebsiteId",
                table: "Users",
                column: "Customer_WebsiteId",
                principalTable: "Websites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Websites_WebsiteId",
                table: "Users",
                column: "WebsiteId",
                principalTable: "Websites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Websites_Users_OfficeWorkerId",
                table: "Websites",
                column: "OfficeWorkerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
