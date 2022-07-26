# ORM
ORM stands for object relational mapper, and it's a technology that abstracts away from having to write specific sql statements.
ORM's help with translating between a programming language (such as C#) and a DB language (ie SQL)

Entity Framework Core is the ORM for .NET Core, and it uses ADO.NET under the hood, but presents even more streamlined interface.

## Two Different Approaches
### DB First (aka Reverse Engineering)
We take the pre-existing db, and let EF core read the schema of the db and create C# objects out of it.
We *scaffold* the tables into our C# objects

### Code First
We take existing C# model objects and let EF Core create tables from it.
We reflect the changes in our C# model to our db through *migrations*

## Dependencies
### In your Data Access Layer Install the following
aka run `dotnet add package package-name`
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.EntityFrameworkCore.SqlServer

### In your Application (in our case, asp.net core app)
- Microsoft.EntityFrameworkCore.Design

### Globally (so anywhere) run this
- `dotnet tool install --global dotnet-ef`

## DbContext Class
DbContext is essentially EFCore's representation of db connection/db structure
In code first, we need to create our own DbContext to let EFCore know, which tables to create with which columns, keys, constraints, etc. However, EFCore just like ASP.NET has a lot of default behaviors, so as long as your model classes follow a certain convention, it will be able to figure it out on its own.

## Migrations (Code first approach)
Is a way to get from one state of DB to new state of DB due to the changes in model
Run these commands in DataAccess layer, and your application needs to build prior to doing any of these.
To create migration:
`dotnet ef migrations add <name of migration> -c <implemented db-context>  --startup-project <location of startup project>`
In order to apply the migration to your DB:
`dotnet ef database update --startup-project <location of startup project>`

Whenever your model changes, run the migration again.