using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace Client
{
   

    public partial class FormRegistration : Form
    {
        string mailServerIP = "smtp.gmail.com";
        int mailServerPort = 465;
        string mailServerLogin = "levkin.nik2025@gmail.com";
        string mailServerPassword = "tsvvzuzmmwkiqnms";
        string regCode = "";

        string path_to_file = "users.json";
        public FormRegistration()
        {
            InitializeComponent();
            textBox1_login.Text = "supernikich";
            textBox1_password.Text = "Password";
            textBox2_Mail.Text = "supernikich@yandex.ru";

        }

        private async void button1_send_Click(object sender, EventArgs e)
        {
            if (!containsDogCheck(textBox2_Mail.Text) || countsSixSymbols(textBox1_password.Text))
                return;

            //создаем сообщение
            MimeMessage msg = new MimeMessage();
            //от кого
            msg.From.Add(new MailboxAddress("Регистрация в экзаменационном проекте", mailServerLogin));
            //кому
            msg.To.Add(MailboxAddress.Parse(textBox2_Mail.Text));
            //тема
            msg.Subject = "Регистрация";
            //само сообщение 
            Random randomCodeForMailSending = new Random();
            regCode = randomCodeForMailSending.Next(1000, 9999).ToString();
            var builder = new BodyBuilder
            {
                TextBody = $"{regCode}"
            };
            //добавляем вложения в сообщение

            msg.Body = builder.ToMessageBody();
            //проверка, доступен ли серв по данному адресу

            SmtpClient client = new SmtpClient();
            await client.ConnectAsync(mailServerIP, mailServerPort, SecureSocketOptions.SslOnConnect);
            //проходим аутентификацию
            await client.AuthenticateAsync(mailServerLogin, mailServerPassword);

            //если аутентификация прошла успешно, то можно отправлять сообщение

            await client.SendAsync(msg);
            //и можно отключаться
            await client.DisconnectAsync(true);
            //true - выход из учетной записи. если falsr, то просто отключится

            //если все ок, то в статус бар выводим сообщение об успешности

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3_code.Text != regCode)
                {
                    MessageBox.Show("Высланный код отличается от введенного");
                    return;
                }

                User user = new(
                    textBox1_login.Text,
                    HashPassword(textBox1_password.Text),
                    textBox2_Mail.Text
                    );
                List<User> users = new List<User>();
                users.Add(user);

                //сохраняем в файл джесон
                var options = new JsonSerializerOptions { WriteIndented = true };
                File.WriteAllText(path_to_file, JsonSerializer.Serialize(users, options));
                MessageBox.Show("Пользователь добавлен");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        static string HashPassword(string passWord)
        {
            using var sha = SHA256.Create();
            return Convert.ToHexString(sha.ComputeHash(Encoding.UTF8.GetBytes(passWord)));
        }

        internal bool containsDogCheck(string mail)
        {
            if(mail.Contains('@')) return true;
            MessageBox.Show("Ошибка формата почты");
            return false;
        }

        internal bool countsSixSymbols(string password)
        {
            if (password.Length > 6) return true;
            MessageBox.Show("Пароль должен быть длиннее 6 символов");

            return false;
        }

    }

    
}
