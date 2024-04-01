using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orion.Migrations
{
    /// <inheritdoc />
    public partial class Identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "PremiumUsers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "PremiumUsers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "PremiumUsers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "PremiumUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "PremiumUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "PremiumUsers");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "PremiumUsers");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "PremiumUsers");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "PremiumUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "PremiumUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "PremiumUsers");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "PremiumUsers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "PremiumUsers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "PremiumUsers");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Mentors");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Mentors");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Mentors");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Mentors");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Mentors");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Mentors");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Mentors");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Mentors");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Mentors");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Mentors");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Mentors");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Mentors");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Mentors");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Mentors");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Customers");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
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
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "PremiumUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "PremiumUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "PremiumUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "PremiumUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "PremiumUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "PremiumUsers",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "PremiumUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "PremiumUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "PremiumUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "PremiumUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "PremiumUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "PremiumUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "PremiumUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "PremiumUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Mentors",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Mentors",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Mentors",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Mentors",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Mentors",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Mentors",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Mentors",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Mentors",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Mentors",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Mentors",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Mentors",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Mentors",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Mentors",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Mentors",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Freelancers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Freelancers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Freelancers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Freelancers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Freelancers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Freelancers",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Freelancers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Freelancers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Freelancers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Freelancers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Freelancers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Freelancers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Freelancers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Freelancers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Employees",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Employees",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employees",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Employees",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Employees",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Employees",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Employees",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Employees",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Employees",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Employees",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Employees",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Employees",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Employees",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Employees",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Customers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Customers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Customers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Customers",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Customers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Customers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Customers",
                type: "text",
                nullable: true);
        }
    }
}
