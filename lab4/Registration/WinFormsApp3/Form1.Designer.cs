namespace WinFormsApp3
{
    partial class Form1
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
            fontDialog1 = new FontDialog();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            Java = new CheckedListBox();
            Submit = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.PeachPuff;
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.Desktop;
            textBox1.Location = new Point(313, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 50);
            textBox1.TabIndex = 0;
            textBox1.Text = "Sign Up Form";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 142);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 275);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 2;
            label2.Text = "District:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 233);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 3;
            label3.Text = "Province:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 192);
            label4.Name = "label4";
            label4.Size = new Size(48, 25);
            label4.TabIndex = 4;
            label4.Text = "Age:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(145, 319);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 5;
            label5.Text = "Skills:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(296, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 31);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kathmandu", "Bhaktapur", "Kavrepalanchowk", "Lalitpur", "Kanchanpur", "Kailali", "Hetauda", "Birgunj", "Biratnagar", "Humla", "Jumla", "Bharatpur", "Mustang", "Parbat", "Dadeldura", "Bajang" });
            comboBox1.Location = new Point(296, 267);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Koshi", "Bagmati", "Madesh", "Gandaki", "Lumbini", "Karnali", "Sudurpaschim" });
            comboBox2.Location = new Point(296, 225);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 8;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(296, 186);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(62, 31);
            numericUpDown1.TabIndex = 9;
            // 
            // Java
            // 
            Java.FormattingEnabled = true;
            Java.Items.AddRange(new object[] { "Java", "JavaScript" });
            Java.Location = new Point(296, 319);
            Java.Name = "Java";
            Java.Size = new Size(182, 60);
            Java.TabIndex = 12;
            Java.SelectedIndexChanged += Java_SelectedIndexChanged;
            // 
            // Submit
            // 
            Submit.BackColor = Color.FromArgb(128, 255, 128);
            Submit.Cursor = Cursors.Hand;
            Submit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Submit.ForeColor = SystemColors.ActiveCaptionText;
            Submit.Location = new Point(316, 436);
            Submit.Name = "Submit";
            Submit.Size = new Size(112, 42);
            Submit.TabIndex = 13;
            Submit.Text = "Sign Up";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(948, 505);
            Controls.Add(Submit);
            Controls.Add(Java);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontDialog fontDialog1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private NumericUpDown numericUpDown1;
        private CheckedListBox Java;
        private Button Submit;
    }
}
