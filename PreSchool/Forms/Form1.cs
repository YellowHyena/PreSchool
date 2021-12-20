namespace PreSchool
{
    public partial class Form1 : Form
    {
        //Based on https://www.youtube.com/watch?v=JP5rgXO_5Sk
        public Form1()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        private void CustomizeDesign()
        {
            panelShowSubMenu.Visible = false;
            panelAddSubMenu.Visible = false;
            panelEditSubMenu.Visible = false;
            panelDeleteSubMenu.Visible = false;
        }
        private void HideSubMenu()
        {
            panelShowSubMenu.Visible = false;
            panelAddSubMenu.Visible = false;
            panelEditSubMenu.Visible = false;
            panelDeleteSubMenu.Visible = false;
        }

            private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }

        #region ShowMenu
        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelShowSubMenu);
        }

        private void btnShowChild_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnShowGuardian_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnShowEmployed_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormViewAll());
            HideSubMenu();
        }
        #endregion

        #region AddMenu
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelAddSubMenu);
        }
        private void btnAddChildForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAddChild());
            HideSubMenu();
        }

        private void btnAddGuardian_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        #endregion

        #region EditMenu
        private void btnEdit_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelEditSubMenu);
        }

        private void btnEditChild_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnEditGuardian_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion

        #region DeleteMenu
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelDeleteSubMenu);
        }

        private void btnDeleteChild_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnDeleteGuardian_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.Show();
        }


    }
}