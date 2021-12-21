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

namespace PreSchool.Forms
{
    public partial class FormAddGuardian : Form
    {
        public FormAddGuardian()
        {
            InitializeComponent();
        }

        private void FormAddGuardian_Load(object sender, EventArgs e)
        {
            using (var db = new SchoolContext())
            {
                foreach (var child in db.Children)
                {
                    comboBoxGuardFor.Items.Add(child.FirstName + " " + child.LastName);
                }
            }
        }
    }
}
