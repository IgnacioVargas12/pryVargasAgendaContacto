namespace pryVargasAgendaContacto
{
    public partial class frmAgendarContacto : Form
    {
        public frmAgendarContacto()
        {
            InitializeComponent();
        }
        //Declaramos variables globales
        string vContacto = "";
        string vNumero = "";
        int vContador = 0;
        int Indice = 0;
        DateTime vFecha = DateTime.Now;

        //Declaración de vector contactos y números
        public string[] vecContactos = new string[5];
        public string[] vecNumeros = new string[5];

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //otorgamos valor a las variables
            vContacto = txtContacto.Text;
            vNumero = mtbNumero.Text;
            vContador++;

            //mostramos resultados
            lstContactos.Items.Add("Contacto: " + vContacto + " " + "Número: " + vNumero);

            lblContador.Text = vContador.ToString();
            lblRFecha.Text = vFecha.ToString();

            //limpiar los controles
            txtContacto.Text = "";
            mtbNumero.Text = "";
            btnRegistrar.Enabled = false;
            btnAbrir.Enabled = true;

            //guardamos datos en el array
            vecContactos[Indice] = vContacto;
            vecNumeros[Indice] = vNumero;
            Indice++;

            //validar que no este lleno el array
            if (Indice == 5)
            {
                btnRegistrar.Enabled = false;
                MessageBox.Show("El array se encunetra lleno");
            }
           
              //ponemos el foco de vuelta en contacto
              txtContacto.Focus();
        }

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {
            if (txtContacto.Text == "")
            {
                mtbNumero.Enabled = false;
            }
            else
            {
                mtbNumero.Enabled = true;
            }

        }

        private void mtbNumero_TextChanged(object sender, EventArgs e)
        {
            if (mtbNumero.Text == "")
            {
                btnRegistrar.Enabled = false;
            }
            else
            {
                btnRegistrar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtContacto.Text = "";
            mtbNumero.Text = "";
            txtContacto.Focus();
            btnRegistrar.Enabled = false;

        }

        private void frmAgendarContacto_Load(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            frmVerContactos ventanaVerContacto = new frmVerContactos();

            ventanaVerContacto.vecContactos2 = vecContactos;

            ventanaVerContacto.ShowDialog();
        }
    }
}
