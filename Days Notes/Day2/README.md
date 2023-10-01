# Getting Started 
1. Install the required packages
### Notes
.Net Framework:
* you need to install EntityFramework package from NuGet package manager -but it only works for sql server database-. 

.Net Core: 
* you need to install EntityFrameworkCore package from NuGet package manager 
* you need to install the database provider package from NuGet package manager -for example: `Microsoft.EntityFrameworkCore.SqlServer` for sql server database-.
* Also you need to install EntityFrameworkCore.Tools package from NuGet package manager to be able to use the migration commands.

2. Create Model classes

3. Create a class to inherit from DbContext class  
    1- create main dbsets
    2- override OnConfiguring method to configure the connection string
    
### Migration Commands
* `Add-Migration <MigrationName>`: to create a migration file
* `Update-Database`: to update the database with the latest migration file

# Middlewares
* Middlewares are components that are added to the pipeline to handle requests and responses.
* Middlewares are added to the pipeline in the `Configure` method in the `Startup` class.
* Middlewares are executed in the order they are added to the pipeline.
* Middlewares are classes that have a method called `Invoke` or `InvokeAsync` that takes a `HttpContext` object and returns a `Task`.
* Middlewares can be added to the pipeline using `Use`, `Run` and `map` extension method.
    * `Use` is used to add a middleware to the pipeline.
    * `Run` is used to add a middleware to the pipeline that is the last middleware in the pipeline.
    * `Map` is used to add a middleware to the pipeline that is executed only when the path of the request matches the specified path.

## Built-in Middlewares
* UseDeveloperExceptionPage
* UseDatabaseErrorPage
* UseExceptionHandler
* UseBrowserLink
* UseStaticFiles
* UseDefaultFiles
* UseFileServer
* UseDirectoryBrowser
* UseAuthentication
* UseSession  
And many more...  
For more information about built-in middlewares, check [this link](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-2.2#built-in-middleware)
