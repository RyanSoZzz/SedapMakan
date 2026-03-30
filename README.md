## Sedap Makan

SedapMakan is a restaurant management system that mainly developed using the **.NET Framework**, with **SQL Server** as its database backend.

The system supports multiple roles, including **Customer, Chef, Manager, and Admin**. It is designed to streamline restaurant operations by handling key functionalities such as menu browsing, ordering, kitchen processes, refunds, feedback, e-wallet transactions, reporting, and account management.

This project was developed in collaboration with three team members: Realdo, Ekin, and Andrian.

I am Ryan, responsible for developing the login system and designing the layout template for all roles. My main contribution was building the customer-side functionalities.

The following is the demo video of the system: https://youtu.be/JiAK2fLBiXQ

## Features

### Customer

- Sign up and log in  
- Browse menu items  
- Sort menu items by name, price, category, and preparation time  
- View menu item details  
- Place and manage orders  
- View current orders  
- View order history  
- Submit feedback
- View feedback status
- Request refunds  
- Access wallet and top-up functionalities  
- Manage profile/settings

### Chef
- View incoming orders
- Filter orders by today
- View order details
- Monitor order-related workflow
- View top-selling items today
- View top-selling items overall
- Access food/menu-related forms
- Manage profile/settings

### Manager
- Review customer feedback
- Handle top-up related processes
- Handle refund requests
- View restaurant statistics
- Manage profile/settings

### Admin
- Access dashboard
- Manage users
- View chef reports
- View customer reports
- Manage money-related data
- Access profile/settings

## Tech Stack
- Language: C#
- Framework: Windows Forms / .NET Framework 4.7.2
- Database: SQL Server
- Database Access: ADO.NET / System.Data.SqlClient
- IDE: Visual Studio

## Database Setup
- Initialize SQL Server Management Studio
- Open file named "database-setup.sql" and execute it
- Update the connection string in DatabaseHelper.cs to match your SQL Server instance
- Open the solution in Visual Studio and run the app

## Disclaimer
- The current database connection is machine-specific and may need to be changed before running on another computer.
- This project is used for learning, demonstration, and portfolio purposes **ONLY**.
