using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Management.Models
{
    public class User : IdentityUser
    {
        [System.ComponentModel.DataAnnotations.Required, MaxLength(20)]
        public string FirstName { get; set; }
        [System.ComponentModel.DataAnnotations.Required, MaxLength(20)]
        public string LastName { get; set; }
        
        public virtual List<Task> Tasks{ get; set; }

    }
}
