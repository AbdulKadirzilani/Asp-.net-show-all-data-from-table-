using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tuto7.Models;
using System.Data;
using System.Data.SqlClient;
namespace Tuto7.Gateway
{
    public class StudentGateway
    {
        public List<Student> GetStudents()
        {

            SqlConnection connection = new SqlConnection(@"Server=DESKTOP-059A10P\SQLEXPRESS;Database=ASPCRUD;Integrated Security=true;");

            
            string query = "SELECT * FROM Contact3";
            //SqlCommand cmd = new SqlCommand(query, connection);
           // connection.Open();

            SqlCommand command =new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
        
            List<Student> students = new List<Student>();
            while(reader.Read())
            {

                Student student = new Student();
                student.Name = reader["Name"].ToString();
                student.Mobile = reader["Mobile"].ToString();
                students.Add(student); // students collection e sokal stdn add korsi
            }
            connection.Close();
            return students;



        }

        private void ExecuteReader()
        {
            throw new NotImplementedException();
        }
    }
}
