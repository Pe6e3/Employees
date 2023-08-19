using Employees.Entities;
using MySql.Data.MySqlClient;
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

            string query = "SELECT Name, INN, Address, Note FROM companies";

            using (MySqlCommand command = new MySqlCommand(query, GetConnection()))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Company company = new Company();
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

    }
}
