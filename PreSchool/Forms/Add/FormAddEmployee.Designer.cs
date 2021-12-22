namespace PreSchool.Forms
{
    partial class FormAddEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPhoneCheck = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.perNumHelpLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.perNumBox = new System.Windows.Forms.TextBox();
            this.perNumLabel = new System.Windows.Forms.Label();
            this.datePickerEmploymentDate = new System.Windows.Forms.DateTimePicker();
            this.startLabel = new System.Windows.Forms.Label();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPhoneCheck
            // 
            this.labelPhoneCheck.AutoSize = true;
            this.labelPhoneCheck.Location = new System.Drawing.Point(469, 242);
            this.labelPhoneCheck.Name = "labelPhoneCheck";
            this.labelPhoneCheck.Size = new System.Drawing.Size(112, 20);
            this.labelPhoneCheck.TabIndex = 81;
            this.labelPhoneCheck.Text = "Enbart siffror!";
            this.labelPhoneCheck.Visible = false;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(248, 239);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(211, 27);
            this.textBoxPhone.TabIndex = 79;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(74, 246);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(125, 20);
            this.labelPhone.TabIndex = 80;
            this.labelPhone.Text = "Telefonnummer";
            // 
            // perNumHelpLabel
            // 
            this.perNumHelpLabel.AutoSize = true;
            this.perNumHelpLabel.Location = new System.Drawing.Point(469, 197);
            this.perNumHelpLabel.Name = "perNumHelpLabel";
            this.perNumHelpLabel.Size = new System.Drawing.Size(112, 20);
            this.perNumHelpLabel.TabIndex = 78;
            this.perNumHelpLabel.Text = "Enbart siffror!";
            this.perNumHelpLabel.Visible = false;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(248, 99);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(211, 27);
            this.nameBox.TabIndex = 72;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(155, 99);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 20);
            this.nameLabel.TabIndex = 73;
            this.nameLabel.Text = "Namn";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(248, 146);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(211, 27);
            this.lastNameBox.TabIndex = 74;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(116, 153);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.lastNameLabel.TabIndex = 75;
            this.lastNameLabel.Text = "Efternamn";
            // 
            // perNumBox
            // 
            this.perNumBox.Location = new System.Drawing.Point(248, 194);
            this.perNumBox.Name = "perNumBox";
            this.perNumBox.Size = new System.Drawing.Size(211, 27);
            this.perNumBox.TabIndex = 76;
            // 
            // perNumLabel
            // 
            this.perNumLabel.AutoSize = true;
            this.perNumLabel.Location = new System.Drawing.Point(74, 201);
            this.perNumLabel.Name = "perNumLabel";
            this.perNumLabel.Size = new System.Drawing.Size(123, 20);
            this.perNumLabel.TabIndex = 77;
            this.perNumLabel.Text = "Personnummer";
            // 
            // datePickerEmploymentDate
            // 
            this.datePickerEmploymentDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datePickerEmploymentDate.Location = new System.Drawing.Point(248, 288);
            this.datePickerEmploymentDate.Name = "datePickerEmploymentDate";
            this.datePickerEmploymentDate.Size = new System.Drawing.Size(211, 27);
            this.datePickerEmploymentDate.TabIndex = 82;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(51, 293);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(146, 20);
            this.startLabel.TabIndex = 83;
            this.startLabel.Text = "Anställningsdatum";
            // 
            // groupComboBox
            // 
            this.groupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(249, 332);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(210, 28);
            this.groupComboBox.TabIndex = 85;
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(134, 335);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(81, 20);
            this.groupLabel.TabIndex = 84;
            this.groupLabel.Text = "Avdelning";
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addEmployeeButton.Location = new System.Drawing.Point(249, 414);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(118, 29);
            this.addEmployeeButton.TabIndex = 86;
            this.addEmployeeButton.Text = "Add";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // FormAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.datePickerEmploymentDate);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.labelPhoneCheck);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.perNumHelpLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.perNumBox);
            this.Controls.Add(this.perNumLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormAddEmployee";
            this.Text = "FormAddEmployee";
            this.Load += new System.EventHandler(this.FormAddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelPhoneCheck;
        private TextBox textBoxPhone;
        private Label labelPhone;
        private Label perNumHelpLabel;
        private TextBox nameBox;
        private Label nameLabel;
        private TextBox lastNameBox;
        private Label lastNameLabel;
        private TextBox perNumBox;
        private Label perNumLabel;
        private DateTimePicker datePickerEmploymentDate;
        private Label startLabel;
        private ComboBox groupComboBox;
        private Label groupLabel;
        private Button addEmployeeButton;
    }
}