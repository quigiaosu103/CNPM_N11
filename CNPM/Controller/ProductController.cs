using CNPM.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM.Controller
{
    public class ProductController
    {

        public static void removeProduct(string productId)
        {
            using (var context = new MyDatabaseContext())
            {
                Product product = context.Products.Find(Int32.Parse(productId));
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }

        public static void storeProduct(Product product)
        {
            using (var context = new MyDatabaseContext())
            {
                Category newCategory = context.Categories.Find(product.category.Id);
                product.category = newCategory;
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public static void updateProduct(Product product)
        {
            using (var context = new MyDatabaseContext())
            {
                Product oldProduct = context.Products.Include(b => b.category).SingleOrDefault(pr => pr.Id == product.Id);
                Category newCategory = context.Categories.Find(product.category.Id);
                oldProduct.Name = product.Name;
                oldProduct.Description = product.Description;
                oldProduct.Price = product.Price;
                //oldProduct.category = newCategory;
                if (product.ImageUrl != "")
                {
                    oldProduct.ImageUrl = product.ImageUrl;
                }
                context.Products.Update(oldProduct);
                context.SaveChanges();
            }
        }

        public static int GetNewProductId()
        {
            using (var context = new MyDatabaseContext())
            {
                int dateNumber = Int32.Parse(DateTime.Now.ToString("ddHHmmss"));
                return context.Products.Count() + 1 + dateNumber;
            }
        }
    }
}
