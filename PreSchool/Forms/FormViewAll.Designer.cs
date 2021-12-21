namespace PreSchool
{
    partial class FormViewAll
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxFilterGroup = new System.Windows.Forms.ComboBox();
            this.checkBoxFilterGroup = new System.Windows.Forms.CheckBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(40, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 364);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(234, 42);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(156, 364);
            this.listBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(523, 468);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 2;
            // 
            // comboBoxFilterGroup
            // 
            this.comboBoxFilterGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterGroup.Enabled = false;
            this.comboBoxFilterGroup.FormattingEnabled = true;
            this.comboBoxFilterGroup.Location = new System.Drawing.Point(147, 469);
            this.comboBoxFilterGroup.Name = "comboBoxFilterGroup";
            this.comboBoxFilterGroup.Size = new System.Drawing.Size(151, 28);
            this.comboBoxFilterGroup.TabIndex = 3;
            this.comboBoxFilterGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterGroup_SelectedIndexChanged);
            // 
            // checkBoxFilterGroup
            // 
            this.checkBoxFilterGroup.AutoSize = true;
            this.checkBoxFilterGroup.Location = new System.Drawing.Point(39, 471);
            this.checkBoxFilterGroup.Name = "checkBoxFilterGroup";
            this.checkBoxFilterGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxFilterGroup.Size = new System.Drawing.Size(102, 24);
            this.checkBoxFilterGroup.TabIndex = 4;
            this.checkBoxFilterGroup.Text = "Visa grupp";
            this.checkBoxFilterGroup.UseVisualStyleBackColor = true;
            this.checkBoxFilterGroup.CheckedChanged += new System.EventHandler(this.checkBoxFilterGroup_CheckedChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(430, 42);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(156, 364);
            this.listBox3.TabIndex = 5;
            // 
            // FormViewAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.checkBoxFilterGroup);
            this.Controls.Add(this.comboBoxFilterGroup);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "FormViewAll";
            this.Text = "FormViewAll";
            this.Load += new System.EventHandler(this.FormViewAll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private TextBox textBox1;
        private ComboBox comboBoxFilterGroup;
        private CheckBox checkBoxFilterGroup;
        private ListBox listBox3;
    }
}