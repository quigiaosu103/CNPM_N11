using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CNPM.Model;
using System.Data;
using MySql.Data.MySqlClient;
using Microsoft.EntityFrameworkCore;

namespace CNPM.Controller
{
    internal class Diary
    {
        private string connectionString = "Server=localhost;Port=3306;Database=cnpm_n11;Uid=root;Pwd=;charset=utf8";
        public DataTable GetCombinedData()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT P.productID, P.name, P.price, O.orderDate, O.orderDate" +
                               " FROM Products P INNER JOIN Orders O ON O.orderID = P.orderID;";
                MySqlCommand command = new MySqlCommand(query, connection);
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))    
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}
