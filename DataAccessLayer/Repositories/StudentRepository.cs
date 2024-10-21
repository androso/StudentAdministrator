using CommonLayer.Entities;
using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class StudentRepository
    {
        private SqlDataAccess _dbConnection;
        public StudentRepository()
        {
            _dbConnection = new SqlDataAccess();
        }
        public DataTable GetStudents()
        {
            DataTable studentsTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT * FROM student";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                studentsTable.Load(reader);
            }

            return studentsTable;
        }

        public void AddStudent(Student student)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "INSERT INTO student VALUES(@StudentName, @StudentLastName, @CareerId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentName", student.nameStudent);
                command.Parameters.AddWithValue("@StudentLastName", student.lastNameStudent);
                command.Parameters.AddWithValue("@CareerId", student.idCareerStudent);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }
        public void EditStudent(Student student)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE student 
								 SET nameStudent = @StudentName,
									 lastnameStudent = @StudentLastName 
                                        idCareerStudent = @CareerId
								 WHERE idStudent = @StudentId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentName", student.nameStudent);
                command.Parameters.AddWithValue("@StudentLastName", student.lastNameStudent);
                command.Parameters.AddWithValue("@StudentId", student.idStudent);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void DeleteCareer(int id)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM student WHERE idStudent = @StudentId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentId", id);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}
