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
            ((System.ComponentModel.ISupportInitialize)dataGridViewViolation).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FineAmount).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewViolation
            // 
            dataGridViewViolation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewViolation.Location = new Point(12, 168);
            dataGridViewViolation.Name = "dataGridViewViolation";
            dataGridViewViolation.Size = new Size(1184, 150);
            dataGridViewViolation.TabIndex = 0;
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
            groupBox1.Size = new Size(289, 150);
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
            FineAmount.Name = "FineAmount";
            FineAmount.Minimum = 0;
            FineAmount.Maximum = decimal.MaxValue;
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
            // Violation_Operations_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1208, 329);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewViolation);
            Name = "Violation_Operations_Form";
            Text = "Violation Operations Form";
            Load += Violation_Operations_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewViolation).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FineAmount).EndInit();
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
    }
}