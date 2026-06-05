using BLL;

namespace Vista
{
    public partial class Form1 : Form
    {
        BLL_Usuario bllUsuario;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (bllUsuario.Log_In(textBox1.Text, textBox2.Text))
                {
                    MessageBox.Show("Inicio de sesión exitoso");
                    Menu_Principal menuP = new Menu_Principal();
                    menuP.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bllUsuario = new BLL_Usuario();
        }
    }
}
