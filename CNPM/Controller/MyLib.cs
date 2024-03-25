using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Drawing;
using System.IO;
using System.Net;
using CNPM.Views;
using System.Windows.Forms;
namespace CNPM.Controller
{
    public class MyLib
    {
        public static Image loadImageFromUrl(string url)
        {
            using (WebClient client = new WebClient())
            {
                byte[] imageBytes = client.DownloadData(url);

                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Bitmap image = new Bitmap(ms);
                    return image;
                }
            }
        }

        public static CardView addNewProduct(string name, int price, string category, string imageUrl) 
        {
            CardView item = new CardView();
            item.productName = name;
            item.productPrice = price+"đ";
            item.productCategory = category;
            item.addButton = "Thêm";
            item.itemmImage = MyLib.loadImageFromUrl(imageUrl);
            return item;
        }
    }
}
