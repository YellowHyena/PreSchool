using Microsoft.EntityFrameworkCore;
using PreSchool.Database;
using PreSchool.Models;

namespace PreSchool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new SchoolContext())
            {
                db.Children.Add(new Child
                {
                    FirstName = "Peter",
                    LastName = "Parker",

                });
               

                db.Adults.Add(new Adult
                {
                    FirstName = "Richard",
                    LastName= "Parker",                
                });
                db.SaveChanges();



                var ric = db.Adults.Include("Children").FirstOrDefault(s => s.FirstName == "Richard");
                if (ric.Children == null) ric.Children = new List<Child>();

                var peter = db.Children.FirstOrDefault(p => p.FirstName == "Peter");
                if (peter != null) ric.Children.Add(peter);

                db.SaveChanges();

                label1.Text = ric.Children[0].FirstName;
            }

            
        }
    }
}