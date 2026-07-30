using System.ComponentModel.DataAnnotations;

namespace LMSystem.Models
{
    public class BorrowRecord
    {
        [Key]
        public int BorrowRecordId { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public string BorrowerName { get; set; }
        public string BorrowerEmail { get; set; }
        public string Phone { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
