using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TextBox
{
    /*
    El control de tipo TextBox se puede presentar en 3 formas principales usando la propiedad TextMode:
    SingleLine, MultiLine, Password
    Pero existen otras formas también importantes como Date, E-Mail, Color, Number, Url, etc

    Hay varias propiedades importantes, pero entre las más relevantes están:
    ID --> Nombre para referirse al control
    ReadOnly --> Hace que el control sea solo de lectura (bloquea la escritura)
    Enabled --> Activa o desactiva el uso del control, tiene prioridad sobre ReadOnly
    MaxLenght --> Cantidad máxima de caracteres que aceptará el control
    Columns --> Ancho en caracteres que el control tendrá. No es estandar para todos los navegadores, por lo que también se puede usar su width
    ToolTip --> Texto informativo de ayuda para el control
     * */
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtReadOnly.Text = "Escritura en tiempo de ejecución";
            //txtReadOnly.ReadOnly = false;
            //txtReadOnly.Enabled = false;
            //txtMultiLine.Focus(); 
        }

        protected void btnPostBack_Click(object sender, EventArgs e)
        {
            lblSingleLine.Text = txtSingleLine.Text;
        }
    }
}