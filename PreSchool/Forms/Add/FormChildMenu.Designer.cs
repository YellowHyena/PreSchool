namespace PreSchool
{
    partial class FormChildMenu
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
            this.childActionButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.perNumBox = new System.Windows.Forms.TextBox();
            this.perNumLabel = new System.Windows.Forms.Label();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.applicationLabel = new System.Windows.Forms.Label();
            this.applicationDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // perNumHelpLabel
            // 
            this.perNumHelpLabel.AutoSize = true;
            this.perNumHelpLabel.Location = new System.Drawing.Point(466, 250);
            this.perNumHelpLabel.Name = "perNumHelpLabel";
            this.perNumHelpLabel.Size = new System.Drawing.Size(112, 20);
            this.perNumHelpLabel.TabIndex = 44;
            this.perNumHelpLabel.Text = "Enbart siffror!";
            this.perNumHelpLabel.Visible = false;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(269, 160);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(187, 27);
            this.nameBox.TabIndex = 23;
            // 
            // childActionButton
            // 
            this.childActionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.childActionButton.Location = new System.Drawing.Point(269, 483);
            this.childActionButton.Name = "childActionButton";
            this.childActionButton.Size = new System.Drawing.Size(118, 29);
            this.childActionButton.TabIndex = 43;
            this.childActionButton.Text = "Action";
            this.childActionButton.UseVisualStyleBackColor = true;
            this.childActionButton.Click += new System.EventHandler(this.ChildActionButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(188, 160);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 20);
            this.nameLabel.TabIndex = 24;
            this.nameLabel.Text = "Namn";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(269, 203);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(187, 27);
            this.lastNameBox.TabIndex = 25;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(153, 210);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.lastNameLabel.TabIndex = 26;
            this.lastNameLabel.Text = "Efternamn";
            // 
            // perNumBox
            // 
            this.perNumBox.Location = new System.Drawing.Point(269, 247);
            this.perNumBox.Name = "perNumBox";
            this.perNumBox.Size = new System.Drawing.Size(187, 27);
            this.perNumBox.TabIndex = 27;
            this.perNumBox.TextChanged += new System.EventHandler(this.perNumBox_TextChanged);
            // 
            // perNumLabel
            // 
            this.perNumLabel.AutoSize = true;
            this.perNumLabel.Location = new System.Drawing.Point(116, 253);
            this.perNumLabel.Name = "perNumLabel";
            this.perNumLabel.Size = new System.Drawing.Size(123, 20);
            this.perNumLabel.TabIndex = 28;
            this.perNumLabel.Text = "Personnummer";
            // 
            // groupComboBox
            // 
            this.groupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(269, 290);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(187, 28);
            this.groupComboBox.TabIndex = 38;
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(154, 293);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(81, 20);
            this.groupLabel.TabIndex = 29;
            this.groupLabel.Text = "Avdelning";
            // 
            // applicationLabel
            // 
            this.applicationLabel.AutoSize = true;
            this.applicationLabel.Location = new System.Drawing.Point(103, 430);
            this.applicationLabel.Name = "applicationLabel";
            this.applicationLabel.Size = new System.Drawing.Size(141, 20);
            this.applicationLabel.TabIndex = 37;
            this.applicationLabel.Text = "Ansökningsdatum";
            // 
            // applicationDatePicker
            // 
            this.applicationDatePicker.Location = new System.Drawing.Point(269, 423);
            this.applicationDatePicker.Name = "applicationDatePicker";
            this.applicationDatePicker.Size = new System.Drawing.Size(187, 27);
            this.applicationDatePicker.TabIndex = 36;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(269, 339);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(187, 27);
            this.startDatePicker.TabIndex = 32;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(153, 386);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(84, 20);
            this.endLabel.TabIndex = 35;
            this.endLabel.Text = "Slutdatum";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(153, 344);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(91, 20);
            this.startLabel.TabIndex = 33;
            this.startLabel.Text = "Startdatum";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(269, 380);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(187, 27);
            this.endDatePicker.TabIndex = 34;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(93, 49);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(89, 24);
            this.radioButton1.TabIndex = 45;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Lägg till";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(85, 79);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton2.Size = new System.Drawing.Size(97, 24);
            this.radioButton2.TabIndex = 46;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Redigera";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(99, 109);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton3.Size = new System.Drawing.Size(83, 24);
            this.radioButton3.TabIndex = 47;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ta bort";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 28);
            this.comboBox1.TabIndex = 48;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormChildMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.perNumHelpLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.childActionButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.perNumBox);
            this.Controls.Add(this.perNumLabel);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.applicationLabel);
            this.Controls.Add(this.applicationDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.endDatePicker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormChildMenu";
            this.Text = "Child Menu";
            this.Load += new System.EventHandler(this.FormAddChild_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label perNumHelpLabel;
        private TextBox nameBox;
        private Button childActionButton;
        private Label nameLabel;
        private TextBox lastNameBox;
        private Label lastNameLabel;
        private TextBox perNumBox;
        private Label perNumLabel;
        private ComboBox groupComboBox;
        private Label groupLabel;
        private Label applicationLabel;
        private DateTimePicker applicationDatePicker;
        private DateTimePicker startDatePicker;
        private Label endLabel;
        private Label startLabel;
        private DateTimePicker endDatePicker;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private ComboBox comboBox1;
    }
}