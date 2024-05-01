using CNPM.Migrations;
using CNPM.Model;
using FontAwesome.Sharp;
using Guna.Charts.WinForms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Media;
using static CNPM.Controller.TrangChuController;
using Color = System.Drawing.Color;

namespace CNPM.Controller
{
    public class TrangChuController
    {
        public class Pair
        {
            public int First { get; set; }
            public int Second { get; set; }

            public Pair(int first, int second)
            {
                First = first;
                Second = second;
            }
        }
        public bool checkEmpty(DataTable dataTable)
        {
            return dataTable.Rows.Count > 0;
        }

        public static long getValue(int month)
        {
            using (var context = new MyDatabaseContext())
            {
                var dataInMonth = context.Orders.Where(x => x.Date.Month == month && x.Date.Year == DateTime.Now.Year);
                long total = 0; 
                foreach(var i in dataInMonth)
                {
                    total += i.TotalPrice;
                }
                return total;
            }
        }

        public static string getName(int id)
        {
            using (var context = new MyDatabaseContext())
            {
                var nameProduct = context.Products.Where(x => x.Id == id).Select(x=>x.Name).FirstOrDefault();
                return nameProduct;
            }
        }

        public static List<Pair> sortList(DateTime start, DateTime end)
        {
           
            var (listId, listAmount) = getIdOrderItem(start, end, false);
            int[] array = new int[listAmount.Count];
            listAmount.CopyTo(array, 0);
            Array.Sort(array);
            Array.Reverse(array);
            List<string> a = new List<string>();
            List<Pair> pairs = new List<Pair>();
            foreach(var j in array)
            {
                for(int i = 0; i < listAmount.Count(); i++)
                {
                    if (j == listAmount[i])
                    {
                        pairs.Add(new Pair(listId[i], listAmount[i]));
                    }
                }
            }   
            return pairs;
        }

        public static (List<int>, List<int>) getIdOrderItem(DateTime start, DateTime end, bool status)
        {
            List<Pair> pairs = new List<Pair>();
            List<int> resultListId = new List<int>();
            List<int> resultListAmount = new List<int>();
            using (var context = new MyDatabaseContext())
            {
                var ordersInMonth = context.Orders.Where(x => x.Date > start && x.Date < end).ToList();
                if (status == false)
                {
                    ordersInMonth = context.Orders.ToList();
                } 
                foreach (var order in ordersInMonth)
                {
                    var orderItems = context.OrderItems.Where(x => x.Order.Id == order.Id).Select(y => new { y.Product.Id, y.Amount }).ToList();
                    foreach (var orderItem in orderItems)
                    {
                        pairs.Add(new Pair(orderItem.Amount, orderItem.Id));
                    }
                }
                HashSet<int> uniqueFirstElements = new HashSet<int>();
                foreach (var tuple in pairs)
                {
                    if (!uniqueFirstElements.Contains(tuple.Second))
                    {
                        uniqueFirstElements.Add(tuple.Second);
                        resultListId.Add(tuple.Second);
                    }
                }
                for (int i = 0; i < resultListId.Count; i++)
                {
                    int count = 0;
                    for (int j = 0; j < pairs.Count; j++)
                    {
                        if (resultListId[i] == pairs[j].Second)
                        {
                            count += pairs[j].First;
                        }
                    }
                    resultListAmount.Add(count);
                }
            }
            return (resultListId, resultListAmount);
        }
        private static (List<int>, List<int>) getFiveData(List<int> listId, List<int> listAmount)
        {
            List<int> resultListId = new List<int>();
            List<int> resultListAmount = new List<int>();
            int amount = 0;
            if (listId.Count > 6)
            {
                for (int i = 0; i < 5; i++)
                {
                    resultListAmount.Add(listAmount[i]);
                    resultListId.Add(listId[i]);
                }
                for (int i = 5; i<listAmount.Count; i++)
                {
                    amount += listAmount[i];
                }
                resultListAmount.Add(amount);
                resultListId.Add(-1);
                return (resultListId, resultListAmount);
            } else
            {
                return(listId, listAmount);
            }
           
        }
        private static DataTable dataSetPieChart(DateTime start, DateTime end)
        {
            using (var context = new MyDatabaseContext())
            {
                var (listId, listAmount) = getIdOrderItem(start, end, true);
                var (listIdNew, listAmountNew) = getFiveData(listId, listAmount);
                DataTable dataTable = new DataTable("MyTable");
                dataTable.Columns.Add("A", typeof(string));
                dataTable.Columns.Add("b", typeof(double));

                for (int i = 0; i < listIdNew.Count; i++)
                {
                    if(listIdNew[i] != -1)
                    {
                        var nameProduct = context.Products.Where(x => x.Id == listIdNew[i]).FirstOrDefault();

                        dataTable.Rows.Add(nameProduct.Name.ToString(), listAmountNew[i]);
                    } else
                    {
                        dataTable.Rows.Add("Các sản phẩm khác", listAmountNew[i]);
                    }
                }
                return dataTable;
            }
        }

        public void ChartPie(GunaChart chart, string nameChart, DateTime start, DateTime end)
        {
            var data = dataSetPieChart(start, end);
            if (checkEmpty(data))
            {
                chart.Datasets.Clear();
                chart.Legend.Position = LegendPosition.Right;
                chart.Legend.Display = true;
                chart.XAxes.Display = false;
                chart.YAxes.Display = false;
                var dataset = new GunaPieDataset();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    dataset.Label = "Số lượng";
                    dataset.Label = data.Rows[i][0].ToString();
                    dataset.DataPoints.Add(
                    Convert.ToString(data.Rows[i][0]),
                    Convert.ToDouble(data.Rows[i][1])
                    );
                 
                }
                chart.Datasets.Add(dataset);
            }
            //else
            //    MessageBox.Show("Lỗi dữ liệu", "Lỗi");
        }
        private DataTable dataSetBarChart()
        {
            DataTable dataTable = new DataTable("MyTable");
            dataTable.Columns.Add("A", typeof(string));
            dataTable.Columns.Add("b", typeof(double));
            for (int i = 1; i <= 12; i++)
            {
                string month = "Tháng " + i.ToString();
                dataTable.Rows.Add(month, getValue(i));
            }
            return dataTable;
        }

        public void ChartBar(GunaChart chart, string nameChart)
        {
            var data = dataSetBarChart();
            if (checkEmpty(data))
            {
                chart.Datasets.Clear();
                chart.Legend.Display = false;
                chart.YAxes.GridLines.Display = false;
                chart.XAxes.Display = true;
                chart.YAxes.Display = true;
                chart.Title.Text = nameChart;
                chart.Title.ForeColor = Color.FromArgb(138, 76, 20);
                var dataset = new GunaBarDataset();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    dataset.Label = "Doanh thu";
                    dataset.DataPoints.Add(
                    Convert.ToString(data.Rows[i][0]),
                    Convert.ToDouble(data.Rows[i][1])
                    );      
                }
                chart.Datasets.Add(dataset);
            }
            //else
            //    MessageBox.Show("Lỗi dữ liệu", "Lỗi");
        }   
    }
}
