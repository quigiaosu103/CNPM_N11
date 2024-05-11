using CNPM.Views;
using DangKi__DangNhap__QuenMatKhau;

namespace CNPM
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Form login = new form_DangNhap();
            
            if(login.ShowDialog() == DialogResult.OK)
            {
             
                Application.Run(new frMain());
               
            }
            
        }
    }
}