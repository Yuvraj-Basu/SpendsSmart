# SpendSmart — Personal Expense Tracker

SpendSmart is a simple web app I built to practice ASP.NET Core MVC. It lets you log your daily expenses, keep track of what you've spent, and edit or delete entries as needed. Nothing fancy — just a clean, working CRUD app with a running total.

---

## What it does

- Add an expense with a description, amount, and date
- Edit or delete any existing entry
- See a summary of your total spend on the main page
- Validation on all inputs so nothing breaks if a field is left empty

---

## Tech used

- C# and ASP.NET Core 10 MVC
- Entity Framework Core with an in-memory database
- Bootstrap 5 for the UI
- Toastr for success and error notifications

No database installation needed — just clone and run.

---

## How to run it

You'll need the [.NET 10 SDK](https://dotnet.microsoft.com/download) installed.

```bash
git clone https://github.com/yourusername/SpendSmart.git
cd SpendSmart
dotnet run
```

Then open `https://localhost:5001` in your browser.

One thing to note — because it uses an in-memory database, data resets when you stop the app. That was a deliberate choice to keep the project simple and easy to run without any setup.

---

## Project structure

```
SpendSmart/
├── Controllers/
│   └── ExpenseController.cs       # All CRUD logic lives here
├── Models/
│   └── Expense.cs                 # Expense model with validation attributes
├── Views/
│   └── Expense/
│       ├── Index.cshtml           # Main list + total summary
│       ├── Create.cshtml          # Add a new expense
│       └── Edit.cshtml            # Edit an existing expense
├── Data/
│   └── AppDbContext.cs            # EF Core in-memory context
└── Program.cs                     # App setup and configuration
```

---

## Screenshots

> Coming soon — will add once hosted.

---

## What I'd build next

This was mainly a learning project, but if I were to take it further I'd add a proper SQL Server database, expense categories, date filtering, and eventually a simple chart showing monthly spend. User authentication would be the step after that.

---

## Author

**Yuvraj Basu**  
BSc IT — University of Mumbai  
[LinkedIn](#) · [GitHub](#)
