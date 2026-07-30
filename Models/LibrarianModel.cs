using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSystem.Models
{
    [Table("Librarians")]
    public class LibrarianModel
    {
        [Key]
        public int LibrarianId { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Phone { get; set; }
    }
}
