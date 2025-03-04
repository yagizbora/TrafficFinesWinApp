namespace TrafficFines
{
    partial class Add_Car_Form
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
            textBoxModel = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxLicansePlate = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxOwnerFullName = new TextBox();
            label5 = new Label();
            textBoxOwnerPassportData = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            dataGridViewCars = new DataGridView();
            InsurableValue = new NumericUpDown();
            label6 = new Label();
            YearOfRelease = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InsurableValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)YearOfRelease).BeginInit();
            SuspendLayout();
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(6, 40);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(131, 23);
            textBoxModel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 23);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 3;
            label2.Text = "Year Of Release";
            // 
            // textBoxLicansePlate
            // 
            textBoxLicansePlate.Location = new Point(258, 40);
            textBoxLicansePlate.Name = "textBoxLicansePlate";
            textBoxLicansePlate.Size = new Size(100, 23);
            textBoxLicansePlate.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 23);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 5;
            label3.Text = "License Plate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 77);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 6;
            label4.Text = "Owner Full Name";
            // 
            // textBoxOwnerFullName
            // 
            textBoxOwnerFullName.Location = new Point(143, 95);
            textBoxOwnerFullName.Name = "textBoxOwnerFullName";
            textBoxOwnerFullName.Size = new Size(100, 23);
            textBoxOwnerFullName.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 77);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 8;
            label5.Text = "Owner Passport Data";
            // 
            // textBoxOwnerPassportData
            // 
            textBoxOwnerPassportData.Location = new Point(6, 95);
            textBoxOwnerPassportData.Name = "textBoxOwnerPassportData";
            textBoxOwnerPassportData.Size = new Size(117, 23);
            textBoxOwnerPassportData.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(258, 95);
            button1.Name = "button1";
            button1.Size = new Size(117, 23);
            button1.TabIndex = 10;
            button1.Text = "Add Car";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(YearOfRelease);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(InsurableValue);
            groupBox1.Controls.Add(textBoxOwnerPassportData);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBoxModel);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxOwnerFullName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxLicansePlate);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(688, 143);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Car Panel";
            // 
            // dataGridViewCars
            // 
            dataGridViewCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCars.Location = new Point(18, 288);
            dataGridViewCars.Name = "dataGridViewCars";
            dataGridViewCars.ReadOnly = true;
            dataGridViewCars.Size = new Size(1135, 150);
            dataGridViewCars.TabIndex = 12;
            // 
            // InsurableValue
            // 
            InsurableValue.Location = new Point(375, 41);
            InsurableValue.Name = "InsurableValue";
            InsurableValue.Size = new Size(120, 23);
            InsurableValue.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(375, 23);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 12;
            label6.Text = "Insurable Value";
            // 
            // YearOfRelease
            // 
            YearOfRelease.Location = new Point(143, 40);
            YearOfRelease.Minimum = 1900;
            YearOfRelease.Maximum = DateTime.Now.Year;
            YearOfRelease.Value = DateTime.Now.Year;
            YearOfRelease.Increment = 1;
            YearOfRelease.Name = "YearOfRelease";
            YearOfRelease.Size = new Size(101, 23);
            YearOfRelease.TabIndex = 13;
            // 
            // Add_Car_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1165, 450);
            Controls.Add(dataGridViewCars);
            Controls.Add(groupBox1);
            Name = "Add_Car_Form";
            Text = "Add_Car_Form";
            Load += Add_Car_Form_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).EndInit();
            ((System.ComponentModel.ISupportInitialize)InsurableValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)YearOfRelease).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxModel;
        private Label label1;
        private Label label2;
        private TextBox textBoxLicansePlate;
        private Label label3;
        private Label label4;
        private TextBox textBoxOwnerFullName;
        private Label label5;
        private TextBox textBoxOwnerPassportData;
        private Button button1;
        private GroupBox groupBox1;
        private DataGridView dataGridViewCars;
        private Label label6;
        private NumericUpDown InsurableValue;
        private NumericUpDown YearOfRelease;
    }
}