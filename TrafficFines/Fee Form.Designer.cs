using System.Windows.Forms;

namespace TrafficFines
{
    partial class Fee
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            CarComboBox = new ComboBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            comboBoxViolations = new ComboBox();
            label2 = new Label();
            ViolationDate = new DateTimePicker();
            label3 = new Label();
            richTextBoxDriverFullName = new RichTextBox();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label4 = new Label();
            button1 = new Button();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1169, 150);
            dataGridView1.TabIndex = 0;
            // 
            // CarComboBox
            // 
            CarComboBox.FormattingEnabled = true;
            CarComboBox.Location = new Point(13, 37);
            CarComboBox.Name = "CarComboBox";
            CarComboBox.Size = new Size(121, 23);
            CarComboBox.TabIndex = 1;
            CarComboBox.SelectedIndexChanged += CarComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 19);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 2;
            label1.Text = "Cars";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 180000;
            timer1.Tick += timer1_Tick;
            // 
            // comboBoxViolations
            // 
            comboBoxViolations.FormattingEnabled = true;
            comboBoxViolations.Location = new Point(140, 37);
            comboBoxViolations.Name = "comboBoxViolations";
            comboBoxViolations.Size = new Size(121, 23);
            comboBoxViolations.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 19);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "Violations";
            // 
            // ViolationDate
            // 
            ViolationDate.CustomFormat = "dd/MM/yyyy HH:mm";
            ViolationDate.Format = DateTimePickerFormat.Custom;
            ViolationDate.Location = new Point(13, 85);
            ViolationDate.Name = "ViolationDate";
            ViolationDate.ShowUpDown = true;
            ViolationDate.Size = new Size(139, 23);
            ViolationDate.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 65);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 6;
            label3.Text = "Violation Date";
            // 
            // richTextBoxDriverFullName
            // 
            richTextBoxDriverFullName.Enabled = false;
            richTextBoxDriverFullName.Location = new Point(13, 129);
            richTextBoxDriverFullName.Name = "richTextBoxDriverFullName";
            richTextBoxDriverFullName.Size = new Size(248, 43);
            richTextBoxDriverFullName.TabIndex = 7;
            richTextBoxDriverFullName.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(287, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(130, 109);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Right Of Manager";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 52);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(54, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Proxy";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radiobutton_checkedchanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Owner";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radiobutton_checkedchanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 111);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 9;
            label4.Text = "Driver Full Name";
            // 
            // button1
            // 
            button1.Location = new Point(13, 178);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Ceza kes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBoxDriverFullName);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(CarComboBox);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(comboBoxViolations);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(ViolationDate);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(446, 270);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Create Fee";
            // 
            // Fee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 450);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Name = "Fee";
            Text = "Fee";
            Load += Violations_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox CarComboBox;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private ComboBox comboBoxViolations;
        private Label label2;
        private DateTimePicker ViolationDate;
        private Label label3;
        private RichTextBox richTextBoxDriverFullName;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label4;
        private Button button1;
        private GroupBox groupBox2;
    }
}