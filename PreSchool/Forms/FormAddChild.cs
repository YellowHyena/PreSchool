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


        public Dummy ChildInfo() //Using dummy to indicate that this is just information and not a person
        {

            var tempChild = new Dummy
            {
                FirstName = nameBox.Text,
                LastName = lastNameBox.Text,
                PersonalNumber = long.Parse(perNumBox.Text),
                StartDate = startDatePicker.Value,
                EndDate = endDatePicker.Value,
                ApplicationDate = applicationDatePicker.Value,
                Group = groupComboBox.Text
            };

            return tempChild;
        }

        private void addChildButton_Click(object sender, EventArgs e)
        {
            Create.Child(ChildInfo());
        }           
    }
}
