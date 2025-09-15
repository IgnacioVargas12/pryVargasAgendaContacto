using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVargasAgendaContacto
{
    public partial class frmVerContactos : Form
    {
        public frmVerContactos()
        {
            InitializeComponent();
        }

        //Declaración variables
        int indice = 0;
        int indice2 = 0;
        public string[] vecContactos2 = new string[5];
        string Resultado = "";

        private void lblListaContactos_Click(object sender, EventArgs e)
        {

        }

        private void frmVerContactos_Load(object sender, EventArgs e)
        {
            lblDatosIndividual.Text = vecContactos2[0];
            btnAtras.Enabled = false;
            while (indice < vecContactos2.Length && !string.IsNullOrEmpty(vecContactos2[indice]))
            {
                Resultado += vecContactos2[indice] + Environment.NewLine;
                indice++;
            }
            lblDatos.Text = Resultado;
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            indice2--;
            lblDatosIndividual.Text = vecContactos2[indice2];

            if (indice2 == 0)
            {
                btnAtras.Enabled = false;
            }

            if (indice2 < 5)
            {
                btnSiguiente.Enabled = true;
            }
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            indice2++;
            lblDatosIndividual.Text = vecContactos2[indice2];

            if (vecContactos2.Length <= (indice2 + 1))
            {
                btnSiguiente.Enabled = false;
            }

            if (vecContactos2[indice2 + 1] is not null )
            {
                btnSiguiente.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled =false;
            }

            if (indice2 >= 0)
            {
                btnAtras.Enabled = true;
            }
        }
    }
}
