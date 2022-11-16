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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Worker> workersList = WorkerQuery.getWorkers();

            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Hay campos en blanco");
            }
            else
            {
                bool flag = true;
                try
                {
                    foreach (var w in workersList)
                    {
                        if (textBox1.Text.Equals(w.username) && textBox2.Text.Equals(w.password))
                        {
                            flag = false;
                            Menu menu = new Menu();
                            menu.Show();
                            this.Hide();
                            break;
                        }
                    }
                    if (flag) MessageBox.Show("Credenciales incorrectas");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}