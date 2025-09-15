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
        public string[] vecContactos2 = new string[5];
        string Resultado = "";

        private void lblListaContactos_Click(object sender, EventArgs e)
        {

        }

        //se encuentra el private void siguiente linea 56 (frmVerContactos.Designer.cs*)
        //private void btnSiguiente_Click(object sender, EventArgs e)
        //{
        //    indice++;
        //    lblDatos.Text = vecContactos2[indice];

        //    if (vecContactos2.Length <= (indice + 1))
        //    {
        //        btnSiguiente.Enabled = false;
        //    }

        //    if (indice > 0)
        //    {
        //        btnAtras.Enabled = true;
        //    }
        //}

        //se encuentra el private void atras en la linea 67 (frmVerContactos.Designer.cs*)
        //private void btnAtras_Click(object sender, EventArgs e)
        //{
        //    indice--;
        //    lblDatos.Text = vecContactos2[indice];

        //    if (indice == 0)
        //    {
        //        btnAtras.Enabled = false;
        //    }

        //    if (indice < 5)
        //    {
        //        btnSiguiente.Enabled = true;
        //    }
        //}

        private void frmVerContactos_Load(object sender, EventArgs e)
        {
            //lblDatos.Text = vecContactos2[0];
            //btnAtras.Enabled = false;
            while (indice < vecContactos2.Length && !string.IsNullOrEmpty(vecContactos2[indice])) 
            {
                Resultado += vecContactos2[indice] + Environment.NewLine;
                indice++;
            }
            lblDatos.Text = Resultado;
        }
    }
}
