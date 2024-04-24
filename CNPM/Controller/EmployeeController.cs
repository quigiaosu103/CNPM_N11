using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using CNPM.Model;
using Microsoft.VisualBasic.ApplicationServices;
using static Guna.UI2.WinForms.Helpers.GraphicsHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using CNPM.Views;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Windows.Media.Animation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using FontAwesome.Sharp;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using static System.Windows.Forms.DataFormats;
using System.Globalization;
namespace CNPM.Controller
{
    public class EmployeeController
    {
        public void loadDataEmployee(DataGridView data)
        {
            using (var context = new MyDatabaseContext())
            {
                data.Rows.Clear();
                Employee employee = new Employee();
                var dataEmployee = context.Employees.ToList();
                
                foreach (var i in dataEmployee)
                {
                    var gender = "Nam";
                    if(i.Gender == 0)
                    {
                        gender = "Nam";
                    } else
                    {
                        gender = "Nữ";
                    }
                    data.Rows.Add(i.UserId,i.FullName, i.Address, i.PhoneNumber, i.Email, gender, i.BirthDay, i.IdCard, i.Position, i.Salary, i.WorkingTime, i.ApplyDate);
                }
                data.AllowUserToAddRows = false;
                data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }

        public static void InitEmployee(Employee data)
        {
            EmployeeInfor.dataEmployee = new Model.Employee
            {

                UserId = data.UserId,
                FullName = data.FullName,
                Address = data.Address,
                PhoneNumber = data.PhoneNumber,
                Gender = data.Gender,
                BirthDay = data.BirthDay,
                Email = data.Email,
                IdCard = data.IdCard,
                Position = data.Position,
                WorkingTime = data.WorkingTime,
                Salary = data.Salary,
                ApplyDate = data.ApplyDate,
            };

        }

        public static string findIdEmployee(string fullName, string idCard)
        {
            using (var context = new MyDatabaseContext())
            {
                var newEmployee = context.Employees.FirstOrDefault(e => e.FullName == fullName && e.IdCard == idCard); ;
                return newEmployee.UserId;
            }
        }

        public static void updateEmployee(Employee data)
        {
            using (var context = new MyDatabaseContext())
            {
                var newEmployee = context.Employees.Find(data.UserId); ;
                if (newEmployee != null)
                {
                    newEmployee.FullName = data.FullName;
                    newEmployee.IdCard = data.IdCard;
                    newEmployee.Position = data.Position;
                    newEmployee.Salary = data.Salary;
                    newEmployee.ApplyDate = data.ApplyDate;
                    newEmployee.WorkingTime = data.WorkingTime;
                    newEmployee.Position = data.Position;
                    newEmployee.Email = data.Email;
                    newEmployee.BirthDay = data.BirthDay;
                    newEmployee.Gender = data.Gender;
                    newEmployee.PhoneNumber = data.PhoneNumber;
                    newEmployee.Address = data.Address;
                    int numEntitiesAdded = context.SaveChanges();
                    if (numEntitiesAdded > 0)
                    {
                        new CustomMessageBox("Cập nhật thông tin thành công", "Cập nhật thành công").ShowDialog();
                    }
                    else
                    {
                        new CustomMessageBox("Cập nhật thông tin thất bại", "Cập nhật không thành công").ShowDialog();
                    }
                }

            }
        }

        //public static void addEmployee(Employee data)
        //{
        //    using (var context = new MyDatabaseContext())
        //    {

        //        var findId = context.Employees.Select(x => x.UserId).ToList();
        //        int maxNumber = findId.Select(int.Parse).Max() + 1;
                
        //        Employee newEmployees = new Employee();
        //        newEmployees.UserId = maxNumber.ToString();
        //        newEmployees.FullName = data.FullName;
        //        newEmployees.IdCard = data.IdCard;
        //        newEmployees.Salary = data.Salary;
        //        newEmployees.ApplyDate = data.ApplyDate;
        //        newEmployees.WorkingTime = data.WorkingTime;
        //        newEmployees.Position = data.Position;
        //        newEmployees.Email = data.Email;
        //        newEmployees.BirthDay = data.BirthDay;
        //        newEmployees.Gender = data.Gender;
        //        newEmployees.Address = data.Address;
        //        newEmployees.PhoneNumber = data.PhoneNumber;
        //        context.Employees.Add(newEmployees);
        //        int numEntitiesAdded = context.SaveChanges();
        //        if (numEntitiesAdded > 0)
        //        {
        //            new CustomMessageBox("Thêm nhân viên thành công", "Thêm thành công").ShowDialog();
        //        }
        //        else
        //        {
        //            new CustomMessageBox("Thêm nhân viên thất bại", "Thêm không thành công").ShowDialog();
        //        }


        //    }
        //}

        public static void getData(Employee data)
        {
            if (data != null) 
            {

            }
        }
        public static void loadDataCombobox(Guna2ComboBox cb)
        {
            //using (var context = new MyDatabaseContext())
            //{
            //    var data = context.Employees;
            //    var a  = 
            //}

        }

        public static void addEmployeeAccount(Account data)
        {
            using (var context = new MyDatabaseContext())
            {
              
                var findUserId = context.Users.Where(x=>x.UserId == data.UserName);
                if (findUserId != null)
                {
                    var user = new Model.Employee()
                    {
                        UserId = data.UserName,
                        FullName = "",
                        Address = "",
                        PhoneNumber = "",
                        Gender = 0,
                        BirthDay = DateTime.Now


                    };
                    var account = new Account
                    {
                        UserName = data.UserName,
                        HashedPassword = MyLib.hashPassword("123"),
                        Email = data.Email,
                        AvatarUrl = "",
                        Role = "employee",
                        User = user
                    };
                    context.Account.Add(account);
                    int numEntitiesAdded = context.SaveChanges();
                    if (numEntitiesAdded > 0)
                    {
                        new CustomMessageBox("Thêm nhân viên thành công", "Thêm thành công").ShowDialog();
                    }
                    else
                    {
                        new CustomMessageBox("Thêm nhân viên thất bại", "Thêm không thành công").ShowDialog();
                    }
                } else
                {
                    new CustomMessageBox("Tên người dùng đã được sử dụng", "Thêm không thành công").ShowDialog();
                }
               
            }
        }

        public static List<Employee> searchEmployee(string name, string col)
        {
            using (var context = new MyDatabaseContext())
            {
                //if (col == "Mọi thông tin")
                //{
                //    var dataEmployee = context.Employees.Find(name);

                //    //return dataEmployee;
                //}
                //else
                //{
                if(col == "Tài khoản")
                {
                    var dataEmployee = context.Employees.Where(x => x.UserId.Contains(name)).ToList();
                    return dataEmployee;
                } else if(col == "Họ tên")
                {
                    var dataEmployee = context.Employees.Where(x => x.FullName.Contains(name)).ToList();
                    return dataEmployee;
                }
                else if (col == "Địa chỉ")
                {
                    var dataEmployee = context.Employees.Where(x => x.Address.Contains(name)).ToList();
                    return dataEmployee;
                }
                else if (col == "Số điện thoại")
                {
                    var dataEmployee = context.Employees.Where(x => x.PhoneNumber.Contains(name)).ToList();
                    return dataEmployee;
                }
                else if (col == "Email")
                {
                    var dataEmployee = context.Employees.Where(x => x.Email.Contains(name)).ToList();
                    return dataEmployee;
                }
                else if (col == "Cmnd")
                {
                    var dataEmployee = context.Employees.Where(x => x.IdCard.Contains(name)).ToList();
                    return dataEmployee;
                }
                else if (col == "Vị trí")
                {
                    var searchPosition = name.ToUpper();
                    if (searchPosition == "NHAN VIEN")
                    {
                        searchPosition = "NHÂN VIÊN";
                    } 
                    if (searchPosition == "QUAN LY")
                    {
                        searchPosition = "QUẢN LÝ";
                    }
                    var dataEmployee = context.Employees.Where(x => x.Position.Contains(searchPosition)).ToList();
                    return dataEmployee;
                }
                else if (col == "Lương")
                {
                    long value = long.Parse(name);
                    var dataEmployee = context.Employees.Where(x => x.Salary == value).ToList();
                    return dataEmployee;
                }
                else if (col == "Ca làm")
                {
                    var dataEmployee = context.Employees.Where(x => x.WorkingTime == name).ToList();
                    return dataEmployee;
                }
                else if (col == "Ngày vào làm")
                {
                    var dataEmployee = context.Employees.Where(x => x.ApplyDate == name).ToList();
                    return dataEmployee;
                }
                else if (col == "Ngày sinh")
                {
                    return checkBirthday(name);
                }
                else if (col == "Giới tính")
                {
                    var searchGender = name.ToUpper();
                    int searchKey = 0;
                    if(searchGender == "NAM")
                    {
                        searchKey = 0;
                    } else
                    {
                        searchKey = 1;
                    }
                    var dataEmployee = context.Employees.Where(x => x.Gender == searchKey).ToList();
                    return dataEmployee;
                }

                //var employee = context.Employees.Where(x => x.FullName == name).FirstOrDefault();
                //    }
                return null;

            }

        }
        //public static DateTime checkInputDatetime(string datatime)
        //{
        //    string pattern = @"^([0-9]|[0-9]{2})/([0-9]|[0-9][0-9]|[0-9][0-9]{3})$";
        //    bool isMatch = Regex.IsMatch(datatime, pattern);
        //    if(isMatch == true)
        //    {
        //        if(datatime.Length <= 5)
        //        {
        //            DateTime newDateTime;
        //            //if (DateTime.TryParseExact(datatime, "dd/mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out newDateTime) 
        //            //    || DateTime.TryParseExact(datatime, "d/mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out newDateTime)
        //            //    || DateTime.TryParseExact(datatime, "d/m", CultureInfo.InvariantCulture, DateTimeStyles.None, out newDateTime))
        //            if( 
        //            DateTime.TryParseExact(datatime, "dd/M", CultureInfo.InvariantCulture, DateTimeStyles.None, out newDateTime)
        //          )
        //            {
        //                MessageBox.Show(DateTime.ParseExact(datatime, "dd/M", CultureInfo.InvariantCulture, DateTimeStyles.None).ToString());
        //                return newDateTime;
        //            }
        //            else
        //            {
        //                new CustomMessageBox("Vui lòng kiểm tra lại thông tin muốn tìm kiếm", "Thông tin nhập sai").ShowDialog();
        //                return DateTime.Now;
        //            }

        //        }
        //        if(datatime.Length <= 6) 
        //        {
        //            DateTime newDateTime;
        //            if (DateTime.TryParseExact(datatime, "mm/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out newDateTime))
        //            {
        //                return newDateTime;
        //            }
        //            else
        //            {
        //                new CustomMessageBox("Vui lòng kiểm tra lại thông tin muốn tìm kiếm", "Thông tin nhập sai").ShowDialog();
        //                return DateTime.Now;

        //            }
        //        }
        //    }
        //    return DateTime.Now;
       

        //}
        public static List<Employee> checkBirthday(string name)
        {
            using (var context = new MyDatabaseContext())
            {
                try
                {
                    if (name.Length == 4)
                    {
                        DateTime dateTime = DateTime.ParseExact(name, "yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        var dataEmployeeYear = context.Employees.Where(x => x.BirthDay.Year == dateTime.Year).ToList();
                        return dataEmployeeYear;
                    }

                    if (name.Length <= 2)
                    {
                        int monthOrDay = int.Parse(name);
                        DateTime dateTimeDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, monthOrDay);
                        DateTime dateTimeMonth = new DateTime(DateTime.Now.Year, monthOrDay, 1);
                        var dataEmployeeDayMonth = context.Employees.Where(x => x.BirthDay.Day == dateTimeDay.Day || x.BirthDay.Month == dateTimeMonth.Month).ToList();
                        return dataEmployeeDayMonth;
                    }
                    DateTime searchDay = DateTime.Parse(name);
                    var dataEmployee = context.Employees.Where(x => x.BirthDay == searchDay).ToList();
                    return dataEmployee;
                } 
                catch
                {
                    new CustomMessageBox("Vui lòng kiểm tra lại thông tin muốn tìm kiếm", "Thông tin nhập sai").ShowDialog();
                    return null;
                }      
            }
            return null;
        }
        public static void loadDataEmployeeSearch(DataGridView data, List<Employee> dataEmployee)
        {
            data.Rows.Clear();
            foreach(Employee emp in dataEmployee)
            {
                var gender = "Nam";
                if (emp.Gender == 0)
                {
                    gender = "Nam";
                }
                else
                {
                    gender = "Nữ";
                }
                data.Rows.Add(emp.UserId, emp.FullName, emp.Address, emp.PhoneNumber, emp.Email, gender, emp.BirthDay, emp.IdCard, emp.Position, emp.Salary, emp.WorkingTime, emp.ApplyDate);
            }
            data.AllowUserToAddRows = false;
            data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}

                
               
              