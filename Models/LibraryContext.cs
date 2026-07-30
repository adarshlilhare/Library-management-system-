using Microsoft.EntityFrameworkCore;

namespace LMSystem.Models
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

        public DbSet<Book> Books13 { get; set; }
        public DbSet<BorrowRecord> BorrowRecords13 { get; set; }
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<LibrarianModel> Librarians { get; set; }
        public DbSet<LoginModel> LoginModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoginModel>().HasData(
                new LoginModel { id = 1, username = "admin", password = "12345" },
                new LoginModel { id = 2, username = "mycodingproject", password = "myc546" },
                new LoginModel { id = 3, username = "my", password = "myc" }
            );

            modelBuilder.Entity<LibrarianModel>().HasData(
                new LibrarianModel { LibrarianId = 1, Name = "Sarah Connor", Age = 34, Phone = "555-0201" },
                new LibrarianModel { LibrarianId = 2, Name = "John Doe", Age = 28, Phone = "555-0202" },
                new LibrarianModel { LibrarianId = 3, Name = "Michael Scott", Age = 45, Phone = "555-0203" },
                new LibrarianModel { LibrarianId = 4, Name = "Ellen Ripley", Age = 39, Phone = "555-0204" },
                new LibrarianModel { LibrarianId = 5, Name = "James Bond", Age = 40, Phone = "555-0205" }
            );

            modelBuilder.Entity<StudentModel>().HasData(
                new StudentModel { StudentId = 1, StudentName = "Alice Johnson", Email = "alice.j@email.com", Phone = "555-0101" },
                new StudentModel { StudentId = 2, StudentName = "Bob Smith", Email = "bob.smith@email.com", Phone = "555-0102" },
                new StudentModel { StudentId = 3, StudentName = "Charlie Brown", Email = "charlie.b@email.com", Phone = "555-0103" },
                new StudentModel { StudentId = 4, StudentName = "Diana Prince", Email = "diana.p@email.com", Phone = "555-0104" },
                new StudentModel { StudentId = 5, StudentName = "Evan Wright", Email = "evan.w@email.com", Phone = "555-0105" }
            );
        }
    }
}
