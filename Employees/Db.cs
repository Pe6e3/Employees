using Employees.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Employees
{
    public class Db
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=employees");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
            return connection;
        }


        public List<Company> GetCompanyNames()
        {
            List<Company> companies = new List<Company>();

            string query = "SELECT Id, Name, INN, Address, Note FROM companies";

            using (MySqlCommand command = new MySqlCommand(query, GetConnection()))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Company company = new Company();
                        company.Id = Convert.ToInt32(reader["Id"]);
                        company.Name = reader["Name"].ToString();
                        company.INN = reader["INN"].ToString();
                        company.Address = reader["Address"].ToString();
                        company.Note = reader["Note"].ToString();

                        companies.Add(company);
                    }
                }
            }

            return companies;
        }

        public void AddEmployee(Employee newEmployee, int companyId = 0)
        {
            string queryEmployee = "INSERT INTO employees (FirstName, LastName, MiddleName, IIN) " +
                                   "VALUES (@FirstName, @LastName, @MiddleName, @IIN)";
            int employeeId = 0;

            using (MySqlCommand command = new MySqlCommand(queryEmployee, GetConnection()))
            {
                command.Parameters.AddWithValue("@FirstName", newEmployee.FirstName);
                command.Parameters.AddWithValue("@LastName", newEmployee.LastName);
                command.Parameters.AddWithValue("@MiddleName", newEmployee.MiddleName);
                command.Parameters.AddWithValue("@IIN", newEmployee.IIN);
                command.ExecuteNonQuery();

                employeeId = (int)command.LastInsertedId;// Получаем Id только что созданного сотрудника
            }

            if (companyId != 0)
            {
                string queryCompanyEmployees = "INSERT INTO companyemployees (CompanyId, EmployeeId) " +
                                               "VALUES (@companyId, @employeeId)";
                using (MySqlCommand command = new MySqlCommand(queryCompanyEmployees, GetConnection()))
                {
                    command.Parameters.AddWithValue("@companyId", companyId);
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
