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
        string[] vecContactos = new string[5];

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            vContacto = txtContacto.Text;
            vNumero = mtbNumero.Text;
            vContador++;

            lstContactos.Items.Add("Contacto: " + vContacto + "Número: " + vNumero);
            
            lblContador.Text = vContador.ToString();
            lblRFecha.Text = vFecha.ToString();

            //limpiar los controles
            txtContacto.Text = "";
            mtbNumero.Text = "";

            vecContactos[Indice] = vContacto;
            Indice++;
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
        }
    }
}
