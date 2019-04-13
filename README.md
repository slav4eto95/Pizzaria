# Pizzaria
Created as university project (the whole content of the project is written in Cyrillic)

It simply uses a Pizzaria database which is already filled with information (the project just uses the database, it doesn't create or insert values in the database).  
The database can be created using PizzariaModel.edmx file. When it is opened, right-click on any blank space and then choose Generate Database from Model... This will display Generate Database Wizard in which you can change the name of the sql file and to see the generated sql script.  
After running the script file (for example in MS SQL Server), you can insert as many data as you want in the database.  
  
The project contains a few reports about the made orders, the clients and the products in the pizzaria.  
- Top 10 sold products for a given period
- Top 10 products with max sum of orders
- Clients without orders in a given period
- Clients with sum of orders bigger than given sum in a given period
- All ordered products for a given client
- All orders with sum bigger than given sum
- Detailed information about every made order
