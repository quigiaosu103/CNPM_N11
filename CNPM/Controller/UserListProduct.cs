using CNPM.Model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM.Controller
{
    public class UserListProduct
    {
        public static List<DataPayment> dataPayment { get; set; }

        public UserListProduct()
        {
            // Initialize the list of users to the default value.
            dataPayment = new List<DataPayment>();
        }

        // The method to add a user to the list of users.
        public void addProduct(DataPayment data)
        {
            // Add the user to the list of users.
            dataPayment.Add(data);
        }

        // The method to get the list of users.
        public List<DataPayment> getProduct()
        {
            // Return the list of users.
            return dataPayment;
        }

    }


}
