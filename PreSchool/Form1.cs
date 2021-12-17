namespace PreSchool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void perNumBox_TextChanged(object sender, EventArgs e)
        {
            int perNum;
            bool number = int.TryParse(perNumBox.Text, out perNum);
            if (number == true || perNumBox.Text == "") perNumHelpLabel.Visible = false;
            else perNumHelpLabel.Visible = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void addChildButton_Click_1(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string lastName = lastNameBox.Text;
            int perNum = int.Parse(perNumBox.Text);
            string group = groupComboBox.Text;
            DateTime start = startDatePicker.Value;
            DateTime end = endDatePicker.Value;
            DateTime apply = applicationDatePicker.Value;
            bool
            CRUD.Create.Child();
        }
    }
}