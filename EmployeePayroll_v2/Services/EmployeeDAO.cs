using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using EmployeePayroll_v2.Models;

namespace EmployeePayroll_v2.Services
{
    public class EmployeeDAO
    {
        private MyConfig MyConfig;
        private string ConnectionString;

        public EmployeeDAO()
        {
            MyConfig = new MyConfig();
            ConnectionString = MyConfig.DefaultConnection;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> foundEmployees = new List<Employee>();

            string SQL = "SELECT * FROM EMPLOYEE " +
                         "ORDER BY LASTNAME, FIRSTNAME ";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(SQL, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Employee employee = GetEmployeeRecord(reader);
                        foundEmployees.Add(employee);
                    }
                    return foundEmployees;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public Employee GetEmployeeById(int Id)
        {
            string SQL = "SELECT * FROM EMPLOYEE " + 
                         "WHERE ID = @Id";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(SQL, connection);
                command.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = Id;
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        Employee employee = GetEmployeeRecord(reader);
                        return employee;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public Employee GetEmployeeByName(string lastName, string firstName)
        {
            string SQL = "SELECT * FROM EMPLOYEE " +
                         "WHERE LASTNAME = @LastName AND FIRSTNAME = @FirstName ";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(SQL, connection);
                command.Parameters.Add("@LastName", System.Data.SqlDbType.VarChar, 100).Value = lastName;
                command.Parameters.Add("@FirstName", System.Data.SqlDbType.VarChar, 100).Value = firstName;
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        Employee employee = GetEmployeeRecord(reader);
                        return employee;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public List<Employee> GetEmployeesByKey(string key)
        {
            List<Employee> foundEmployees = new List<Employee>();

            string SQL = "SELECT * FROM EMPLOYEE " +
                         "WHERE (LASTNAME LIKE '%" + key + "%') " +
                         "      OR (FIRSTNAME LIKE '%" + key + "%') " +
                         "ORDER BY LASTNAME, FIRSTNAME ";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(SQL, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Employee employee = GetEmployeeRecord(reader);
                        foundEmployees.Add(employee);
                    }
                    return foundEmployees;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public int GetEmployeeCount()
        {
            string SQL = "SELECT COUNT(ID) AS QTY FROM EMPLOYEE ";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(SQL, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    int count = Convert.ToInt32(reader["QTY"]);
                    return count;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }

        private Employee GetEmployeeRecord(SqlDataReader reader)
        {
            Employee employee = new Employee();
            employee.Id = Convert.ToInt32(reader["Id"]);
            employee.LastName = reader["LastName"].ToString();
            employee.FirstName = reader["FirstName"].ToString();
            employee.BirthDate = Convert.ToDateTime(reader["BirthDate"]);
            employee.TIN = reader["TIN"].ToString();
            employee.EmployeeType = (EnumEmployeeTypes)Convert.ToInt32(reader["EmployeeType"]);
            employee.MonthlyRate = Convert.ToDecimal(reader["MonthlyRate"]);
            employee.DailyRate = Convert.ToDecimal(reader["DailyRate"]);
            return employee;
        }

        public int Insert(Employee employee)
        {
            string SQL = "INSERT INTO EMPLOYEE " +
                         "(LASTNAME, FIRSTNAME, BIRTHDATE, TIN, EMPLOYEETYPE, MONTHLYRATE, DAILYRATE) " +
                         "VALUES (@LastName, @FirstName, @BirthDate, @TIN, @EmployeeType, @MonthlyRate, @DailyRate) ";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(SQL, connection);
                command.Parameters.Add("@LastName", System.Data.SqlDbType.VarChar, 100).Value = employee.LastName;
                command.Parameters.Add("@FirstName", System.Data.SqlDbType.VarChar, 100).Value = employee.FirstName;
                command.Parameters.Add("@BirthDate", System.Data.SqlDbType.DateTime2, 7).Value = employee.BirthDate;
                command.Parameters.Add("@TIN", System.Data.SqlDbType.VarChar, 50).Value = employee.TIN;
                command.Parameters.Add("@EmployeeType", System.Data.SqlDbType.Int).Value = Convert.ToInt32(employee.EmployeeType);
                command.Parameters.Add("@MonthlyRate", System.Data.SqlDbType.Decimal).Value = employee.MonthlyRate;
                command.Parameters.Add("@DailyRate", System.Data.SqlDbType.Decimal).Value = employee.DailyRate;

                try
                {
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex) 
                {
                    return 0;
                }
            }
        }

        public int Update(Employee employee)
        {
            string SQL = "UPDATE EMPLOYEE " +
                         "SET LASTNAME = @LastName, FIRSTNAME = @FirstName, BIRTHDATE = @BirthDate, TIN = @TIN, " +
                         "EMPLOYEETYPE = @EmployeeType, MONTHLYRATE = @MonthlyRate, DAILYRATE = @DailyRate " +
                         "WHERE ID = @Id ";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(SQL, connection);
                command.Parameters.Add("@LastName", System.Data.SqlDbType.VarChar, 100).Value = employee.LastName;
                command.Parameters.Add("@FirstName", System.Data.SqlDbType.VarChar, 100).Value = employee.FirstName;
                command.Parameters.Add("@BirthDate", System.Data.SqlDbType.DateTime2, 7).Value = employee.BirthDate;
                command.Parameters.Add("@TIN", System.Data.SqlDbType.VarChar, 50).Value = employee.TIN;
                command.Parameters.Add("@EmployeeType", System.Data.SqlDbType.Int).Value = Convert.ToInt32(employee.EmployeeType);
                command.Parameters.Add("@MonthlyRate", System.Data.SqlDbType.Decimal).Value = employee.MonthlyRate;
                command.Parameters.Add("@DailyRate", System.Data.SqlDbType.Decimal).Value = employee.DailyRate;
                command.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = employee.Id;

                try
                {
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }

        public int Delete(int Id)
        {
            string SQL = "DELETE FROM EMPLOYEE " +
                         "WHERE ID = @Id ";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(SQL, connection);
                command.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = Id;

                try
                {
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
                catch
                {
                    return 0;
                }
            }
        }

        public string ValidateEmployee(Employee employee)
        {
            string SQL = "SELECT * FROM EMPLOYEE " +
                         "WHERE LASTNAME = @LastName AND FIRSTNAME = @FirstName AND ID <> @Id";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(SQL, connection);
                command.Parameters.Add("@LastName", System.Data.SqlDbType.VarChar, 100).Value = employee.LastName;
                command.Parameters.Add("@FirstName", System.Data.SqlDbType.VarChar, 100).Value = employee.FirstName;
                command.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = employee.Id;
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return "A similar record already exists for this employee.";
                    }
                    else
                    {
                        return "";
                    }
                }
                catch (Exception ex)
                {
                    return "Error in validating employee";
                }
            }
        }
    }
}
