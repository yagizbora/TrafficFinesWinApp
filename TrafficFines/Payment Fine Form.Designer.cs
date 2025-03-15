namespace TrafficFines
{
    partial class Payment_Fine_Form
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
            label1 = new Label();
            button1 = new Button();
            numericUpDownViolationFactID = new NumericUpDown();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            richTextBoxOverDueDays = new RichTextBox();
            label8 = new Label();
            label7 = new Label();
            textBoxViolationFactID = new TextBox();
            dateTimePickerViolationDate = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            richTextBoxDriverFullName = new RichTextBox();
            label4 = new Label();
            textBoxModel = new TextBox();
            label3 = new Label();
            textBoxViolationType = new TextBox();
            label2 = new Label();
            textBoxFineAmount = new TextBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            radioButtonCreditCard = new RadioButton();
            radioButtonCash = new RadioButton();
            textBoxReceiptNumber = new TextBox();
            label9 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownViolationFactID).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "Fine Number";
            // 
            // button1
            // 
            button1.Location = new Point(6, 70);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Fine Check";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDownViolationFactID
            // 
            numericUpDownViolationFactID.Location = new Point(6, 41);
            numericUpDownViolationFactID.Name = "numericUpDownViolationFactID";
            numericUpDownViolationFactID.Size = new Size(120, 23);
            numericUpDownViolationFactID.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDownViolationFactID);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(165, 107);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Check Fine ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBoxOverDueDays);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBoxViolationFactID);
            groupBox2.Controls.Add(dateTimePickerViolationDate);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(richTextBoxDriverFullName);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBoxModel);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBoxViolationType);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxFineAmount);
            groupBox2.Location = new Point(18, 136);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(630, 130);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fine Information";
            // 
            // richTextBoxOverDueDays
            // 
            richTextBoxOverDueDays.Enabled = false;
            richTextBoxOverDueDays.Location = new Point(438, 40);
            richTextBoxOverDueDays.Name = "richTextBoxOverDueDays";
            richTextBoxOverDueDays.Size = new Size(186, 64);
            richTextBoxOverDueDays.TabIndex = 14;
            richTextBoxOverDueDays.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(438, 22);
            label8.Name = "label8";
            label8.Size = new Size(126, 15);
            label8.TabIndex = 13;
            label8.Text = "Delayed Payment Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(275, 19);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 11;
            label7.Text = "Fine Number";
            // 
            // textBoxViolationFactID
            // 
            textBoxViolationFactID.Enabled = false;
            textBoxViolationFactID.Location = new Point(275, 37);
            textBoxViolationFactID.Name = "textBoxViolationFactID";
            textBoxViolationFactID.Size = new Size(147, 23);
            textBoxViolationFactID.TabIndex = 10;
            // 
            // dateTimePickerViolationDate
            // 
            dateTimePickerViolationDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePickerViolationDate.Enabled = false;
            dateTimePickerViolationDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerViolationDate.Location = new Point(135, 37);
            dateTimePickerViolationDate.Name = "dateTimePickerViolationDate";
            dateTimePickerViolationDate.Size = new Size(130, 23);
            dateTimePickerViolationDate.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(135, 19);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 8;
            label6.Text = "Violation Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(275, 63);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 7;
            label5.Text = "Driver Full Name";
            // 
            // richTextBoxDriverFullName
            // 
            richTextBoxDriverFullName.Enabled = false;
            richTextBoxDriverFullName.Location = new Point(275, 81);
            richTextBoxDriverFullName.Name = "richTextBoxDriverFullName";
            richTextBoxDriverFullName.Size = new Size(147, 23);
            richTextBoxDriverFullName.TabIndex = 6;
            richTextBoxDriverFullName.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 63);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 5;
            label4.Text = "Model";
            // 
            // textBoxModel
            // 
            textBoxModel.Enabled = false;
            textBoxModel.Location = new Point(135, 81);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(130, 23);
            textBoxModel.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 63);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 3;
            label3.Text = "Violation Type";
            // 
            // textBoxViolationType
            // 
            textBoxViolationType.Enabled = false;
            textBoxViolationType.Location = new Point(6, 81);
            textBoxViolationType.Name = "textBoxViolationType";
            textBoxViolationType.Size = new Size(113, 23);
            textBoxViolationType.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 1;
            label2.Text = "Fine Amount";
            // 
            // textBoxFineAmount
            // 
            textBoxFineAmount.Enabled = false;
            textBoxFineAmount.Location = new Point(6, 37);
            textBoxFineAmount.Name = "textBoxFineAmount";
            textBoxFineAmount.Size = new Size(114, 23);
            textBoxFineAmount.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(textBoxReceiptNumber);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(18, 272);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(630, 100);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Payment";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButtonCreditCard);
            groupBox4.Controls.Add(radioButtonCash);
            groupBox4.Location = new Point(135, 19);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(147, 75);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Payment Method";
            // 
            // radioButtonCreditCard
            // 
            radioButtonCreditCard.AutoSize = true;
            radioButtonCreditCard.Location = new Point(6, 44);
            radioButtonCreditCard.Name = "radioButtonCreditCard";
            radioButtonCreditCard.Size = new Size(85, 19);
            radioButtonCreditCard.TabIndex = 1;
            radioButtonCreditCard.TabStop = true;
            radioButtonCreditCard.Text = "Credit Card";
            radioButtonCreditCard.UseVisualStyleBackColor = true;
            // 
            // radioButtonCash
            // 
            radioButtonCash.AutoSize = true;
            radioButtonCash.Location = new Point(6, 19);
            radioButtonCash.Name = "radioButtonCash";
            radioButtonCash.Size = new Size(51, 19);
            radioButtonCash.TabIndex = 0;
            radioButtonCash.TabStop = true;
            radioButtonCash.Text = "Cash";
            radioButtonCash.UseVisualStyleBackColor = true;
            // 
            // textBoxReceiptNumber
            // 
            textBoxReceiptNumber.Location = new Point(6, 37);
            textBoxReceiptNumber.Name = "textBoxReceiptNumber";
            textBoxReceiptNumber.Size = new Size(113, 23);
            textBoxReceiptNumber.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 19);
            label9.Name = "label9";
            label9.Size = new Size(93, 15);
            label9.TabIndex = 0;
            label9.Text = "Receipt Number";
            // 
            // button2
            // 
            button2.Location = new Point(7, 66);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Pay Fine";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Payment_Fine_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Payment_Fine_Form";
            Text = "Payment Fine Form";
            Load += Payment_Fine_Form_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownViolationFactID).EndInit();
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
        private Label label1;
        private Button button1;
        private NumericUpDown numericUpDownViolationFactID;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox textBoxFineAmount;
        private Label label3;
        private TextBox textBoxViolationType;
        private Label label4;
        private TextBox textBoxModel;
        private RichTextBox richTextBoxDriverFullName;
        private Label label5;
        private DateTimePicker dateTimePickerViolationDate;
        private Label label6;
        private Label label7;
        private TextBox textBoxViolationFactID;
        private Label label8;
        private RichTextBox richTextBoxOverDueDays;
        private GroupBox groupBox3;
        private TextBox textBoxReceiptNumber;
        private Label label9;
        private GroupBox groupBox4;
        private RadioButton radioButtonCreditCard;
        private RadioButton radioButtonCash;
        private Button button2;
    }
}