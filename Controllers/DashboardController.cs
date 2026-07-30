using LMSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;

namespace LMSystem.Controllers
{
    public class DashboardController : Controller
    {
        private readonly string _connectionString = "Data Source=library.db";

        public IActionResult Index()
        {
            var model = new DashboardModel();

            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                // Count Students
                using (var cmd = new SqliteCommand("SELECT COUNT(*) FROM Students", connection))
                {
                    model.TotalStudents = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // Count Books
                using (var cmd = new SqliteCommand("SELECT COUNT(*) FROM Books13", connection))
                {
                    model.TotalBooks = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // Count Librarians
                using (var cmd = new SqliteCommand("SELECT COUNT(*) FROM Librarians", connection))
                {
                    model.TotalLibrarians = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // Count Borrowings
                using (var cmd = new SqliteCommand("SELECT COUNT(*) FROM BorrowRecords13", connection))
                {
                    model.TotalBorrowings = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return View(model);
        }
    }
}
