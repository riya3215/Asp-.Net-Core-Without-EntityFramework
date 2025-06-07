# 🔐 ASP.NET Core Login Page using Repository Pattern (Without Entity Framework)

This project is created to demonstrate a **basic but well-structured login system** in ASP.NET Core using the **Repository Pattern**, without using Entity Framework or any database.  
The user data is stored locally in a text file, making it easy to understand for beginners and scalable for future upgrades.

---

## 📌 My Goal

I wanted to build the **best understandable format of an ASP.NET Core project** from basic to advanced level that:
- Uses a **clean architecture**
- Follows the **repository-service pattern**
- Does **not use Entity Framework**
- Implements a **login page using local flat file storage**

---

## 🧱 Project Structure

Apptest1/
│
├── Controllers/ → Handles HTTP requests
├── Models/ → Data models (User, LoginModel)
├── Repositories/ → Interface and file-based implementation
├── Services/ → Authentication logic
├── Views/ → Razor views for login
├── Data/ → Local user file (users.txt)
├── Program.cs
├── Startup.cs
└── appsettings.json


## 🔄 How Login Works

1. The user enters credentials on the login page.
2. The controller sends these credentials to the `AuthService`.
3. The service uses a repository to read from `users.txt`.
4. If a match is found, the user is redirected to the home page.

> All logic is **decoupled and organized** using interfaces and services for clarity.

## 🛠 Technologies Used

- ASP.NET Core MVC (.NET 6 / 7)
- Razor Pages
- Repository-Service Pattern

It Is Dumy Login Page for Test

