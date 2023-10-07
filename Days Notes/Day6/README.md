# Layout and Validation in MVC .NET Core

## Layout

### Description

the layout is a template that is used to render all the views of the application, it is defined in the file _Layout.cshtml, which is located in the Views/Shared folder.

* RenderBody: It is a method that is used to render the content of the view that is being called.
* RenderSection: It is a method that is used to render the content of the section that is being called.

## Validation

### Description

Validation is a process that is used to verify that the data entered by the user is correct, it is used to avoid errors in the application.

### Data Annotations

Data Annotations are attributes that are used to validate the data entered by the user, they are used in the model class.

* Required: It is used to indicate that the field is required.
* StringLength: It is used to indicate the maximum and minimum length of the field.
* Range: It is used to indicate the maximum and minimum value of the field.
* RegularExpression: It is used to indicate the format of the field.
* EmailAddress: It is used to indicate that the field must be an email.
* Compare: It is used to indicate that the field must be equal to another field.
* DataType: It is used to indicate the type of data that the field must have.

### ModelState

ModelState is a property that is used to validate the data entered by the user, it is used in the controller class.

* IsValid: It is used to indicate if the data entered by the user is valid.

Example:

```csharp
[HttpPost]
public IActionResult Create(Person person)
{
    if (ModelState.IsValid)
    {
        return RedirectToAction("Index");
    }
    return View(person);
}
```

### ValidationMessage

ValidationMessage is a method that is used to display the error message of the field, it is used in the view.

Example:

```csharp
<div class="form-group">
    <label asp-for="Name"></label>
    <input asp-for="Name" class="form-control" />
    <span asp-validation-for="Name" class="text-danger"></span>
</div>

<div class="form-group">
    <label asp-for="Age"></label>
    <input asp-for="Age" class="form-control" />
    <span asp-validation-for="Age" class="text-danger"></span>
</div>

* To enable validation, the following code must be added to the view:

```csharp
@section Scripts {
    @{await Html.RenderPartialAsync("_ValidationScriptsPartial");}
}
```

