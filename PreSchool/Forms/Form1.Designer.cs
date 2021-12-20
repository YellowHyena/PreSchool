namespace PreSchool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelDeleteSubMenu = new System.Windows.Forms.Panel();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnDeleteGuardian = new System.Windows.Forms.Button();
            this.btnDeleteChild = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelEditSubMenu = new System.Windows.Forms.Panel();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnEditGuardian = new System.Windows.Forms.Button();
            this.btnEditChild = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panelAddSubMenu = new System.Windows.Forms.Panel();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnAddGuardian = new System.Windows.Forms.Button();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelShowSubMenu = new System.Windows.Forms.Panel();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnShowEmployed = new System.Windows.Forms.Button();
            this.btnShowGuardian = new System.Windows.Forms.Button();
            this.btnShowChild = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelDeleteSubMenu.SuspendLayout();
            this.panelEditSubMenu.SuspendLayout();
            this.panelAddSubMenu.SuspendLayout();
            this.panelShowSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.panelSideMenu.Controls.Add(this.panelDeleteSubMenu);
            this.panelSideMenu.Controls.Add(this.btnDelete);
            this.panelSideMenu.Controls.Add(this.panelEditSubMenu);
            this.panelSideMenu.Controls.Add(this.btnEdit);
            this.panelSideMenu.Controls.Add(this.panelAddSubMenu);
            this.panelSideMenu.Controls.Add(this.btnAdd);
            this.panelSideMenu.Controls.Add(this.panelShowSubMenu);
            this.panelSideMenu.Controls.Add(this.btnShow);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 603);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelDeleteSubMenu
            // 
            this.panelDeleteSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.panelDeleteSubMenu.Controls.Add(this.btnDeleteEmployee);
            this.panelDeleteSubMenu.Controls.Add(this.btnDeleteGuardian);
            this.panelDeleteSubMenu.Controls.Add(this.btnDeleteChild);
            this.panelDeleteSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDeleteSubMenu.Location = new System.Drawing.Point(0, 580);
            this.panelDeleteSubMenu.Name = "panelDeleteSubMenu";
            this.panelDeleteSubMenu.Size = new System.Drawing.Size(229, 120);
            this.panelDeleteSubMenu.TabIndex = 8;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteEmployee.FlatAppearance.BorderSize = 0;
            this.btnDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(0, 80);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDeleteEmployee.Size = new System.Drawing.Size(229, 40);
            this.btnDeleteEmployee.TabIndex = 2;
            this.btnDeleteEmployee.Text = "Anställda";
            this.btnDeleteEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnDeleteGuardian
            // 
            this.btnDeleteGuardian.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteGuardian.FlatAppearance.BorderSize = 0;
            this.btnDeleteGuardian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGuardian.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteGuardian.Location = new System.Drawing.Point(0, 40);
            this.btnDeleteGuardian.Name = "btnDeleteGuardian";
            this.btnDeleteGuardian.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDeleteGuardian.Size = new System.Drawing.Size(229, 40);
            this.btnDeleteGuardian.TabIndex = 1;
            this.btnDeleteGuardian.Text = "Vårdnadshavare";
            this.btnDeleteGuardian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteGuardian.UseVisualStyleBackColor = true;
            this.btnDeleteGuardian.Click += new System.EventHandler(this.btnDeleteGuardian_Click);
            // 
            // btnDeleteChild
            // 
            this.btnDeleteChild.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteChild.FlatAppearance.BorderSize = 0;
            this.btnDeleteChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteChild.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteChild.Location = new System.Drawing.Point(0, 0);
            this.btnDeleteChild.Name = "btnDeleteChild";
            this.btnDeleteChild.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDeleteChild.Size = new System.Drawing.Size(229, 40);
            this.btnDeleteChild.TabIndex = 0;
            this.btnDeleteChild.Text = "Barn";
            this.btnDeleteChild.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteChild.UseVisualStyleBackColor = true;
            this.btnDeleteChild.Click += new System.EventHandler(this.btnDeleteChild_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Location = new System.Drawing.Point(0, 535);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(229, 45);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Radera";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelEditSubMenu
            // 
            this.panelEditSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.panelEditSubMenu.Controls.Add(this.btnEditEmployee);
            this.panelEditSubMenu.Controls.Add(this.btnEditGuardian);
            this.panelEditSubMenu.Controls.Add(this.btnEditChild);
            this.panelEditSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEditSubMenu.Location = new System.Drawing.Point(0, 415);
            this.panelEditSubMenu.Name = "panelEditSubMenu";
            this.panelEditSubMenu.Size = new System.Drawing.Size(229, 120);
            this.panelEditSubMenu.TabIndex = 6;
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditEmployee.FlatAppearance.BorderSize = 0;
            this.btnEditEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEmployee.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditEmployee.Location = new System.Drawing.Point(0, 80);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEditEmployee.Size = new System.Drawing.Size(229, 40);
            this.btnEditEmployee.TabIndex = 2;
            this.btnEditEmployee.Text = "Anställda";
            this.btnEditEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnEditGuardian
            // 
            this.btnEditGuardian.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditGuardian.FlatAppearance.BorderSize = 0;
            this.btnEditGuardian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditGuardian.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditGuardian.Location = new System.Drawing.Point(0, 40);
            this.btnEditGuardian.Name = "btnEditGuardian";
            this.btnEditGuardian.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEditGuardian.Size = new System.Drawing.Size(229, 40);
            this.btnEditGuardian.TabIndex = 1;
            this.btnEditGuardian.Text = "Vårdnadshavare";
            this.btnEditGuardian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditGuardian.UseVisualStyleBackColor = true;
            this.btnEditGuardian.Click += new System.EventHandler(this.btnEditGuardian_Click);
            // 
            // btnEditChild
            // 
            this.btnEditChild.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditChild.FlatAppearance.BorderSize = 0;
            this.btnEditChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditChild.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditChild.Location = new System.Drawing.Point(0, 0);
            this.btnEditChild.Name = "btnEditChild";
            this.btnEditChild.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEditChild.Size = new System.Drawing.Size(229, 40);
            this.btnEditChild.TabIndex = 0;
            this.btnEditChild.Text = "Barn";
            this.btnEditChild.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditChild.UseVisualStyleBackColor = true;
            this.btnEditChild.Click += new System.EventHandler(this.btnEditChild_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEdit.Location = new System.Drawing.Point(0, 370);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEdit.Size = new System.Drawing.Size(229, 45);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Redigera";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panelAddSubMenu
            // 
            this.panelAddSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.panelAddSubMenu.Controls.Add(this.btnAddEmployee);
            this.panelAddSubMenu.Controls.Add(this.btnAddGuardian);
            this.panelAddSubMenu.Controls.Add(this.btnAddChild);
            this.panelAddSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddSubMenu.Location = new System.Drawing.Point(0, 250);
            this.panelAddSubMenu.Name = "panelAddSubMenu";
            this.panelAddSubMenu.Size = new System.Drawing.Size(229, 120);
            this.panelAddSubMenu.TabIndex = 4;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddEmployee.Location = new System.Drawing.Point(0, 80);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddEmployee.Size = new System.Drawing.Size(229, 40);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "Anställda";
            this.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnAddGuardian
            // 
            this.btnAddGuardian.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddGuardian.FlatAppearance.BorderSize = 0;
            this.btnAddGuardian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGuardian.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddGuardian.Location = new System.Drawing.Point(0, 40);
            this.btnAddGuardian.Name = "btnAddGuardian";
            this.btnAddGuardian.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddGuardian.Size = new System.Drawing.Size(229, 40);
            this.btnAddGuardian.TabIndex = 1;
            this.btnAddGuardian.Text = "Vårdnadshavare";
            this.btnAddGuardian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddGuardian.UseVisualStyleBackColor = true;
            this.btnAddGuardian.Click += new System.EventHandler(this.btnAddGuardian_Click);
            // 
            // btnAddChild
            // 
            this.btnAddChild.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddChild.FlatAppearance.BorderSize = 0;
            this.btnAddChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddChild.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddChild.Location = new System.Drawing.Point(0, 0);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddChild.Size = new System.Drawing.Size(229, 40);
            this.btnAddChild.TabIndex = 0;
            this.btnAddChild.Text = "Barn";
            this.btnAddChild.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Location = new System.Drawing.Point(0, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(229, 45);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Lägg till";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelShowSubMenu
            // 
            this.panelShowSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.panelShowSubMenu.Controls.Add(this.btnShowAll);
            this.panelShowSubMenu.Controls.Add(this.btnShowEmployed);
            this.panelShowSubMenu.Controls.Add(this.btnShowGuardian);
            this.panelShowSubMenu.Controls.Add(this.btnShowChild);
            this.panelShowSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShowSubMenu.Location = new System.Drawing.Point(0, 45);
            this.panelShowSubMenu.Name = "panelShowSubMenu";
            this.panelShowSubMenu.Size = new System.Drawing.Size(229, 160);
            this.panelShowSubMenu.TabIndex = 2;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShowAll.Location = new System.Drawing.Point(0, 120);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnShowAll.Size = new System.Drawing.Size(229, 40);
            this.btnShowAll.TabIndex = 3;
            this.btnShowAll.Text = "Alla";
            this.btnShowAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowGroup_Click);
            // 
            // btnShowEmployed
            // 
            this.btnShowEmployed.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowEmployed.FlatAppearance.BorderSize = 0;
            this.btnShowEmployed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowEmployed.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShowEmployed.Location = new System.Drawing.Point(0, 80);
            this.btnShowEmployed.Name = "btnShowEmployed";
            this.btnShowEmployed.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnShowEmployed.Size = new System.Drawing.Size(229, 40);
            this.btnShowEmployed.TabIndex = 2;
            this.btnShowEmployed.Text = "Anställda";
            this.btnShowEmployed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowEmployed.UseVisualStyleBackColor = true;
            this.btnShowEmployed.Click += new System.EventHandler(this.btnShowEmployed_Click);
            // 
            // btnShowGuardian
            // 
            this.btnShowGuardian.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowGuardian.FlatAppearance.BorderSize = 0;
            this.btnShowGuardian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowGuardian.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShowGuardian.Location = new System.Drawing.Point(0, 40);
            this.btnShowGuardian.Name = "btnShowGuardian";
            this.btnShowGuardian.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnShowGuardian.Size = new System.Drawing.Size(229, 40);
            this.btnShowGuardian.TabIndex = 1;
            this.btnShowGuardian.Text = "Vårdnadshavare";
            this.btnShowGuardian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowGuardian.UseVisualStyleBackColor = true;
            this.btnShowGuardian.Click += new System.EventHandler(this.btnShowGuardian_Click);
            // 
            // btnShowChild
            // 
            this.btnShowChild.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowChild.FlatAppearance.BorderSize = 0;
            this.btnShowChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowChild.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShowChild.Location = new System.Drawing.Point(0, 0);
            this.btnShowChild.Name = "btnShowChild";
            this.btnShowChild.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnShowChild.Size = new System.Drawing.Size(229, 40);
            this.btnShowChild.TabIndex = 0;
            this.btnShowChild.Text = "Barn";
            this.btnShowChild.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowChild.UseVisualStyleBackColor = true;
            this.btnShowChild.Click += new System.EventHandler(this.btnShowChild_Click);
            // 
            // btnShow
            // 
            this.btnShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShow.Location = new System.Drawing.Point(0, 0);
            this.btnShow.Name = "btnShow";
            this.btnShow.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnShow.Size = new System.Drawing.Size(229, 45);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Visa";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(250, 0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(782, 603);
            this.panelChild.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 603);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(1050, 650);
            this.Name = "Form1";
            this.Text = "FormMain";
            this.panelSideMenu.ResumeLayout(false);
            this.panelDeleteSubMenu.ResumeLayout(false);
            this.panelEditSubMenu.ResumeLayout(false);
            this.panelAddSubMenu.ResumeLayout(false);
            this.panelShowSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelAddSubMenu;
        private Button btnAddEmployee;
        private Button btnAddGuardian;
        private Button btnAddChild;
        private Button btnAdd;
        private Panel panelShowSubMenu;
        private Button btnShowAll;
        private Button btnShowEmployed;
        private Button btnShowGuardian;
        private Button btnShowChild;
        private Button btnShow;
        private Button btnEdit;
        private Panel panelDeleteSubMenu;
        private Button btnDeleteEmployee;
        private Button btnDeleteGuardian;
        private Button btnDeleteChild;
        private Button btnDelete;
        private Panel panelEditSubMenu;
        private Button btnEditEmployee;
        private Button btnEditGuardian;
        private Button btnEditChild;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panelChild;
    }
}