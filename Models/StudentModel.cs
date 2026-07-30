using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSystem.Models
{
    [Table("Students")]
    public class StudentModel
    {
        [Key]
        public int StudentId { get; set; }
        
        [Column("Student_Name")]
        public string? StudentName { get; set; }
        public string? Email { get; set; }
        
        [Column("Phone_Number")]
        public string? Phone { get; set; }
    }
}
