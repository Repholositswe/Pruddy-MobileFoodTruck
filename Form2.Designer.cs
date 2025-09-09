namespace MobileFoodTruck_63269996
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            txtTotal = new TextBox();
            comboBox1 = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            label3 = new Label();
            label4 = new Label();
            txtBookingDate = new TextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(566, 411);
            label1.Name = "label1";
            label1.Size = new Size(213, 17);
            label1.TabIndex = 1;
            label1.Text = "(c) Prudence Maphutha. 63269996";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(491, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 134);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "HotDogs";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 97);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(128, 19);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Large Hotdog - R35";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 72);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(144, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Medium Hotdog - R25";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(128, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Small Hotdog - R20";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(123, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Mini Hotdog - R15";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Russian and Chips\t\tR35", "Kota(Spathlo)\t\t\tR55", "Kota Mince\t\t\tR50", "Vetkoek with Mince\t\tR25", "Pap & Beef Stew\t\t\tR80", "Pap & Chicken Stew\t\tR70", "Pap & Boerewors\t\t\tR70", "Pap & Mogodu                             \tR70" });
            checkedListBox1.Location = new Point(28, 64);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(267, 166);
            checkedListBox1.TabIndex = 3;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 348);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 4;
            label2.Text = "TOTAL : R";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(111, 345);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(76, 23);
            txtTotal.TabIndex = 5;
            txtTotal.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Russian & Chips + Any Soda ", "BunnyChow + Any Soda", "Kota + Any Soda", "Pap Meal + Chakalaka + Any Soda " });
            comboBox1.Location = new Point(28, 276);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(507, 229);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 32);
            label3.Name = "label3";
            label3.Size = new Size(246, 20);
            label3.TabIndex = 8;
            label3.Text = "Ready to chow? Here’s the menu..";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(491, 205);
            label4.Name = "label4";
            label4.Size = new Size(260, 15);
            label4.TabIndex = 9;
            label4.Text = "Choose when you'd like to receive your order";
            // 
            // txtBookingDate
            // 
            txtBookingDate.Location = new Point(363, 264);
            txtBookingDate.Name = "txtBookingDate";
            txtBookingDate.ReadOnly = true;
            txtBookingDate.Size = new Size(100, 23);
            txtBookingDate.TabIndex = 10;
            txtBookingDate.TextChanged += txtBookingDate_TextChanged;
            // 
            // button1
            // 
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(347, 293);
            button1.Name = "button1";
            button1.Size = new Size(133, 23);
            button1.TabIndex = 11;
            button1.Text = "+ Add Customer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtBookingDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(monthCalendar1);
            Controls.Add(comboBox1);
            Controls.Add(txtTotal);
            Controls.Add(label2);
            Controls.Add(checkedListBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Menu";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private CheckedListBox checkedListBox1;
        private Label label2;
        private TextBox txtTotal;
        private ComboBox comboBox1;
        private MonthCalendar monthCalendar1;
        private Label label3;
        private Label label4;
        private TextBox txtBookingDate;
        private Button button1;
    }
}