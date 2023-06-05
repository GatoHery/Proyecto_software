using Banco.Forms;
using Banco.Queries;

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

        /*private void Form1_Load(object sender, EventArgs e)
        {

        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Hay campos en blanco");
            }
            else
            {
                //bool flag = true;
                try
                {
                    /*
                        menu_usuario usuario = new menu_usuario(this);
                        usuario.Show();
                        this.Hide();
                        */
                    string response = WorkerQuery.getWorker(textBox1.Text);
                    string position = WorkerQuery.GetWorkerPosition(textBox1.Text);

                    if (textBox2.Text.Equals(response))
                    {
                        textBox1.Text = "";
                        textBox2.Text = "";

                        switch (position)
                        {
                            case "Ventanilla":
                                Menu menu = new Menu(this);
                                menu.Show();
                                this.Hide();
                                break;
                            case "Asesorseguros":
                                FormCarInsuranceRequest insuranceRequest = new FormCarInsuranceRequest(this);
                                insuranceRequest.Show();
                                this.Hide();
                                break;
                            case "Ejecusolicitud":
                                MenuInsuranceRequests insuranceMenu = new MenuInsuranceRequests(this);
                                insuranceMenu.Show();
                                this.Hide();
                                break;
                        }
                    }
                    else MessageBox.Show("Credenciales incorrectas");
                }
                catch (IndexOutOfRangeException ex)
                {
                    MessageBox.Show("No se encontró el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}