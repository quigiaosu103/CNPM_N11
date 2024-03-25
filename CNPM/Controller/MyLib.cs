using System.Net;
using CNPM.Views;
using Guna.UI2.WinForms;
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

        public static CardView addNewProduct(string id, string name, int price, string category, Image image) 
        {
            CardView item = new CardView();
            item.productId = id;
            item.productName = name;  
            item.productPrice = price+"đ";
            item.productCategory = category;
            item.addButton = "Thêm";
            item.itemmImage = image;
            return item;
        }


        public static Image openFileDialog()
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                return new Bitmap(open.FileName);
            }
            return null;
        }

        public static void clearText(Guna2TextBox[] textboxes)
        {
            foreach(Guna2TextBox box in textboxes)
            {
                box.Clear();
            }
        }

       
        public static void loadProductInfo(string id, string name, string price, string type)
        {
        }
    }
}
