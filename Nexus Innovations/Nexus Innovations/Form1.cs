namespace Nexus_Innovations
{
    public partial class Form1 : Form
    {
        private ventanaDeIngresar ventanaNexus;
        private int claveDeAcceso = 31390;

        public Form1()
        {
            InitializeComponent();
            ventanaNexus = new ventanaDeIngresar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bIngresar.Visible = false;
        }

        private void cajaClave_TextChanged(object sender, EventArgs e)
        {
            validadCasilLaClave();
        }

        private void validadCasilLaClave()
        {
            bool esClaveValida = int.TryParse(cajaClave.Text, out int clave);
            bIngresar.Visible = esClaveValida;
        }
        public int intentos = 3, intentosFallidos = 0;
        private void bIngresar_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(cajaClave.Text, out int clave) && clave == claveDeAcceso)
            {
                Program.form1.Hide();
                ventanaNexus.ShowDialog();
            }
            else
            {
                cajaClave.Text = null;
                intentos -= 1;
                MessageBox.Show("Clave de acceso incorrecta\nQuedan "+ intentos+" Intentos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (intentos== intentosFallidos)
                {
                    MessageBox.Show("Atencion el programa cerrara\nLos intentos han llegado al limite", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
                
                

            }


        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
