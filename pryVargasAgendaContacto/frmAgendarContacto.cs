namespace pryVargasAgendaContacto
{
    public partial class frmAgendarContacto : Form
    {
        public frmAgendarContacto()
        {
            InitializeComponent();
        }
        string vContacto = "";
        string vNumero = "";

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            vContacto = txtContacto.Text;
            vNumero = mtbNumero.Text;

            lstContactos.Items.Add("Contacto: " + vContacto + "Número: " + vNumero);

            //limpiar los controles
            txtContacto.Text = "";
            mtbNumero.Text = "";
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
