namespace TrafficFines
{
    partial class Car_Operations_Form
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
            buttonclearadddatas = new Button();
            YearOfRelease = new NumericUpDown();
            label6 = new Label();
            InsurableValue = new NumericUpDown();
            dataGridViewCars = new DataGridView();
            groupBox2 = new GroupBox();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            CarIdLabel = new Label();
            label13 = new Label();
            EditYearOfRelease = new NumericUpDown();
            label7 = new Label();
            EditInsurableValue = new NumericUpDown();
            textBoxEditOwnerPassportData = new TextBox();
            textBoxEditModel = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBoxEditOwnerFullName = new TextBox();
            label14 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBoxEditLicansePlate = new TextBox();
            label12 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)YearOfRelease).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InsurableValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EditYearOfRelease).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EditInsurableValue).BeginInit();
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
            textBoxLicansePlate.Size = new Size(111, 23);
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
            textBoxOwnerFullName.Location = new Point(143, 100);
            textBoxOwnerFullName.Multiline = true;
            textBoxOwnerFullName.Name = "textBoxOwnerFullName";
            textBoxOwnerFullName.Size = new Size(111, 40);
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
            textBoxOwnerPassportData.Location = new Point(6, 100);
            textBoxOwnerPassportData.Multiline = true;
            textBoxOwnerPassportData.Name = "textBoxOwnerPassportData";
            textBoxOwnerPassportData.Size = new Size(131, 40);
            textBoxOwnerPassportData.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(260, 90);
            button1.Name = "button1";
            button1.Size = new Size(93, 23);
            button1.TabIndex = 10;
            button1.Text = "Add Car";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonclearadddatas);
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
            groupBox1.Size = new Size(512, 165);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Car Panel";
            // 
            // buttonclearadddatas
            // 
            buttonclearadddatas.Location = new Point(260, 117);
            buttonclearadddatas.Name = "buttonclearadddatas";
            buttonclearadddatas.Size = new Size(93, 23);
            buttonclearadddatas.TabIndex = 14;
            buttonclearadddatas.Text = "Temizle";
            buttonclearadddatas.UseVisualStyleBackColor = true;
            buttonclearadddatas.Click += buttonclearadddatas_Click;
            // 
            // YearOfRelease
            // 
            YearOfRelease.Location = new Point(143, 40);
            YearOfRelease.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            YearOfRelease.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            YearOfRelease.Name = "YearOfRelease";
            YearOfRelease.Size = new Size(101, 23);
            YearOfRelease.TabIndex = 13;
            YearOfRelease.Value = new decimal(new int[] { 2025, 0, 0, 0 });
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
            // InsurableValue
            // 
            InsurableValue.Location = new Point(375, 39);
            InsurableValue.Name = "InsurableValue";
            InsurableValue.Size = new Size(120, 23);
            InsurableValue.TabIndex = 11;
            // 
            // dataGridViewCars
            // 
            dataGridViewCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCars.Location = new Point(12, 183);
            dataGridViewCars.Name = "dataGridViewCars";
            dataGridViewCars.ReadOnly = true;
            dataGridViewCars.Size = new Size(1151, 153);
            dataGridViewCars.TabIndex = 12;
            dataGridViewCars.CellClick += dataGridViewCars_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(CarIdLabel);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(EditYearOfRelease);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(EditInsurableValue);
            groupBox2.Controls.Add(textBoxEditOwnerPassportData);
            groupBox2.Controls.Add(textBoxEditModel);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBoxEditOwnerFullName);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(textBoxEditLicansePlate);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(548, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(532, 165);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Edit Car Panel";
            // 
            // button2
            // 
            button2.Location = new Point(357, 125);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 18;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(274, 125);
            button4.Name = "button4";
            button4.Size = new Size(77, 23);
            button4.TabIndex = 17;
            button4.Text = "Delete Car";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(274, 100);
            button3.Name = "button3";
            button3.Size = new Size(77, 23);
            button3.TabIndex = 16;
            button3.Text = "Edit Car";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button2_Click;
            // 
            // CarIdLabel
            // 
            CarIdLabel.AutoSize = true;
            CarIdLabel.Location = new Point(49, 19);
            CarIdLabel.Name = "CarIdLabel";
            CarIdLabel.Size = new Size(12, 15);
            CarIdLabel.TabIndex = 15;
            CarIdLabel.Text = "-";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 19);
            label13.Name = "label13";
            label13.Size = new Size(45, 15);
            label13.TabIndex = 14;
            label13.Text = "Car ID: ";
            // 
            // EditYearOfRelease
            // 
            EditYearOfRelease.Location = new Point(151, 60);
            EditYearOfRelease.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            EditYearOfRelease.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            EditYearOfRelease.Name = "EditYearOfRelease";
            EditYearOfRelease.Size = new Size(101, 23);
            EditYearOfRelease.TabIndex = 13;
            EditYearOfRelease.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(394, 41);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 12;
            label7.Text = "Insurable Value";
            // 
            // EditInsurableValue
            // 
            EditInsurableValue.Location = new Point(394, 61);
            EditInsurableValue.Name = "EditInsurableValue";
            EditInsurableValue.Size = new Size(120, 23);
            EditInsurableValue.TabIndex = 11;
            // 
            // textBoxEditOwnerPassportData
            // 
            textBoxEditOwnerPassportData.Location = new Point(7, 108);
            textBoxEditOwnerPassportData.Multiline = true;
            textBoxEditOwnerPassportData.Name = "textBoxEditOwnerPassportData";
            textBoxEditOwnerPassportData.Size = new Size(131, 40);
            textBoxEditOwnerPassportData.TabIndex = 9;
            // 
            // textBoxEditModel
            // 
            textBoxEditModel.Location = new Point(7, 59);
            textBoxEditModel.Name = "textBoxEditModel";
            textBoxEditModel.Size = new Size(131, 23);
            textBoxEditModel.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 41);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 1;
            label8.Text = "Model";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 90);
            label9.Name = "label9";
            label9.Size = new Size(117, 15);
            label9.TabIndex = 8;
            label9.Text = "Owner Passport Data";
            // 
            // textBoxEditOwnerFullName
            // 
            textBoxEditOwnerFullName.Location = new Point(151, 108);
            textBoxEditOwnerFullName.Multiline = true;
            textBoxEditOwnerFullName.Name = "textBoxEditOwnerFullName";
            textBoxEditOwnerFullName.Size = new Size(117, 40);
            textBoxEditOwnerFullName.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(151, 42);
            label14.Name = "label14";
            label14.Size = new Size(87, 15);
            label14.TabIndex = 3;
            label14.Text = "Year Of Release";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(151, 41);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 3;
            label10.Text = "Year Of Release";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(151, 86);
            label11.Name = "label11";
            label11.Size = new Size(99, 15);
            label11.TabIndex = 6;
            label11.Text = "Owner Full Name";
            // 
            // textBoxEditLicansePlate
            // 
            textBoxEditLicansePlate.Location = new Point(271, 60);
            textBoxEditLicansePlate.Name = "textBoxEditLicansePlate";
            textBoxEditLicansePlate.Size = new Size(117, 23);
            textBoxEditLicansePlate.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(271, 41);
            label12.Name = "label12";
            label12.Size = new Size(75, 15);
            label12.TabIndex = 5;
            label12.Text = "License Plate";
            // 
            // Car_Operations_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1165, 348);
            Controls.Add(groupBox2);
            Controls.Add(dataGridViewCars);
            Controls.Add(groupBox1);
            Name = "Car_Operations_Form";
            Text = "Add Car Form";
            Load += Add_Car_Form_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)YearOfRelease).EndInit();
            ((System.ComponentModel.ISupportInitialize)InsurableValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EditYearOfRelease).EndInit();
            ((System.ComponentModel.ISupportInitialize)EditInsurableValue).EndInit();
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
        private GroupBox groupBox2;
        private NumericUpDown EditYearOfRelease;
        private Label label7;
        private NumericUpDown EditInsurableValue;
        private TextBox textBoxEditOwnerPassportData;
        private TextBox textBoxEditModel;
        private Label label8;
        private Label label9;
        private TextBox textBoxEditOwnerFullName;
        private Label label10;
        private Label label11;
        private TextBox textBoxEditLicansePlate;
        private Label label12;
        private Label CarIdLabel;
        private Label label13;
        private Label label14;
        private Button button4;
        private Button button3;
        private Button buttonclearadddatas;
        private Button button2;
    }
}