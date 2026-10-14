# Orion

Orion is a full-stack ASP.NET Core marketplace and community platform designed to support orphaned youth by turning handmade creativity into sustainable income. The project combines e-commerce, social impact, and mentoring features into one platform that helps young artisans showcase skills, sell handcrafted products, and receive support from donors and customers.

## Why this project stands out

- Social-impact mission: supports orphanages and empowers children through creative entrepreneurship
- Full-stack web app: Razor Pages, EF Core, ASP.NET Core Identity, and PostgreSQL
- E-commerce workflow: product browsing, cart, order flow, and donations
- Admin and supervisor dashboards: manage products, materials, orphanages, and profiles
- Portfolio-ready implementation: demonstrates real-world business logic and clean layered architecture

## Core features

- Handmade product catalog with category and search filters
- Raw material marketplace and product details pages
- Shopping cart and purchase flow
- Freelancer / artisan profiles with skills and photos
- Donor and sponsorship experience
- Admin and supervisor management dashboards
- Authentication and user roles with ASP.NET Identity
- Email notifications using SendGrid

## Tech stack

- ASP.NET Core 8
- Razor Pages
- C#
- Entity Framework Core
- PostgreSQL
- ASP.NET Core Identity
- AutoMapper
- SendGrid
- HTML, CSS, JavaScript

## Project structure

- Orion: ASP.NET Core web app and UI
- Orion.Application: application-layer services and DTOs
- Orion.Domain: business entities and domain models
- Orion.Infrastructure: service implementations and infrastructure concerns
- Orion.Context: EF Core DbContext and migrations
- Orion.Shared: shared project resources

## Getting started

### Prerequisites

- .NET 8 SDK
- PostgreSQL database
- IDE such as Visual Studio or VS Code

### Setup

1. Clone the repository
   ```bash
   git clone https://github.com/AmrMa3owad/Orion.git
   cd Orion
   ```

2. Restore packages
   ```bash
   dotnet restore
   ```

3. Configure the database connection string in `Orion/appsettings.json` (or environment variables)

4. Apply migrations
   ```bash
   dotnet ef database update --project Orion.Context --startup-project Orion
   ```

5. Run the app
   ```bash
   dotnet run --project Orion
   ```

## Portfolio notes

This is a strong portfolio project because it combines technical depth with a meaningful real-world use case:

- layered architecture
- business-domain modeling
- database design and migrations
- user authentication and authorization
- frontend + backend integration
- service-oriented design
- social-impact product thinking

## License

This project is open for learning and portfolio use.
