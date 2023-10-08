using Microsoft.AspNetCore.Authorization;

public class AnonymousOnly : AuthorizeAttribute
{
    public AnonymousOnly() : base()
    {
       // Roles = "Anonymous";
        Policy = "AnonymousOnly";
    }
}