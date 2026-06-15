Defining project requirements and objectives:
The goal of this project is to develop a simple console-based inventory management system that allows users to efficiently manage their product stock.
The system should provide an intuitive interface for users to add, update, view and remove (CRUD) products from the inventory.
Project name Inventory management system:
 Functional Requirements (What the system should do):
Add New Products:
User can add products with the following details:
Product Name.
Product Price.
Stock Quantity.


Update Stocks Levels:
User can increase stock when restocking products.
User can decrease stock when products are sold.

View Products:
User can list all available products, showing:
Product Name
Product Price
Stock Quantity


Remove Products:
User can delete a product from the inventory when it is no longer available.

Error Handling:
Prevent invalid inputs (negative stock levels, empty product names).
Notify user when attempting to update or remove a non-existing product.


 Non-Functional Requirements (How the system should perform):
 Usability:
 The system should be easy to use with clear prompts and instructions.
 Provide meaningful error messages and confirmations.

 Performance:
 The system should respond quickly to user input. 

 Scalability:
 The system should allow for an increasing number of products without performance degradation.

 Reliability:
 Ensure data consistency when updating stock levels.
 Prevent accidental data loss or incorrect product modifications.

 Maintainability:
 The code should be well-structured, easy to read, and documented for future improvements.



Flowchart:
 I'll generate a flowchart that represents the main interactions of the system.  
 Process Flow: 
Start
Display Main Menu
User selects an action:
Add Product -> Enter product details -> Save to inventory
Update Stock -> Choose product ->  Increase / Decrease stock
View Products -> Display all products
Remove Product -> Choose product -> Delete from inventory

Return to main menu or exist.


Task Breakdown & Code Components:
Project setup:
Create a new C# Console Application. 
Setup a Product class to store product details.

Main menu display:
Use a while loop to show the menu options.
Read user input and call the appropriate function.

Adding a Product:
Prompt the user for name, price and stock quantity.
Store the product in a list or a dictionary.

Updating Stock:
Search for a product by name or ID.
Increase or decrease stock based on user input.

Viewing Products:
Loop through the product list and display details.

Removing a Product:
Search for a product by name or ID.
Remove it from the list.

Error Handling:
Prevent invalid inputs (e.g., negative stock values, empty product names).
Handle cases where the product doesn’t exist.
