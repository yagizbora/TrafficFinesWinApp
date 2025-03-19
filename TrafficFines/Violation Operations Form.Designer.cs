namespace TrafficFines
{
    partial class Violation_Operations_Form
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
            dataGridViewViolation = new DataGridView();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label2 = new Label();
            FineAmount = new NumericUpDown();
            richTextBoxViolationType = new RichTextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            ViolationIDLabel = new Label();
            label5 = new Label();
            button2 = new Button();
            label3 = new Label();
            EditFineAmount = new NumericUpDown();
            richTextBoxEditViolationType = new RichTextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewViolation).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FineAmount).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EditFineAmount).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewViolation
            // 
            dataGridViewViolation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewViolation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewViolation.Location = new Point(12, 204);
            dataGridViewViolation.Name = "dataGridViewViolation";
            dataGridViewViolation.Size = new Size(559, 114);
            dataGridViewViolation.TabIndex = 0;
            dataGridViewViolation.CellClick += dataGridViewViolation_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(FineAmount);
            groupBox1.Controls.Add(richTextBoxViolationType);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 186);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Violation";
            // 
            // button1
            // 
            button1.Location = new Point(6, 87);
            button1.Name = "button1";
            button1.Size = new Size(98, 23);
            button1.TabIndex = 5;
            button1.Text = "Add Violation";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 19);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 4;
            label2.Text = "Fine Amount";
            // 
            // FineAmount
            // 
            FineAmount.Location = new Point(146, 37);
            FineAmount.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            FineAmount.Name = "FineAmount";
            FineAmount.Size = new Size(120, 23);
            FineAmount.TabIndex = 3;
            // 
            // richTextBoxViolationType
            // 
            richTextBoxViolationType.Location = new Point(6, 37);
            richTextBoxViolationType.Name = "richTextBoxViolationType";
            richTextBoxViolationType.Size = new Size(112, 35);
            richTextBoxViolationType.TabIndex = 2;
            richTextBoxViolationType.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 1;
            label1.Text = "Violation Type";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(ViolationIDLabel);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(EditFineAmount);
            groupBox2.Controls.Add(richTextBoxEditViolationType);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(317, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(254, 186);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Edit Violation";
            // 
            // button3
            // 
            button3.Location = new Point(6, 139);
            button3.Name = "button3";
            button3.Size = new Size(112, 27);
            button3.TabIndex = 13;
            button3.Text = "Delete Violation";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ViolationIDLabel
            // 
            ViolationIDLabel.AutoSize = true;
            ViolationIDLabel.Location = new Point(83, 19);
            ViolationIDLabel.Name = "ViolationIDLabel";
            ViolationIDLabel.Size = new Size(12, 15);
            ViolationIDLabel.TabIndex = 12;
            ViolationIDLabel.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 11;
            label5.Text = "Violation ID:";
            // 
            // button2
            // 
            button2.Location = new Point(6, 110);
            button2.Name = "button2";
            button2.Size = new Size(112, 23);
            button2.TabIndex = 10;
            button2.Text = "Edit Violation";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 42);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 9;
            label3.Text = "Fine Amount";
            // 
            // EditFineAmount
            // 
            EditFineAmount.DecimalPlaces = 2;
            EditFineAmount.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            EditFineAmount.Location = new Point(124, 60);
            EditFineAmount.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            EditFineAmount.Name = "EditFineAmount";
            EditFineAmount.Size = new Size(120, 23);
            EditFineAmount.TabIndex = 8;
            // 
            // richTextBoxEditViolationType
            // 
            richTextBoxEditViolationType.Location = new Point(6, 60);
            richTextBoxEditViolationType.Name = "richTextBoxEditViolationType";
            richTextBoxEditViolationType.Size = new Size(112, 35);
            richTextBoxEditViolationType.TabIndex = 7;
            richTextBoxEditViolationType.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 42);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 6;
            label4.Text = "Violation Type";
            // 
            // Violation_Operations_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(580, 329);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewViolation);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Violation_Operations_Form";
            Text = "Violation Operations Form";
            Load += Violation_Operations_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewViolation).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FineAmount).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EditFineAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewViolation;
        private GroupBox groupBox1;
        private RichTextBox richTextBoxViolationType;
        private Label label1;
        private Label label2;
        private NumericUpDown FineAmount;
        private Button button1;
        private GroupBox groupBox2;
        private Button button2;
        private Label label3;
        private NumericUpDown EditFineAmount;
        private RichTextBox richTextBoxEditViolationType;
        private Label label4;
        private Label ViolationIDLabel;
        private Label label5;
        private Button button3;
    }
}