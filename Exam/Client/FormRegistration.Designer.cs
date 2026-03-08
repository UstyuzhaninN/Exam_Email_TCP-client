namespace Client
{
    partial class FormRegistration
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            textBox1_login = new TextBox();
            textBox1_password = new TextBox();
            textBox2_Mail = new TextBox();
            textBox3_code = new TextBox();
            button1_send = new Button();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox1_login, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox1_password, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox2_Mail, 1, 4);
            tableLayoutPanel1.Controls.Add(textBox3_code, 1, 6);
            tableLayoutPanel1.Controls.Add(button1_send, 4, 4);
            tableLayoutPanel1.Controls.Add(button1, 3, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.666667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.5555553F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.888889F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.333333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(136, 68);
            label1.Name = "label1";
            label1.Size = new Size(260, 32);
            label1.TabIndex = 1;
            label1.Text = "Регистрация";
            // 
            // textBox1_login
            // 
            tableLayoutPanel1.SetColumnSpan(textBox1_login, 4);
            textBox1_login.Dock = DockStyle.Fill;
            textBox1_login.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox1_login.Location = new Point(136, 103);
            textBox1_login.Name = "textBox1_login";
            textBox1_login.PlaceholderText = "Логин";
            textBox1_login.Size = new Size(526, 33);
            textBox1_login.TabIndex = 2;
            // 
            // textBox1_password
            // 
            tableLayoutPanel1.SetColumnSpan(textBox1_password, 4);
            textBox1_password.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox1_password.Location = new Point(136, 153);
            textBox1_password.Name = "textBox1_password";
            textBox1_password.PlaceholderText = "Пароль";
            textBox1_password.Size = new Size(526, 33);
            textBox1_password.TabIndex = 3;
            // 
            // textBox2_Mail
            // 
            tableLayoutPanel1.SetColumnSpan(textBox2_Mail, 3);
            textBox2_Mail.Dock = DockStyle.Fill;
            textBox2_Mail.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox2_Mail.Location = new Point(136, 203);
            textBox2_Mail.Name = "textBox2_Mail";
            textBox2_Mail.PlaceholderText = "Почта";
            textBox2_Mail.Size = new Size(393, 33);
            textBox2_Mail.TabIndex = 4;
            // 
            // textBox3_code
            // 
            tableLayoutPanel1.SetColumnSpan(textBox3_code, 2);
            textBox3_code.Dock = DockStyle.Fill;
            textBox3_code.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox3_code.Location = new Point(136, 303);
            textBox3_code.Name = "textBox3_code";
            textBox3_code.PlaceholderText = "Код";
            textBox3_code.Size = new Size(260, 33);
            textBox3_code.TabIndex = 5;
            // 
            // button1_send
            // 
            button1_send.Dock = DockStyle.Fill;
            button1_send.FlatStyle = FlatStyle.Popup;
            button1_send.Location = new Point(535, 203);
            button1_send.Name = "button1_send";
            button1_send.Size = new Size(127, 33);
            button1_send.TabIndex = 6;
            button1_send.Text = "Выслать код";
            button1_send.UseVisualStyleBackColor = true;
            button1_send.Click += button1_send_Click;
            // 
            // button1
            // 
            tableLayoutPanel1.SetColumnSpan(button1, 2);
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(402, 303);
            button1.Name = "button1";
            button1.Size = new Size(260, 34);
            button1.TabIndex = 7;
            button1.Text = "Зарегистрироваться";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FormRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox textBox1_login;
        private TextBox textBox1_password;
        private TextBox textBox2_Mail;
        private TextBox textBox3_code;
        private Button button1_send;
        private Button button1;
    }
}