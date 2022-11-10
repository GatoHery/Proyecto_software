namespace Banco
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox1.BackColor = Color.FromArgb(222, 234, 238);
            textBox2.BackColor = Color.FromArgb(222, 234, 238);
            button1.BackColor = Color.FromArgb(112, 195, 223);
            button2.BackColor = Color.FromArgb(112, 195, 223);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<User> usersList = UserQuery.registeredUsers();

            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Hay campos en blanco");
            }
            else
            {
                bool flag = true;
                try
                {
                    foreach (var u in usersList)
                    {
                        if (textBox1.Text.Equals(u.username) && textBox2.Text.Equals(u.password))
                        {
                            flag = false;
                            Menu menu = new Menu();
                            menu.Show();
                            this.Hide();
                            break;
                        }
                    }
                    if (flag) MessageBox.Show("No se encontró el usuario");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
    }
}