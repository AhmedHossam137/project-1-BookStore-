BookStore API
The BookStore API is a RESTful service designed to manage an online bookstore's operations, including book inventory, customer orders, and author information. This API serves as the backend for online bookstores, providing essential endpoints for both administrative and customer-facing functionalities.

Features
Book Management: Add, update, retrieve, and delete books.
Author Profiles: Manage author information and link books to authors.
Customer Orders: Create and track customer orders.
Authentication & Authorization:
JWT-based authentication.
Role-based access control (RBAC) for admins and customers.



API Endpoints

Books
GET /books: Retrieve all books.
GET /books/{id}: Retrieve details of a specific book.
POST /books: Add a new book (admin only).
PUT /books/{id}: Update a book's details (admin only).
DELETE /books/{id}: Delete a book (admin only).


Authors
GET /authors: Retrieve all authors.
GET /authors/{id}: Retrieve details of a specific author.
POST /authors: Add a new author (admin only).
PUT /authors/{id}: Update author details (admin only).
DELETE /authors/{id}: Delete an author (admin only).

Orders
POST /orders: Create a new customer order.
GET /orders/{id}: Retrieve order details.
PUT /orders/{id}: Update order status (admin only).



Technical Details
Data Format: JSON for both requests and responses.
Error Handling: Comprehensive error handling with meaningful HTTP status codes and error messages.
Database: SQLServer for structured data storage
