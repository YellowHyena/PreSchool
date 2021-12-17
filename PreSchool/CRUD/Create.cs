using PreSchool.Database;
using PreSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreSchool.CRUD
{
    internal class Create
    {
        public static void Child()
        {
            using var db = new SchoolContext();
            var child = db.Children.FirstOrDefault(s => s.PersonalNumber == input.PersonalNumber);
            if (child == null)
            {
                db.Children.Add(new Child
                {
                    FirstName = Form1.nameBox.Text,
                    LastName = input.LastName,
                    PersonalNumber = input.PersonalNumber,
                    PublicPreSchool =input.PublicPreSchool,
                    FifteenHours = input.FifteenHours,
                    StartDate = input.StartDate,
                    EndDate = input.EndDate,
                    BillRecipent = input.BillRecipent,
                    ApplicationDate = input.ApplicationDate


                    string name = nameBox.Text;
                string lastName = lastNameBox.Text;
                int perNum = int.Parse(perNumBox.Text);
                string group = groupComboBox.Text;
                DateTime start = startDatePicker.Value;
                DateTime end = endDatePicker.Value;
                DateTime apply = applicationDatePicker.Value;
                bool


    });
                db.SaveChanges();
            }
        }
    }
}
