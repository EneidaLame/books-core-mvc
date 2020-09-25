# Books Example
## A CRUD example with ASP.NET Core MVC and MySQL
Maintains a list of Book Titles. The user can view the list of boks, 
add a new book, edit and change a book's title, or delete a book.

## Instructions

1. Clone this project

2. Open ```books.sln``` solution. Visual Studio will build the project adding any dependencies.

3. Create a MySQL database and grand permissions on this database to a user. (Default DB: example_books_dotnet, user: test, password: test)

4. Create a table **Books** in the database and add an **Id** (int, primary key, auto-increment) and a **Title** (varchar) column. 
5. Adjust the line (14) in the ```Models/MySQLContext.cs``` file, if your database, user, or password is different:

```optionsBuilder.UseMySQL("server=localhost;database=example_books_dotnet;user=test;password=test");```

6. Run the application.