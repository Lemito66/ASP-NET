using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/*
Para separar grupos de radio buttons se usa la propiedad GroupName
Si un Radio Button tiene activada la propiedad AutoPostBak, hará un post back automáticamente
y se ejecutará su principal evento. No se ejecuta el evento clic del botón porque no se ha dado
clic sobre el botón, sin embargo si se hace un PostBack, es decir una llamada al servidor
El resto de controles mantendrán su estado previo al PostBack
 * */

namespace RadioButton
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProcesar_Click(object sender, EventArgs e)
        {
            string cad = "";
            if (rbEcuador.Checked)
                cad = "Capital: Quito";
            else if (rbColombia.Checked)
                cad = "Capital: Bogot&aacute;";
            else if (rbPeru.Checked)
                cad = "Capital: Lima";
            lblPais.Text = cad;

        }

        protected void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            lblGenero.Text = "G&eacute;nero: " + rbMasculino.Text;
        }

        protected void rbFemenino_CheckedChanged(object sender, EventArgs e)
        {
            lblGenero.Text = "G&eacute;nero: " + rbFemenino.Text;
        }
        
        protected void rbNoDice_CheckedChanged(object sender, EventArgs e)
        {
            lblGenero.Text = "";
        }
    }
}