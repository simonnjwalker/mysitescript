using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
namespace xx.Models;
public class xxuser : Microsoft.AspNetCore.Identity.IdentityUser
{

        public string FirstName = "";
        public string LastName = "";
}
