using CNPM.Controller;
using CNPM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM.Model
{
    public class Cart
    {
        //MyDatabaseContext db = new MyDatabaseContext(); 
        //private Cart() { }
        //private static Cart uniqueInstance;

        //public static Cart getInstance
        //{
        //    get {
        //        if (uniqueInstance == null)
        //            uniqueInstance = new Cart();
        //        return uniqueInstance;
        //    }
        //    set =>getInstance = value;
        //}

        public string nameSanPham { get; set; }

        public int soLuong { get; set; }
        public int total { get; set; }

        //public Cart(string nameSanPham, int soLuong, int total)
        //{
        //    this.nameSanPham = nameSanPham;
        //    this.soLuong = soLuong;
        //    this.total = total;
        //}
        public List<Cart> Lines { get; set; } = new List<Cart>();
        public decimal ComputeTotalValues()
        {
            return (decimal)Lines.Sum(p => p.total * p.soLuong);
        }



    }



    //public class CartLine
    //{
    //    public string nameSanPham { get; set; }

    //    public int soLuong { get; set; }
    //    public int total { get; set; }

    //    public CartLine(string nameSanPham, int soLuong, int total)
    //    {
    //        this.nameSanPham = nameSanPham;
    //        this.soLuong = soLuong;
    //        this.total = total;
    //    }   

        
    //}
}
