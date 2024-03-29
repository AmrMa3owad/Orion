using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Orion.Migrations
{
    /// <inheritdoc />
    public partial class OrionStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.CreateTable(
                name: "Advertisements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    AdvertisementType = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Crafts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CraftName = table.Column<string>(type: "text", nullable: false),
                    CraftItem = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crafts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Donations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DonationType = table.Column<int>(type: "integer", nullable: false),
                    DonationQuantity = table.Column<double>(type: "double precision", nullable: false),
                    DonationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DonationMethod = table.Column<string>(type: "text", nullable: false),
                    CustomerId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    EventDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EventTitle = table.Column<string>(type: "text", nullable: false),
                    EventPlace = table.Column<string>(type: "text", nullable: false),
                    BoothId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    MaterialType = table.Column<string>(type: "text", nullable: false),
                    MaterialPrice = table.Column<int>(type: "integer", nullable: false),
                    MaterialQuantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orphanages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    OrphanageName = table.Column<string>(type: "text", nullable: false),
                    OrphanageNumber = table.Column<int>(type: "integer", nullable: false),
                    OrphanageAddress = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orphanages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    PaymentAmount = table.Column<int>(type: "integer", nullable: false),
                    PaymentMethod = table.Column<string>(type: "text", nullable: false),
                    CustomerId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PreCommunities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreCommunities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    VendorName = table.Column<string>(type: "text", nullable: false),
                    VendorAddress = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Booths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    BoothNumber = table.Column<int>(type: "integer", nullable: false),
                    BoothCapacity = table.Column<int>(type: "integer", nullable: false),
                    EventId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booths_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sponsors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    SponsorName = table.Column<string>(type: "text", nullable: false),
                    SponsorEmail = table.Column<string>(type: "text", nullable: false),
                    SponsorPhone = table.Column<int>(type: "integer", nullable: false),
                    SponsorAddress = table.Column<string>(type: "text", nullable: false),
                    BusinessType = table.Column<string>(type: "text", nullable: false),
                    DonationId = table.Column<int>(type: "integer", nullable: false),
                    EventId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sponsors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sponsors_Donations_DonationId",
                        column: x => x.DonationId,
                        principalTable: "Donations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sponsors_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialVendors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    MaterialId = table.Column<int>(type: "integer", nullable: false),
                    VendorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialVendors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaterialVendors_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialVendors_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SponsorAdvertisements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    SponsorId = table.Column<int>(type: "integer", nullable: false),
                    AdvertisementId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SponsorAdvertisements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SponsorAdvertisements_Advertisements_AdvertisementId",
                        column: x => x.AdvertisementId,
                        principalTable: "Advertisements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SponsorAdvertisements_Sponsors_SponsorId",
                        column: x => x.SponsorId,
                        principalTable: "Sponsors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAdvertisements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    AdvertisementId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAdvertisements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerAdvertisements_Advertisements_AdvertisementId",
                        column: x => x.AdvertisementId,
                        principalTable: "Advertisements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerEvent",
                columns: table => new
                {
                    CustomersId = table.Column<int>(type: "integer", nullable: false),
                    EventsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerEvent", x => new { x.CustomersId, x.EventsId });
                    table.ForeignKey(
                        name: "FK_CustomerEvent_Events_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DeviceType = table.Column<string>(type: "text", nullable: false),
                    DeviceDateOfPurchase = table.Column<string>(type: "text", nullable: false),
                    MaintenanceDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MaintenancePrice = table.Column<int>(type: "integer", nullable: false),
                    AdminId = table.Column<int>(type: "integer", nullable: false),
                    OfficeWorkerId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    AdminId = table.Column<int>(type: "integer", nullable: false),
                    OfficeWorkerId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    OrderPrice = table.Column<int>(type: "integer", nullable: false),
                    OrderQuantity = table.Column<int>(type: "integer", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    OrderAmount = table.Column<int>(type: "integer", nullable: false),
                    OrderComments = table.Column<string>(type: "text", nullable: false),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    Discriminator = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    BoothId = table.Column<int>(type: "integer", nullable: true),
                    ShippingFees = table.Column<double>(type: "double precision", nullable: true),
                    DeliveryId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Booths_BoothId",
                        column: x => x.BoothId,
                        principalTable: "Booths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ProductName = table.Column<string>(type: "text", nullable: false),
                    ProductImage = table.Column<string>(type: "text", nullable: false),
                    ProductColor = table.Column<string>(type: "text", nullable: false),
                    ProductNumber = table.Column<int>(type: "integer", nullable: false),
                    ProductType = table.Column<string>(type: "text", nullable: false),
                    ProductSize = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ProductPrice = table.Column<int>(type: "integer", nullable: false),
                    Reviews = table.Column<string>(type: "text", nullable: false),
                    Customization = table.Column<string>(type: "text", nullable: false),
                    SupervisorId = table.Column<int>(type: "integer", nullable: false),
                    EventId = table.Column<int>(type: "integer", nullable: false),
                    Above12Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Discriminator = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    DonationId = table.Column<int>(type: "integer", nullable: true),
                    PaymentId = table.Column<int>(type: "integer", nullable: true),
                    OrderId = table.Column<int>(type: "integer", nullable: true),
                    Customer_WebsiteId = table.Column<int>(type: "integer", nullable: true),
                    EmployeePension = table.Column<string>(type: "text", nullable: true),
                    EmployeeInsurance = table.Column<int>(type: "integer", nullable: true),
                    EmployeeRole = table.Column<string>(type: "text", nullable: true),
                    EmployeeSalary = table.Column<int>(type: "integer", nullable: true),
                    EmployeeDateOfJoin = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EmployeeStatus = table.Column<string>(type: "text", nullable: true),
                    EmployeeQualifications = table.Column<string>(type: "text", nullable: true),
                    WebsiteId = table.Column<int>(type: "integer", nullable: true),
                    DeviceId = table.Column<int>(type: "integer", nullable: true),
                    DeliveryShift = table.Column<string>(type: "text", nullable: true),
                    VechileNumber = table.Column<int>(type: "integer", nullable: true),
                    DeliveryLicense = table.Column<string>(type: "text", nullable: true),
                    OfficeWorkerDepartment = table.Column<string>(type: "text", nullable: true),
                    OfficeWorker_DeviceId = table.Column<int>(type: "integer", nullable: true),
                    Earnings = table.Column<int>(type: "integer", nullable: true),
                    OrphansNumber = table.Column<int>(type: "integer", nullable: true),
                    ProductType = table.Column<string>(type: "text", nullable: true),
                    OrphanageId = table.Column<int>(type: "integer", nullable: true),
                    SupervisorId = table.Column<int>(type: "integer", nullable: true),
                    MentorArea = table.Column<string>(type: "text", nullable: true),
                    OrphanNumber = table.Column<int>(type: "integer", nullable: true),
                    VisitNumber = table.Column<int>(type: "integer", nullable: true),
                    CraftId = table.Column<int>(type: "integer", nullable: true),
                    Fees = table.Column<int>(type: "integer", nullable: true),
                    PreCommunityId = table.Column<int>(type: "integer", nullable: true),
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
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Crafts_CraftId",
                        column: x => x.CraftId,
                        principalTable: "Crafts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Donations_DonationId",
                        column: x => x.DonationId,
                        principalTable: "Donations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Orphanages_OrphanageId",
                        column: x => x.OrphanageId,
                        principalTable: "Orphanages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_PreCommunities_PreCommunityId",
                        column: x => x.PreCommunityId,
                        principalTable: "PreCommunities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Users_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Websites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    WebsiteName = table.Column<string>(type: "text", nullable: false),
                    AdminId = table.Column<int>(type: "integer", nullable: false),
                    OfficeWorkerId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Websites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Websites_Users_OfficeWorkerId",
                        column: x => x.OfficeWorkerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booths_EventId",
                table: "Booths",
                column: "EventId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAdvertisements_AdvertisementId",
                table: "CustomerAdvertisements",
                column: "AdvertisementId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAdvertisements_CustomerId",
                table: "CustomerAdvertisements",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerEvent_EventsId",
                table: "CustomerEvent",
                column: "EventsId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProducts_CustomerId",
                table: "CustomerProducts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProducts_ProductId",
                table: "CustomerProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_AdminId",
                table: "Devices",
                column: "AdminId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Devices_OfficeWorkerId",
                table: "Devices",
                column: "OfficeWorkerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_AdminId",
                table: "Feedbacks",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_CustomerId",
                table: "Feedbacks",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_OfficeWorkerId",
                table: "Feedbacks",
                column: "OfficeWorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialVendors_MaterialId",
                table: "MaterialVendors",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialVendors_VendorId",
                table: "MaterialVendors",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BoothId",
                table: "Orders",
                column: "BoothId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DeliveryId",
                table: "Orders",
                column: "DeliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Above12Id",
                table: "Products",
                column: "Above12Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_EventId",
                table: "Products",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupervisorId",
                table: "Products",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_SponsorAdvertisements_AdvertisementId",
                table: "SponsorAdvertisements",
                column: "AdvertisementId");

            migrationBuilder.CreateIndex(
                name: "IX_SponsorAdvertisements_SponsorId",
                table: "SponsorAdvertisements",
                column: "SponsorId");

            migrationBuilder.CreateIndex(
                name: "IX_Sponsors_DonationId",
                table: "Sponsors",
                column: "DonationId");

            migrationBuilder.CreateIndex(
                name: "IX_Sponsors_EventId",
                table: "Sponsors",
                column: "EventId");

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
                name: "IX_Users_PreCommunityId",
                table: "Users",
                column: "PreCommunityId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SupervisorId",
                table: "Users",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_WebsiteId",
                table: "Users",
                column: "WebsiteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Websites_OfficeWorkerId",
                table: "Websites",
                column: "OfficeWorkerId");

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
                name: "FK_CustomerProducts_Products_ProductId",
                table: "CustomerProducts",
                column: "ProductId",
                principalTable: "Products",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Websites_Users_OfficeWorkerId",
                table: "Websites");

            migrationBuilder.DropTable(
                name: "CustomerAdvertisements");

            migrationBuilder.DropTable(
                name: "CustomerEvent");

            migrationBuilder.DropTable(
                name: "CustomerProducts");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "MaterialVendors");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "SponsorAdvertisements");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropTable(
                name: "Booths");

            migrationBuilder.DropTable(
                name: "Advertisements");

            migrationBuilder.DropTable(
                name: "Sponsors");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Crafts");

            migrationBuilder.DropTable(
                name: "Donations");

            migrationBuilder.DropTable(
                name: "Orphanages");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "PreCommunities");

            migrationBuilder.DropTable(
                name: "Websites");

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                });
        }
    }
}
