using PreSchool.CRUD;
using PreSchool.Database;
using PreSchool.Models;

namespace PreSchool
{
    public partial class FormAddChild : Form
    {
        public FormAddChild()
        {
            InitializeComponent();
        }
        private void FormAddChild_Load(object sender, EventArgs e)
        {
            using (var db = new SchoolContext()) //Adds the existing groups to combobox dropdown
            {
                foreach (var group in db.Groups)
                {
                    groupComboBox.Items.Add(group.Name);
                }
            }
        }

        private void perNumBox_TextChanged(object sender, EventArgs e) //Checks if personal number has a letter in it. NOTE: MAYBE ADD MAXIMUM AND MINIMUM LENGTH?
        {
            bool number = long.TryParse(perNumBox.Text, out long perNum);
            if (number == true || perNumBox.Text == "") perNumHelpLabel.Visible = false;
            else perNumHelpLabel.Visible = true;
        }


        public Dummy ChildInfo() //I don't have to check for and/or create guardians or groups when using dummy, its just information
        {

            var tempChild = new Dummy
            {
                FirstName = nameBox.Text,
                LastName = lastNameBox.Text,
                PersonalNumber = long.Parse(perNumBox.Text),
                StartDate = startDatePicker.Value,
                EndDate = endDatePicker.Value,
                ApplicationDate = applicationDatePicker.Value,
                PublicPreSchool = publicCheckBox.Checked,
                FifteenHours = fifteenHCheckBox.Checked,
                Group = groupComboBox.Text,
                Guardian1 = guardianComboBox.Text,
                Guardian2 = guardianComboBox2.Text
            };
            if (radBtnBillRecipent.Checked == true) tempChild.BillRecipent = tempChild.Guardian1;
            else if (radBtnBillRecipent2.Checked == true) tempChild.BillRecipent = tempChild.Guardian2;

            return tempChild;
        }

        private void addChildButton_Click(object sender, EventArgs e)
        {
            Create.Child(ChildInfo());
        }

        //Updates the dropdown of combobox to include guardian suggestions based on last name, in case the same guardian has 2 children.
        //Given the guadian exists in the database ofc
        private void lastNameBox_Leave(object sender, EventArgs e) 
        {
            using (var db = new SchoolContext())
            {
                string input = lastNameBox.Text;
                var list = db.Guardians.Where(g => g.LastName.Contains(input));
                if (list == null) return;
                foreach (var guardian in list)
                {
                    guardianComboBox.Items.Add(guardian.FirstName + " " + guardian.LastName);
                    guardianComboBox2.Items.Add(guardian.FirstName + " " + guardian.LastName);
                }
            }
        }
    }
}
