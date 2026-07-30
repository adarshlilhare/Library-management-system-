using System.ComponentModel.DataAnnotations.Schema;

namespace LMSystem.Models
{
    [Table("logintab")]
    public class LoginModel
    {
        public int id { get; set; }
        public string? username { get; set; }
        public string? password { get; set; }
    }
}
