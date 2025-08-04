# Product Inventory Manager (WinForms Desktop App)

A desktop application built in C# using WinForms to manage a simple product inventory.  
The app allows users to add, view, and search products — all using an in-memory data store (no database).

---

## Features

- Add new products (name, unit price, quantity, description)
- View product list in a DataGridView
- Search products by name with case-insensitive filtering
- Clean separation of concerns using:
  - Models
  - Repositories
  - Service layer
  - UI layer

---

## Technical Highlights

- Built with **C# and WinForms**
- Applies **OOP** and **SOLID** principles
- Uses the **Repository Pattern** to abstract data access
- In-memory product storage (List<Product>) for simplicity and testability
- Designed for **maintainability** and **extensibility**

---

## Folder Structure

/Models → Product class
/Interfaces → IProductRepository
/Repositories → InMemoryProductRepository
/Services → ProductService
/UI → Form1.cs (UI logic)

## Screenshot

<img width="1015" height="567" alt="image" src="https://github.com/user-attachments/assets/00dd56cd-d65d-4a53-af19-388f251acb64" />


## Purpose

This project was built as part of a technical task for a Software Engineer role.  
The goal was to demonstrate clean coding, architectural thinking, and practical problem-solving using WinForms.
