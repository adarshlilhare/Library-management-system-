using LMSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;

namespace LMSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly string _connectionString = "Data Source=library.db";

        public IActionResult Index()
        {
            var students = new List<StudentModel>();
            using var con = new SqliteConnection(_connectionString);
            var cmd = new SqliteCommand("SELECT * FROM Students", con);
            con.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                students.Add(new StudentModel
                {
                    StudentId = Convert.ToInt32(reader["StudentId"]),
                    StudentName = reader["Student_Name"].ToString(),
                    Email = reader["Email"].ToString(),
                    Phone = reader["Phone_Number"].ToString()
                });
            }
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            using var con = new SqliteConnection(_connectionString);
            var cmd = new SqliteCommand("INSERT INTO Students (Student_Name, Email, Phone_Number) VALUES (@Name, @Email, @Phone)", con);
            cmd.Parameters.AddWithValue("@Name", model.StudentName);
            cmd.Parameters.AddWithValue("@Email", model.Email);
            cmd.Parameters.AddWithValue("@Phone", model.Phone);
            con.Open();
            cmd.ExecuteNonQuery();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            StudentModel student = new();
            using var con = new SqliteConnection(_connectionString);
            var cmd = new SqliteCommand("SELECT * FROM Students WHERE StudentId=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                student.StudentId = Convert.ToInt32(reader["StudentId"]);
                student.StudentName = reader["Student_Name"].ToString();
                student.Email = reader["Email"].ToString();
                student.Phone = reader["Phone_Number"].ToString();
            }
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(StudentModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            using var con = new SqliteConnection(_connectionString);
            var cmd = new SqliteCommand("UPDATE Students SET Student_Name=@Name, Email=@Email, Phone_Number=@Phone WHERE StudentId=@id", con);
            cmd.Parameters.AddWithValue("@Name", model.StudentName);
            cmd.Parameters.AddWithValue("@Email", model.Email);
            cmd.Parameters.AddWithValue("@Phone", model.Phone);
            cmd.Parameters.AddWithValue("@id", model.StudentId);
            con.Open();
            cmd.ExecuteNonQuery();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            using var con = new SqliteConnection(_connectionString);
            var cmd = new SqliteCommand("DELETE FROM Students WHERE StudentId=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            return RedirectToAction("Index");
        }
    }
}
