using PreSchool.Database;
using PreSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreSchool.CRUD
{
    internal class Delete
    {
        public static void Child(Child child)
        {
            using var db = new SchoolContext();
            db.Children.Remove(child);
            db.SaveChanges();
        }
        public static void Guardian(Guardian guardian)
        {
            using var db = new SchoolContext();
            db.Guardians.Remove(guardian);
            db.SaveChanges();
        }
        public static void Employee(Employee employee)
        {
            using var db = new SchoolContext();
            db.Employees.Remove(employee);
            db.SaveChanges();
        }
    }
}
