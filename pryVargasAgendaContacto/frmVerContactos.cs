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

        //Declaramos al array publico para poder usarlo en el frmAgendarContactos
        public string[] vecContactos2 = new string[5];

        //Variable auxiliar para concatenar y mostrar al array
        string Resultado = "";

        private void lblListaContactos_Click(object sender, EventArgs e)
        {

        }

        private void frmVerContactos_Load(object sender, EventArgs e)
        {
            //mostramos la primera posición del array y deshabilitamos el btnAtras para evitar errores
            lblDatosIndividual.Text = vecContactos2[0];
            btnAtras.Enabled = false;

            //Recorremos el array hasta que se finalice o encuentre una posición vacia, luego mostramos
            while (indice < vecContactos2.Length && !string.IsNullOrEmpty(vecContactos2[indice]))
            {
                //acumulamos los valores en la variable auxiliar 
                Resultado += vecContactos2[indice] + '\n';
                indice++;
            }
            lblDatos.Text = Resultado;
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            //Mostramos el valor anterior de la posición actual en el array
            indice2--;
            lblDatosIndividual.Text = vecContactos2[indice2];

            //Validamos que si estamos en la posición 0 deshabilite el btnAtras para no salirnos del array
            if (indice2 == 0)
            {
                btnAtras.Enabled = false;
            }

            //Validamos que no nos pasemos de la dimensión del array
            if (indice2 < 5)
            {
                btnSiguiente.Enabled = true;
            }
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            //Mostramos el valor siguiente de la posición actual en el array
            indice2++;
            lblDatosIndividual.Text = vecContactos2[indice2];

            //Validamos que no nos pasemos de la dimensión del array
            if (vecContactos2.Length <= (indice2 + 1))
            {
                btnSiguiente.Enabled = false;
            }

            //Validamos que en la siguiente posición haya algo para mostrar
            if (vecContactos2[indice2 + 1] is not null )
            {
                btnSiguiente.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled =false;
            }

            //Habilitamos el btnAtras xq esta deshabilitado desde el inicio
            btnAtras.Enabled = true;
            
        }
    }
}
