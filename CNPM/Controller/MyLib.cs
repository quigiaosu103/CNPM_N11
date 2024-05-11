using System.Drawing.Imaging;
using System.Net;
using System.Text;
using CNPM.Model;
using CNPM.Views;
using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using static System.Net.WebRequestMethods;
using System.Net.Mail;
using System.Windows.Markup.Localizer;
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
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[length];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new String(stringChars);
        }



        public static CardView addNewProduct(string id, string name, int price, Category category, string image64String, string des = "")
        {
            CardView item = new CardView();
            item.productId = id;
            if (name.Length > 16)
            {
                item.productName = name.Substring(0, 16) + "...";
            }else
            {
                item.productName = name;
            }
            item.productPrice = price + "";
            item.productCategory = category.Name;
            item.addButton = "Thêm";
            item.itemmImage = Base64ToImage(image64String);
            item.description = des;
            item.cateId = category.Id;
            return item;
        }


        public static CardView updateProductView(CardView cardview, Product product)
        {
            cardview.productName = product.Name;
            cardview.productPrice = product.Price + "";
            cardview.description = product.Description;
            cardview.productCategory = product.category.Name;
            if(product.ImageUrl!="")
            {
                cardview.itemmImage = Base64ToImage(product.ImageUrl);
            }
            return cardview;
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

        public static string ImageToBase64(Image image, ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        public static Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        public static void AlertMessage(string message)
        {
            Form f = new Form();
            Label lab = new Label();
            lab.AutoSize = true;
            lab.Text = message;
            f.Controls.Add(lab);
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        public static void InitUser()
        {
            UserAuthen.currentUser = new Model.User
            {
                UserId = "admin1",
                FullName = "admin",
                Address = "",
                PhoneNumber = "",
                Account = null

            };
        }

        public static void InitUserProduct(List<DataPayment> data)
        {
            UserListProduct userListProduct = new UserListProduct();
            foreach (DataPayment dataPayment in data)
            {
                userListProduct.addProduct(dataPayment);
            }
        }
        public static void searchProduct(string searchValue, FlowLayoutPanel layout)
        {
            if (!(searchValue == ""))
            {
                using (var context = new MyDatabaseContext())
                {
                    var products = context.Products
                        .Include(p => p.category)
                        .Where(pr => pr.Name
                        .Contains(searchValue) || pr.category.Name.Contains(searchValue)).ToList();
                    setProductList(products, layout);
                }
            }
        }

        public static void setProductList(List<Product> list, FlowLayoutPanel layout)
        {
            layout.Controls.Clear();
            foreach (Product product in list)
            {
                CardView item = MyLib.addNewProduct(product.Id + "", product.Name, product.Price, product.category, product.ImageUrl, product.Description);
                layout.Controls.Add(item);
            }
        }
        public static void updateUserInfo(string[] infor, int genderIndex, DateTime birthday)
        {
            using (var context = new MyDatabaseContext())
            {
                var currUserId = UserAuthen.currentUser.UserId;
                var user = context.Users.Include(u => u.Account).Where(c => c.UserId == currUserId).FirstOrDefault();
               // var account = context.Account.Find(user.Account.UserName);
                user.FullName = infor[0];
                user.Gender = genderIndex;
                user.PhoneNumber = infor[1];
                user.Address = infor[2];
                user.Account.AvatarUrl = infor[3];
                user.BirthDay = birthday;
                context.Users.Update(user);
                //context.Account.Update(account);
                context.SaveChanges();
                AlertMessage("Update successfully!");
            }

            //update local

            UserAuthen.currentUser.Gender = genderIndex;
            UserAuthen.currentUser.FullName = infor[0];
            UserAuthen.currentUser.PhoneNumber = infor[1];
            UserAuthen.currentUser.Address = infor[2];
            UserAuthen.currentUser.Account.AvatarUrl = infor[3];
            UserAuthen.currentUser.BirthDay = birthday;
        }
        public static string hashPassword(string pass)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(pass);
            using (SHA256 sha256 = SHA256.Create())
            {
                
                byte[] hashBytes = sha256.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static string SendOTP(string to)
        {

            string from = "leanhquan99982@gmail.com";
            string pass = "grmt hetg mfkc sxza";
            string verification_code = $"{DateTime.Now.Second}{DateTime.Now.Millisecond}";
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = "Mã xác thực của bạn là: " + verification_code;
            message.Subject = "WeFood - Mã xác thực";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Mã xác thực đã được gửi thành công, kiểm tra mail của bạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return verification_code;
        }

        public static int checkList(List<DataPayment> list)
        {
            try
            {
                return 1;

            }
            catch (Exception ex)
            {

                return 0;
            }

        }

        public static int GetRowCount(FlowLayoutPanel flowPanel)
        {
            int rows = flowPanel.Controls.Count;
            return rows;
        }

        public static string getProductName(string id)
        {
            using (var context = new MyDatabaseContext())
            {
                int a = int.Parse(id);
                var nameProduct = context.Products.Where(x=>x.Id == a).FirstOrDefault();
                return nameProduct.Name;
            }
        }

    }
}
