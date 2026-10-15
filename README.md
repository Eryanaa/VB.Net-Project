# VB.Net-Project
Clothing Store’s Remote Ordering Management System

What the project does:
This is a desktop application that helps a physical clothing store record orders from customers who order remotely. Staff operate the system on the customers’ behalf. The system starts with a splash screen and then opens a dashboard with a summary of sales and orders. From the dashboard, staff can place a new order, view the order history, open the About page, or exit.

To place an order, staff enter the customer’s details, select products with their size and quantity, and choose any extra services: premium packaging (RM5) or express delivery (RM10, with an address). They can also apply a promo code. The system calculates the total, discount and final payment automatically. Orders of RM100 and above get 10% off, and orders of RM250 and above get 30% off. Confirmation popups let staff check each step before the order is finalized. The order is then saved to the database, and a receipt is shown and saved as a text file through the File Explorer.

In the order history, staff can filter orders by status, search by order ID or customer name, cancel an order, and reset the list.

Technologies used:
VB.NET (Windows Forms): the programming language and the interface (forms, buttons, DataGridView, PictureBox).
Visual Studio: the development environment used to design, code and run the project.
MySQL: stores the orders (an orders table and an order_items table).
phpMyAdmin (via XAMPP): used to create and manage the MySQL database.
MySql.Data (NuGet package): connects the VB.NET program to MySQL.

How to run it:
1. Install Visual Studio with the “.NET desktop development” workload, and install XAMPP.
2. Open the XAMPP Control Panel and start Apache and MySQL.
3. Open phpMyAdmin (http://localhost/phpmyadmin), create the database, and import the provided .sql file to create the tables.
4. Open the project’s .sln file in Visual Studio.
5. Install the MySql.Data package through NuGet if it is missing (Tools > NuGet Package Manager).
6. Check that the connection string matches your own MySQL server, database name, username and password.
7. Press F5 or click Start. The splash screen appears first, then the dashboard.
