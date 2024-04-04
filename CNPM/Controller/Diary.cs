using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CNPM.Model;
using System.Data;
//using MySql.Data.MySqlClient;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;

namespace CNPM.Controller
{
    internal class Diary
    {
        private string connectionString = "server=127.0.0.1;uid=root;pwd=;database=foodordering";
        public DataTable GetCombinedData()
        {
            DataTable dt = new DataTable();
            //using (MySqlConnection connection = new MySqlConnection(connectionString))
            //{
            //    connection.Open();
            //    string query = "SELECT P.Id, P.Name, P.Price, O.Date, O.Date" +
            //                   " FROM Products P INNER JOIN Orders O ON O.Id = P.OrderId;";
            //    MySqlCommand command = new MySqlCommand(query, connection);
            //    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            //    {
            //        adapter.Fill(dt);
            //    }
            //}
            return dt;
        }
    }
}
