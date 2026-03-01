namespace Client
{
    public partial class FormAutorization : Form
    {
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

        }
    }
}
