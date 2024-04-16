# BakeryApp2024

💻 My project for the ASP.NET Core course at SoftUni. (April 2024)

ℹ️ How It Works
Guest users:
browse categories of products;
view products with their descriptions;
read reviews;
see contact page;
Logged Users:
buy products;
change product quantity in the basket;
can review reviews for the bakery or a product;
Bakers (user role):
add products;
edit and delete their own products;
can see their own added products;
Admin:
can see all users;
approve products added by bakers;
add products;
check product statistics;

⚒️ Built With
ASP.NET Core 3.1
Entity Framework (EF) Core 3.1
Microsoft SQL Server Express
ASP.NET Identity System
MVC Areas with Multiple Layouts
Razor Pages, Sections, Partial Views
View Components
Repository Pattern
Dependency Injection
Status Code Pages Middleware
Exception Handling Middleware
Sorting, Filtering, and Paging with EF Core
Data Validation, both Client-side and Server-side
Data Validation in the Models and Input View Models
Custom Validation Attributes
Responsive Design
Bootstrap
jQuery

⚙️ Application Configurations
1. The Connection string
is in secrets.json.

2. Seeding sample data
would happen once you run the application, including Test Accounts:

User: guest@mail.com / password: guest123
Baker: 
baker@mail.com / password: baker123
Admin: admin@mail.com / password: admin123
