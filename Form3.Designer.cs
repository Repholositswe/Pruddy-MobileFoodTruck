namespace MobileFoodTruck_63269996
{
    partial class Form3
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtCellphone = new TextBox();
            txtEmail = new TextBox();
            txtIDNumber = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 42);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 84);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 1;
            label2.Text = "Cellphone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 120);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 2;
            label3.Text = "Email Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 156);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "ID Number";
            // 
            // txtName
            // 
            txtName.Location = new Point(167, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(160, 23);
            txtName.TabIndex = 4;
            txtName.Leave += txtName_Leave;
            // 
            // txtCellphone
            // 
            txtCellphone.Location = new Point(167, 81);
            txtCellphone.Name = "txtCellphone";
            txtCellphone.Size = new Size(160, 23);
            txtCellphone.TabIndex = 5;
            txtCellphone.Leave += txtCellphone_Leave;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(167, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(160, 23);
            txtEmail.TabIndex = 6;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtIDNumber
            // 
            txtIDNumber.Location = new Point(167, 156);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.Size = new Size(160, 23);
            txtIDNumber.TabIndex = 7;
            txtIDNumber.TextChanged += txtIDNumber_TextChanged;
            txtIDNumber.Leave += txtIDNumber_Leave;
            // 
            // button1
            // 
            button1.Location = new Point(167, 202);
            button1.Name = "button1";
            button1.Size = new Size(75, 40);
            button1.TabIndex = 8;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtIDNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtCellphone);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Customer Details";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtCellphone;
        private TextBox txtEmail;
        private TextBox txtIDNumber;
        private Button button1;
    }
}