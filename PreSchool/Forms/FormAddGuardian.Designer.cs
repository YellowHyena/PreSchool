namespace PreSchool.Forms
{
    partial class FormAddGuardian
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
            this.perNumHelpLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addChildButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.perNumBox = new System.Windows.Forms.TextBox();
            this.perNumLabel = new System.Windows.Forms.Label();
            this.comboBoxGuardFor = new System.Windows.Forms.ComboBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.applicationLabel = new System.Windows.Forms.Label();
            this.applicationDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // perNumHelpLabel
            // 
            this.perNumHelpLabel.AutoSize = true;
            this.perNumHelpLabel.Location = new System.Drawing.Point(427, 214);
            this.perNumHelpLabel.Name = "perNumHelpLabel";
            this.perNumHelpLabel.Size = new System.Drawing.Size(99, 20);
            this.perNumHelpLabel.TabIndex = 68;
            this.perNumHelpLabel.Text = "Enbart siffror!";
            this.perNumHelpLabel.Visible = false;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(250, 116);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(169, 27);
            this.nameBox.TabIndex = 47;
            // 
            // addChildButton
            // 
            this.addChildButton.Location = new System.Drawing.Point(191, 523);
            this.addChildButton.Name = "addChildButton";
            this.addChildButton.Size = new System.Drawing.Size(106, 32);
            this.addChildButton.TabIndex = 67;
            this.addChildButton.Text = "Add";
            this.addChildButton.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(177, 116);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 20);
            this.nameLabel.TabIndex = 48;
            this.nameLabel.Text = "Namn";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(250, 163);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(169, 27);
            this.lastNameBox.TabIndex = 49;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(146, 170);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(77, 20);
            this.lastNameLabel.TabIndex = 50;
            this.lastNameLabel.Text = "Efternamn";
            // 
            // perNumBox
            // 
            this.perNumBox.Location = new System.Drawing.Point(250, 211);
            this.perNumBox.Name = "perNumBox";
            this.perNumBox.Size = new System.Drawing.Size(169, 27);
            this.perNumBox.TabIndex = 51;
            // 
            // perNumLabel
            // 
            this.perNumLabel.AutoSize = true;
            this.perNumLabel.Location = new System.Drawing.Point(112, 218);
            this.perNumLabel.Name = "perNumLabel";
            this.perNumLabel.Size = new System.Drawing.Size(107, 20);
            this.perNumLabel.TabIndex = 52;
            this.perNumLabel.Text = "Personnummer";
            // 
            // comboBoxGuardFor
            // 
            this.comboBoxGuardFor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGuardFor.FormattingEnabled = true;
            this.comboBoxGuardFor.Location = new System.Drawing.Point(250, 55);
            this.comboBoxGuardFor.Name = "comboBoxGuardFor";
            this.comboBoxGuardFor.Size = new System.Drawing.Size(169, 28);
            this.comboBoxGuardFor.TabIndex = 62;
            this.comboBoxGuardFor.TextUpdate += new System.EventHandler(this.comboBoxGuardFor_TextUpdate);
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(82, 58);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(137, 20);
            this.groupLabel.TabIndex = 53;
            this.groupLabel.Text = "Vårdnadshavare för";
            // 
            // applicationLabel
            // 
            this.applicationLabel.AutoSize = true;
            this.applicationLabel.Location = new System.Drawing.Point(101, 436);
            this.applicationLabel.Name = "applicationLabel";
            this.applicationLabel.Size = new System.Drawing.Size(127, 20);
            this.applicationLabel.TabIndex = 61;
            this.applicationLabel.Text = "Ansökningsdatum";
            // 
            // applicationDatePicker
            // 
            this.applicationDatePicker.Location = new System.Drawing.Point(250, 428);
            this.applicationDatePicker.Name = "applicationDatePicker";
            this.applicationDatePicker.Size = new System.Drawing.Size(281, 27);
            this.applicationDatePicker.TabIndex = 60;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(250, 335);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(281, 27);
            this.startDatePicker.TabIndex = 56;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(146, 387);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(77, 20);
            this.endLabel.TabIndex = 59;
            this.endLabel.Text = "Slutdatum";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(146, 341);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(83, 20);
            this.startLabel.TabIndex = 57;
            this.startLabel.Text = "Startdatum";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(250, 381);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(281, 27);
            this.endDatePicker.TabIndex = 58;
            // 
            // FormAddGuardian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.perNumHelpLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.addChildButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.perNumBox);
            this.Controls.Add(this.perNumLabel);
            this.Controls.Add(this.comboBoxGuardFor);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.applicationLabel);
            this.Controls.Add(this.applicationDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.endDatePicker);
            this.Name = "FormAddGuardian";
            this.Text = "FormAddGuardian";
            this.Load += new System.EventHandler(this.FormAddGuardian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label perNumHelpLabel;
        private TextBox nameBox;
        private Button addChildButton;
        private Label nameLabel;
        private TextBox lastNameBox;
        private Label lastNameLabel;
        private TextBox perNumBox;
        private Label perNumLabel;
        private ComboBox comboBoxGuardFor;
        private Label groupLabel;
        private Label applicationLabel;
        private DateTimePicker applicationDatePicker;
        private DateTimePicker startDatePicker;
        private Label endLabel;
        private Label startLabel;
        private DateTimePicker endDatePicker;
    }
}