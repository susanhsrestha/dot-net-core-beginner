using CollegeApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace CollegeApp.Controllers
{
    public class StudentController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([Bind("StudentId, FirstName, LastName, Mobile")] Student student)
        {
            string connectionString = "Server=(localdb)\\local;Database=aspnet-CollegeApp;Trusted_Connection=True;MultipleActiveResultSets=true";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand SQLCmd = new SqlCommand();
            SQLCmd.Connection = conn;
            SQLCmd.CommandText = "[dbo].[uspStudentAdd]";
            SQLCmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter sqlParameter= new SqlParameter();
            sqlParameter.IsNullable  = true;
            sqlParameter.ParameterName = "@FirstName";
            sqlParameter.Value = student.FirstName;
            SQLCmd.Parameters.Add(sqlParameter);

            SqlParameter sqlParameter2 = new SqlParameter();
            sqlParameter2.IsNullable = true;
            sqlParameter2.ParameterName = "@LastName";
            sqlParameter2.Value = student.LastName;
            SQLCmd.Parameters.Add(sqlParameter2);

            SqlParameter sqlParameter3 = new SqlParameter();
            sqlParameter3.IsNullable = true;
            sqlParameter3.ParameterName = "@Mobile";
            sqlParameter3.Value = student.Mobile;
            SQLCmd.Parameters.Add(sqlParameter3);

            conn.Open();
            SQLCmd.ExecuteNonQuery();
            conn.Close();

            return View();
        }
    }
}
