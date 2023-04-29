# 📚Bibliotech
A database-linked library management application.

## Features

- Search for a book using the book's title, author name, or ISBN.
- Borrow or return a book, which updates the book's availability status in the database.
- Log into a Cardholder account to see which books have been borrowed on that account.
- Log into a Staff account to search for a Cardholder account.

##### Built With
 - .NET MAUI
 - SQLite

## Functionality

### Classes
 - **Inheritance** - The User class is an abstract class managing many attributes of both its instances: the Cardholder class, and the Staff class.
 - **Interface** - IBookService manages the borrowing and returning of books, and updating them in the database. ICardService keeps track of Cardholder accounts.
 - Book - Manages all book information.
 - Cardholder - An instance of the User class, it manages all Cardholder accounts.
 - Library - Manages separate library locations.
 - LoanableBook
 - Repository - Enables the SQLite database connection with .NET MAUI.
 - Staff - An instance of the User class, it manages all Staff acounts.
 - User - An abstract class parent to Cardholder and Staff.

### SQLite Database
All attributes of the Book class are stored using an SQLite local database.

### Exceptions
Various try-and-catch exceptions have been implemented within the application:
 - Entering incorrect information into search fields for 'Find a Book'
 - Entering an incorrect ISBN for 'Borrow a Book'


## Reference
CSS topographic pattern background in /shared/MainLayout.razor.css .sidebar
[1] S. Schoger. Hero Patterns. Accessed Apr. 18, 2023. [Online]. Available: https://heropatterns.com/ 
