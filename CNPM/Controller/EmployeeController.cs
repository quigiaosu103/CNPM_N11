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
namespace CNPM.Controller
{
    public class EmployeeController
    {
        public void loadDataEmployee(DataGridView data)
        {
            using (var context = new MyDatabaseContext())
            {
                Employee employee = new Employee();
                var dataEmployee = context.Employees.ToList();

                foreach (var i in dataEmployee)
                {
                    data.Rows.Add(i.UserId,i.FullName, i.Address, i.PhoneNumber, i.Email, i.Gender, i.BirthDay, i.IdCard, i.Position, i.Salary, i.WorkingTime, i.ApplyDate);
                }
                data.AllowUserToAddRows = false;
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

        public static void addEmployee(Employee data)
        {
            using (var context = new MyDatabaseContext())
            {
                var findId = context.Employees.Select(x => x.UserId).ToList();
                int maxNumber = findId.Select(int.Parse).Max() + 1;
                Employee newEmployees = new Employee();
                newEmployees.UserId = maxNumber.ToString();
                newEmployees.FullName = data.FullName;
                newEmployees.IdCard = data.IdCard;
                newEmployees.Salary = data.Salary;
                newEmployees.ApplyDate = data.ApplyDate;
                newEmployees.WorkingTime = data.WorkingTime;
                newEmployees.Position = data.Position;
                newEmployees.Email = data.Email;
                newEmployees.BirthDay = data.BirthDay;
                newEmployees.Gender = data.Gender;
                newEmployees.Address = data.Address;
                newEmployees.PhoneNumber = data.PhoneNumber;
                context.Employees.Add(newEmployees);
                int numEntitiesAdded = context.SaveChanges();
                if (numEntitiesAdded > 0)
                {
                    new CustomMessageBox("Thêm nhiên viên thành công", "Thêm thành công").ShowDialog();
                }
                else
                {
                    new CustomMessageBox("Thêm nhân viên thất bại", "Thêm không thành công").ShowDialog();
                }


            }
        }

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


    }
}

                
               
              