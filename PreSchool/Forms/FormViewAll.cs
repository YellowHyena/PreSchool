﻿using Microsoft.EntityFrameworkCore;
using PreSchool.Database;

namespace PreSchool
{
    public partial class FormViewAll : Form
    {
        public FormViewAll()
        {
            InitializeComponent();
        }

        private void FormViewAll_Load(object sender, EventArgs e)
        {
            using (var db = new SchoolContext())
            {
                foreach (var group in db.Groups) //Adds groups to combobox
                {
                    comboBoxFilterGroup.Items.Add(group.Name);
                }

                string name = "";
                foreach (var child in db.Children)
                {
                    name = child.FirstName + " " + child.LastName;
                    listBox1.Items.Add(name);
                }
            }
        }

        private void checkBoxFilterGroup_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxFilterGroup.Enabled = checkBoxFilterGroup.Checked;
            //if (checkBoxFilterGroup.Checked==false)
        }

        private void comboBoxFilterGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowPeopleInSelectedGroup();
        }

        private void ShowPeopleInSelectedGroup()
        {
            using var db = new SchoolContext();

            //Child
            var groupName = db.Groups.FirstOrDefault(g => g.Name == comboBoxFilterGroup.Text);

            listBox1.Items.Clear();

            var childGroup = db.Children.Include("Groups").Where(g => g.Groups.Contains(groupName)); //Gets children

            foreach (var child in childGroup) //Shows children
            {
                string name = child.FirstName + " " + child.LastName;
                listBox1.Items.Add(name);
            }

            //Employee
            var employeeGroup = db.Employees.Include("Groups").Where(g => g.Groups.Contains(groupName)); //Gets employees

            listBox2.Items.Clear();

            foreach (var employee in employeeGroup) //Shows employees
            {
                string name = employee.FirstName + " " + employee.LastName;
                listBox2.Items.Add(name);
            }

            //Add parents whos child belongs to selected group!
        }
    }
}
