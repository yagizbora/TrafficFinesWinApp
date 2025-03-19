namespace TrafficFines
{
    partial class Entry_Screen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            button4 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 85);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 3;
            label1.Text = "Car Operations Panel";
            // 
            // button1
            // 
            button1.Location = new Point(22, 103);
            button1.Name = "button1";
            button1.Size = new Size(93, 23);
            button1.TabIndex = 2;
            button1.Text = "Open Panel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(162, 103);
            button2.Name = "button2";
            button2.Size = new Size(105, 23);
            button2.TabIndex = 4;
            button2.Text = "Open Panel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 85);
            label2.Name = "label2";
            label2.Size = new Size(147, 15);
            label2.TabIndex = 5;
            label2.Text = "Violation Operations Panel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 22);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Violation ";
            // 
            // button3
            // 
            button3.Location = new Point(98, 40);
            button3.Name = "button3";
            button3.Size = new Size(93, 23);
            button3.TabIndex = 7;
            button3.Text = "Open Panel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(98, 155);
            button4.Name = "button4";
            button4.Size = new Size(93, 23);
            button4.TabIndex = 9;
            button4.Text = "Open Panel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 137);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 8;
            label4.Text = "Payment Form";
            // 
            // Entry_Screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 190);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "Entry_Screen";
            Text = "Traffic Fines App Entry";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Button button3;
        private Button button4;
        private Label label4;
    }
}
