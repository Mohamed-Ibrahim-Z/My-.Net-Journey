# Model Binding .NET Core MVC

## Action Method
* Public method on a controller class
* Action method must be public, non-static, and non-abstract
* Action method cannot be overloaded

## Action Method Parameters
* Action method parameters are the parameters of the public method on a controller class.
* Action method parameters can be simple types, complex types, or collection types.
* Action method can include Nullable type parameters.

### Parameter Sources
* In the URL path: such as /Home/Index/17
* In the query string: such as /Home/Index?id=17
* In the request body: such as POST /Home/Index with data in the request body
* In form values: such as POST /Home/Index with form data in the request body

## Model Binding
* Model binding is the process of mapping HTTP request data to action method parameters.
* Model binding is a part of the MVC request pipeline.
* Model binding is performed before the action method is invoked.
* The HTTP Request can contain data in various formats. The data can contain in the HTML form fields. It could be part of the route values. It could be part of the query string or it may contain in the body of the request.
#### For the Binding to work correctly
* The name of the parameter in the action method should match the name of the value in the request data.
* The data type of the parameter in the action method should match the data type of the value in the request data.
* Properties must be defined as public settable

### Built in ValueProvider
Available Built in Provider, Sorted according priority
* FormValueProvider
* RouteDataValueProvider
* QueryStringValueProvider
* FromFileValueProvider

This binding is <span style= "color:red">case insensitive</span>.

1- binding to primitive types
```csharp
public IActionResult Index(int id)
{
    return View();
}
```
2- binding to complex types
```csharp
public IActionResult Index(Employee employee)
{
    return View();
}
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}
```
3- binding to collection types
```csharp
public IActionResult Index(List<Employee> employees)
{
    return View();
}
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}
```

### Bind Attribute
* The Bind attribute is used to whitelist properties and fields for model binding.

```csharp
public IActionResult Index([Bind("Id,Name")]Employee employee)
{
    return View();
}
```

### Advantages of Model Binding
* Model binding reduces the need for you to manually extract values from the request and then assign them to the action method parameters.
* It makes the action methods easier to Unit Test as the action method is not relying on any framework component such as Request or Response.
