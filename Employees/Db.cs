using Employees.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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


        public List<Company> GetAllCompanies()
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

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            string queryEmployees = "SELECT * FROM employees";
            using (MySqlCommand command = new MySqlCommand(queryEmployees, GetConnection()))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Employee employee = new Employee();
                        employee.Id = Convert.ToInt32(reader["ID"]);
                        employee.FirstName = reader["FirstName"].ToString();
                        employee.LastName = reader["LastName"].ToString();
                        employee.MiddleName = reader["MiddleName"].ToString();
                        employee.IIN = reader["IIN"].ToString();
                        employee.Fullname = $"{employee.LastName} {employee.FirstName} {employee.MiddleName}";
                        employees.Add(employee);
                    }
                }
            }
            return employees;
        }

        public List<Employee> GetEmployeesOfCompany(int companyId)
        {
            List<Employee> employees = new List<Employee>();
            List<CompanyEmployee> companyEmployees = new List<CompanyEmployee>();
            string queryEmployees = "SELECT * FROM employees";
            string queryCompanyEmployees = "SELECT * FROM `companyemployees` WHERE `CompanyId` = @cId";

            using (MySqlCommand command = new MySqlCommand(queryCompanyEmployees, GetConnection()))
            {
                command.Parameters.AddWithValue("@cId", companyId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CompanyEmployee companyEmployee = new CompanyEmployee();
                        companyEmployee.Id = Convert.ToInt32(reader["Id"]);
                        companyEmployee.CompanyId = Convert.ToInt32(reader["CompanyId"]);
                        companyEmployee.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                        companyEmployees.Add(companyEmployee);
                    }
                }
            }

            using (MySqlCommand command = new MySqlCommand(queryEmployees, GetConnection()))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Employee employee = new Employee();
                        employee.Id = Convert.ToInt32(reader["ID"]);
                        employee.FirstName = reader["FirstName"].ToString();
                        employee.LastName = reader["LastName"].ToString();
                        employee.MiddleName = reader["MiddleName"].ToString();
                        employee.IIN = reader["IIN"].ToString();
                        employee.Fullname = $"{employee.LastName} {employee.FirstName} {employee.MiddleName}";

                        // перебираем таблицу связей компаний и сотрудников, и если Id сотрудника в этой таблице совпадает с Id сотрудника,
                        // которого читаем в текущей строке таблицы всех сотрудников - добавляем его в итоговый список
                        foreach (CompanyEmployee companyEmployee in companyEmployees)
                            if (companyEmployee.EmployeeId == employee.Id)
                                employees.Add(employee);
                    }
                }
            }

            return employees;
        }

        internal void AddCompany(Company newCompany)
        {
            string queryCompany = "INSERT INTO companies (Name, INN, Address, Note) " +
                                  "VALUES (@Name, @INN, @Address, @Note)";

            using (MySqlCommand command = new MySqlCommand(queryCompany, GetConnection()))
            {
                command.Parameters.AddWithValue("@Name", newCompany.Name);
                command.Parameters.AddWithValue("@INN", newCompany.INN);
                command.Parameters.AddWithValue("@Address", newCompany.Address);
                command.Parameters.AddWithValue("@Note", newCompany.Note);
                command.ExecuteNonQuery();
            }
        }


        public void DeleteEmployee(int employeeId)
        {
            string queryDelete = "DELETE FROM `employees` WHERE `employees`.`Id` = @eId";
            using (MySqlCommand command = new MySqlCommand(queryDelete, GetConnection()))
            {
                command.Parameters.AddWithValue("@eId", employeeId);
                command.ExecuteNonQuery();
            }
            MessageBox.Show($"Сотрудник с Id = {employeeId} удален");
        }

        public void ClearCompanyEmployees(int companyId)
        {
            string query = @"
                            DELETE e
                            FROM `employees` e
                            JOIN `companyemployees` ce ON e.Id = ce.EmployeeId
                            WHERE ce.CompanyId = @cId";

            using (MySqlCommand command = new MySqlCommand(query, GetConnection()))
            {
                command.Parameters.AddWithValue("@cId", companyId);
                command.ExecuteNonQuery();
            }
            MessageBox.Show($"Сотрудники компании с Id = {companyId} удалены");
        }


        private void DeleteCompanyEmployee(int employeeId)
        {
            string queryDeleteCompanyEmployee = "DELETE FROM `companyemployees` WHERE `companyemployees`.`EmployeeId` = @eId";
            using (MySqlCommand command = new MySqlCommand(queryDeleteCompanyEmployee, GetConnection()))
            {
                command.Parameters.AddWithValue("@eId", employeeId);
                command.ExecuteNonQuery();
            }
        }
    }
}
