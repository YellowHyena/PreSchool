using PreSchool.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            using var db = new SchoolContext();

            string name = "";
            foreach (var child in db.Children)
            {
                name = child.FirstName + " " + child.LastName;
                listBox1.Items.Add(name);
            }

            string groupName = "";
            foreach (var group in db.Groups)
            {
                name = group.Name;
                listBox1.Items.Add(name);
            }

        }
    }
}
