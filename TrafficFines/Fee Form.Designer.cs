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
            richTextBox1 = new RichTextBox();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
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
            CarComboBox.Location = new Point(12, 35);
            CarComboBox.Name = "CarComboBox";
            CarComboBox.Size = new Size(121, 23);
            CarComboBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
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
            comboBoxViolations.Location = new Point(139, 35);
            comboBoxViolations.Name = "comboBoxViolations";
            comboBoxViolations.Size = new Size(121, 23);
            comboBoxViolations.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 17);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "Violations";
            // 
            // ViolationDate
            // 
            ViolationDate.Location = new Point(12, 83);
            ViolationDate.Name = "ViolationDate";
            ViolationDate.Size = new Size(121, 23);
            ViolationDate.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 63);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 6;
            label3.Text = "Violation Date";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 127);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(248, 43);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(286, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(130, 109);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Right Of Manager";
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
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 109);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 9;
            label4.Text = "Driver Full Name";
            // 
            // button1
            // 
            button1.Location = new Point(12, 176);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Ceza kes";
            button1.UseVisualStyleBackColor = true;
            // 
            // Fee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(ViolationDate);
            Controls.Add(label2);
            Controls.Add(comboBoxViolations);
            Controls.Add(label1);
            Controls.Add(CarComboBox);
            Controls.Add(dataGridView1);
            Name = "Fee";
            Text = "Fee";
            Load += Violations_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private RichTextBox richTextBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label4;
        private Button button1;
    }
}