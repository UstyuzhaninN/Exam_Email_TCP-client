using System.Text;
using System.Text.Json;
using System.Security.Cryptography;


namespace Client
{
    public partial class FormAutorization : Form
    {
        string path_to_file = "users.json";

        public FormAutorization()
        {
            InitializeComponent();
        }

        private void button1_Регистрация_Click(object sender, EventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration();
            this.Hide();
            formRegistration.ShowDialog();
            this.Show();
        }

        private void button1_Enter_Click(object sender, EventArgs e)
        {
            //читаем содержимое файла

            string jsonContains = File.ReadAllText(path_to_file);

            // Десериализуем: превращаем JSON строку обратно в список User

            var options = new JsonSerializerOptions { WriteIndented = true };

            List<User> users = JsonSerializer.Deserialize<List<User>>(jsonContains, options);


            foreach(var user in users)
            {
                if (user.Login == textBox1_login.Text && HashPassword( textBox2_password.Text) == user.Hash)
                {
                    MessageBox.Show("Успешная авторизация!");
                    return;
                }

            }
            MessageBox.Show("Пользователь с такими данными не найден");
            return;

        }

            static string HashPassword(string passWord)
            {
                using var sha = SHA256.Create();
                return Convert.ToHexString(sha.ComputeHash(Encoding.UTF8.GetBytes(passWord)));
            }
        }
}
