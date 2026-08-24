# Mini Inventory System

A console-based inventory management system built with **C# and .NET**.

This project is being developed as a hands-on learning project to practice C# programming, Object-Oriented Programming, LINQ, collections, and real-world inventory business logic.

## Features

- Add Product
- View Products
- Search Product
- Update Product
- Delete Product
- Purchase Management
- Sales Management
- Stock Management
- Transaction History
- Stock Report
- Total Stock Calculation
- Total Inventory Value Calculation
- Insufficient Stock Validation

## Technologies

- C#
- .NET
- LINQ
- Object-Oriented Programming

## Project Structure

```text
MiniInventory/
│
├── Program.cs
├── Product.cs
├── Transaction.cs
├── MiniInventory.csproj
├── README.md
└── .gitignore
```

## How It Works

### Product Management

Products can be added, viewed, searched, updated, and deleted.

Each product contains:

```text
Product
├── Id
├── Name
├── Price
└── Quantity
```

### Purchase

When a purchase is completed, the product stock increases.

```text
Current Stock + Purchase Quantity = New Stock
```

### Sale

When a sale is completed, the product stock decreases.

The system also prevents selling more quantity than the available stock.

```text
Available Stock < Sale Quantity
        ↓
Insufficient Stock
```

### Transaction History

Every successful purchase and sale creates a transaction record containing:

- Product ID
- Product Name
- Transaction Type
- Quantity
- Transaction Date

### Stock Report

The stock report displays:

- Product ID
- Product Name
- Price
- Current Stock
- Total Products
- Total Stock
- Total Inventory Value

## Example

```text
==============================================
              STOCK REPORT
==============================================
ID      Product             Price       Stock
----------------------------------------------
101     Keyboard            1500        12
102     Mouse               800         23
103     Monitor             12000        5
----------------------------------------------
Total Products : 3
Total Stock    : 40
Stock Value    : 45600
```

## How to Run

Make sure the **.NET SDK** is installed.

Clone the repository:

```bash
git clone https://github.com/YOUR_USERNAME/mini-inventory-system.git
```

Navigate to the project directory:

```bash
cd mini-inventory-system
```

Run the application:

```bash
dotnet run
```

## Learning Goals

This project is focused on learning and practicing:

- C# fundamentals
- Classes and Objects
- Object-Oriented Programming
- Collections
- `List<T>`
- `foreach`
- LINQ
- Lambda Expressions
- `FirstOrDefault()`
- `Sum()`
- Nullable Reference Types
- `DateTime`
- Business Logic
- Basic Software Design

## Roadmap

- [x] Create C# Console Application
- [x] Add Product
- [x] View Products
- [x] Search Product
- [x] Update Product
- [x] Delete Product
- [x] Purchase Management
- [x] Sales Management
- [x] Transaction History
- [x] Stock Report
- [ ] Refactor business logic into services
- [ ] Improve input validation
- [ ] Add low-stock alerts
- [ ] Add JSON data persistence
- [ ] Add database support
- [ ] Add Entity Framework Core
- [ ] Convert to ASP.NET Core Web API
- [ ] Build a web-based frontend

## Project Status

🚧 **In Development**

This is an ongoing learning project. The current version is a console-based inventory management application.

The project will gradually evolve from a simple C# CLI application into a structured application with database support and eventually an ASP.NET Core Web API.

## Author

**Mehedi Hasan**