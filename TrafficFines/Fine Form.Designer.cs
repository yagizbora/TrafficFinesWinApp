﻿using System.Windows.Forms;

namespace TrafficFines
{
    partial class Fine
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
            label6 = new Label();
            richTextBoxViolationDetection = new RichTextBox();
            LabelFeeAmount = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            label12 = new Label();
            richTextBoxEditViolationDetection = new RichTextBox();
            button3 = new Button();
            LabelEditFeeAmount = new Label();
            label7 = new Label();
            richTextBoxEditDriverFullName = new RichTextBox();
            button2 = new Button();
            CarEditComboBox = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            groupBox4 = new GroupBox();
            EditProxyRadioButton = new RadioButton();
            EditOwnerRadioButton = new RadioButton();
            comboBoxEditViolations = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            EditViolationDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Location = new Point(12, 244);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1252, 160);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            comboBoxViolations.SelectedIndexChanged += comboBoxViolations_SelectedIndexChanged;
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
            richTextBoxDriverFullName.Location = new Point(277, 37);
            richTextBoxDriverFullName.Name = "richTextBoxDriverFullName";
            richTextBoxDriverFullName.Size = new Size(139, 43);
            richTextBoxDriverFullName.TabIndex = 7;
            richTextBoxDriverFullName.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(449, 22);
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
            label4.Location = new Point(277, 19);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 9;
            label4.Text = "Driver Full Name";
            // 
            // button1
            // 
            button1.Location = new Point(158, 89);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Give a fine";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.MenuHighlight;
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(richTextBoxViolationDetection);
            groupBox2.Controls.Add(LabelFeeAmount);
            groupBox2.Controls.Add(label5);
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
            groupBox2.Location = new Point(12, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(649, 217);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Create Fine";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 141);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 14;
            label6.Text = "Violation Detection";
            // 
            // richTextBoxViolationDetection
            // 
            richTextBoxViolationDetection.Location = new Point(13, 162);
            richTextBoxViolationDetection.Name = "richTextBoxViolationDetection";
            richTextBoxViolationDetection.Size = new Size(630, 43);
            richTextBoxViolationDetection.TabIndex = 13;
            richTextBoxViolationDetection.Text = "";
            // 
            // LabelFeeAmount
            // 
            LabelFeeAmount.AutoSize = true;
            LabelFeeAmount.Location = new Point(94, 116);
            LabelFeeAmount.Name = "LabelFeeAmount";
            LabelFeeAmount.Size = new Size(12, 15);
            LabelFeeAmount.TabIndex = 12;
            LabelFeeAmount.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 116);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 11;
            label5.Text = "Fine Amonut:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.MenuHighlight;
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(richTextBoxEditViolationDetection);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(LabelEditFeeAmount);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(richTextBoxEditDriverFullName);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(CarEditComboBox);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(comboBoxEditViolations);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(EditViolationDate);
            groupBox3.Location = new Point(667, 21);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(597, 217);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Edit Fine";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 141);
            label12.Name = "label12";
            label12.Size = new Size(108, 15);
            label12.TabIndex = 16;
            label12.Text = "Violation Detection";
            // 
            // richTextBoxEditViolationDetection
            // 
            richTextBoxEditViolationDetection.Location = new Point(13, 162);
            richTextBoxEditViolationDetection.Name = "richTextBoxEditViolationDetection";
            richTextBoxEditViolationDetection.Size = new Size(578, 43);
            richTextBoxEditViolationDetection.TabIndex = 15;
            richTextBoxEditViolationDetection.Text = "";
            // 
            // button3
            // 
            button3.Location = new Point(166, 77);
            button3.Name = "button3";
            button3.Size = new Size(100, 23);
            button3.TabIndex = 13;
            button3.Text = "Delete The Fine";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // LabelEditFeeAmount
            // 
            LabelEditFeeAmount.AutoSize = true;
            LabelEditFeeAmount.Location = new Point(94, 115);
            LabelEditFeeAmount.Name = "LabelEditFeeAmount";
            LabelEditFeeAmount.Size = new Size(12, 15);
            LabelEditFeeAmount.TabIndex = 12;
            LabelEditFeeAmount.Text = "-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 115);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 11;
            label7.Text = "Fine Amonut:";
            // 
            // richTextBoxEditDriverFullName
            // 
            richTextBoxEditDriverFullName.Enabled = false;
            richTextBoxEditDriverFullName.Location = new Point(277, 40);
            richTextBoxEditDriverFullName.Name = "richTextBoxEditDriverFullName";
            richTextBoxEditDriverFullName.Size = new Size(179, 43);
            richTextBoxEditDriverFullName.TabIndex = 7;
            richTextBoxEditDriverFullName.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(166, 103);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 10;
            button2.Text = "Edit the Fine";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CarEditComboBox
            // 
            CarEditComboBox.FormattingEnabled = true;
            CarEditComboBox.Location = new Point(13, 37);
            CarEditComboBox.Name = "CarEditComboBox";
            CarEditComboBox.Size = new Size(121, 23);
            CarEditComboBox.TabIndex = 1;
            CarEditComboBox.SelectedIndexChanged += CarEditComboBox_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(277, 22);
            label8.Name = "label8";
            label8.Size = new Size(95, 15);
            label8.TabIndex = 9;
            label8.Text = "Driver Full Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 19);
            label9.Name = "label9";
            label9.Size = new Size(30, 15);
            label9.TabIndex = 2;
            label9.Text = "Cars";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(EditProxyRadioButton);
            groupBox4.Controls.Add(EditOwnerRadioButton);
            groupBox4.Location = new Point(467, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(130, 109);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Right Of Manager";
            // 
            // EditProxyRadioButton
            // 
            EditProxyRadioButton.AutoSize = true;
            EditProxyRadioButton.Location = new Point(6, 52);
            EditProxyRadioButton.Name = "EditProxyRadioButton";
            EditProxyRadioButton.Size = new Size(54, 19);
            EditProxyRadioButton.TabIndex = 1;
            EditProxyRadioButton.TabStop = true;
            EditProxyRadioButton.Text = "Proxy";
            EditProxyRadioButton.UseVisualStyleBackColor = true;
            EditProxyRadioButton.CheckedChanged += EditOwnerRadioButton_CheckedChanged;
            // 
            // EditOwnerRadioButton
            // 
            EditOwnerRadioButton.AutoSize = true;
            EditOwnerRadioButton.Location = new Point(6, 22);
            EditOwnerRadioButton.Name = "EditOwnerRadioButton";
            EditOwnerRadioButton.Size = new Size(60, 19);
            EditOwnerRadioButton.TabIndex = 0;
            EditOwnerRadioButton.TabStop = true;
            EditOwnerRadioButton.Text = "Owner";
            EditOwnerRadioButton.UseVisualStyleBackColor = true;
            EditOwnerRadioButton.CheckedChanged += EditOwnerRadioButton_CheckedChanged;
            // 
            // comboBoxEditViolations
            // 
            comboBoxEditViolations.FormattingEnabled = true;
            comboBoxEditViolations.Location = new Point(140, 37);
            comboBoxEditViolations.Name = "comboBoxEditViolations";
            comboBoxEditViolations.Size = new Size(121, 23);
            comboBoxEditViolations.TabIndex = 3;
            comboBoxEditViolations.SelectedIndexChanged += comboBoxEditViolations_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(140, 19);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 4;
            label10.Text = "Violations";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 65);
            label11.Name = "label11";
            label11.Size = new Size(81, 15);
            label11.TabIndex = 6;
            label11.Text = "Violation Date";
            // 
            // EditViolationDate
            // 
            EditViolationDate.CustomFormat = "dd/MM/yyyy HH:mm";
            EditViolationDate.Format = DateTimePickerFormat.Custom;
            EditViolationDate.Location = new Point(13, 85);
            EditViolationDate.Name = "EditViolationDate";
            EditViolationDate.ShowUpDown = true;
            EditViolationDate.Size = new Size(139, 23);
            EditViolationDate.TabIndex = 5;
            // 
            // Fine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1276, 416);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "Fine";
            Text = "Fine Form";
            Load += Violations_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
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
        private Label label5;
        private Label LabelFeeAmount;
        private GroupBox groupBox3;
        private Label LabelEditFeeAmount;
        private Label label7;
        private RichTextBox richTextBoxEditDriverFullName;
        private Button button2;
        private ComboBox CarEditComboBox;
        private Label label8;
        private Label label9;
        private GroupBox groupBox4;
        private RadioButton EditProxyRadioButton;
        private RadioButton EditOwnerRadioButton;
        private ComboBox comboBoxEditViolations;
        private Label label10;
        private Label label11;
        private DateTimePicker EditViolationDate;
        private Button button3;
        private Label label6;
        private RichTextBox richTextBoxViolationDetection;
        private Label label12;
        private RichTextBox richTextBoxEditViolationDetection;
    }
}