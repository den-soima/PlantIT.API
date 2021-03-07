using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace PlantIT.API.Models
{
    public class AuthenticateModel
    {
        [Required] public string Username { get; set; }
        [Required] public string Password { get; set; }
    }
}