namespace Client
{
    partial class FormAutorization
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
            tableLayoutPanel1 = new TableLayoutPanel();
            button1_Регистрация = new Button();
            button1_Enter = new Button();
            textBox2_password = new TextBox();
            label1 = new Label();
            textBox1_login = new TextBox();
            button1_forgotPassword = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Controls.Add(button1_Регистрация, 3, 7);
            tableLayoutPanel1.Controls.Add(button1_Enter, 2, 6);
            tableLayoutPanel1.Controls.Add(textBox2_password, 1, 4);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox1_login, 1, 2);
            tableLayoutPanel1.Controls.Add(button1_forgotPassword, 2, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.55555534F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.4444447F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1_Регистрация
            // 
            button1_Регистрация.Dock = DockStyle.Fill;
            button1_Регистрация.FlatStyle = FlatStyle.Flat;
            button1_Регистрация.Location = new Point(402, 352);
            button1_Регистрация.Name = "button1_Регистрация";
            button1_Регистрация.Size = new Size(127, 44);
            button1_Регистрация.TabIndex = 5;
            button1_Регистрация.Text = "Регистрация";
            button1_Регистрация.UseVisualStyleBackColor = true;
            button1_Регистрация.Click += button1_Регистрация_Click;
            // 
            // button1_Enter
            // 
            tableLayoutPanel1.SetColumnSpan(button1_Enter, 2);
            button1_Enter.Dock = DockStyle.Fill;
            button1_Enter.FlatStyle = FlatStyle.Flat;
            button1_Enter.Location = new Point(269, 302);
            button1_Enter.Name = "button1_Enter";
            button1_Enter.Size = new Size(260, 44);
            button1_Enter.TabIndex = 4;
            button1_Enter.Text = "Вход";
            button1_Enter.UseVisualStyleBackColor = true;
            button1_Enter.Click += button1_Enter_Click;
            // 
            // textBox2_password
            // 
            tableLayoutPanel1.SetColumnSpan(textBox2_password, 4);
            textBox2_password.Dock = DockStyle.Fill;
            textBox2_password.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox2_password.Location = new Point(136, 178);
            textBox2_password.Name = "textBox2_password";
            textBox2_password.PlaceholderText = "Пароль";
            textBox2_password.Size = new Size(526, 33);
            textBox2_password.TabIndex = 2;
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
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
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
            textBox1_login.TabIndex = 1;
            // 
            // button1_forgotPassword
            // 
            button1_forgotPassword.Dock = DockStyle.Fill;
            button1_forgotPassword.FlatStyle = FlatStyle.Flat;
            button1_forgotPassword.Location = new Point(269, 352);
            button1_forgotPassword.Name = "button1_forgotPassword";
            button1_forgotPassword.Size = new Size(127, 44);
            button1_forgotPassword.TabIndex = 3;
            button1_forgotPassword.Text = "Забыл пароль";
            button1_forgotPassword.UseVisualStyleBackColor = true;
            // 
            // FormAutorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FormAutorization";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox textBox1_login;
        private TextBox textBox2_password;
        private Button button1_Enter;
        private Button button1_forgotPassword;
        private Button button1_Регистрация;
    }
}
