using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Estado_ConViewState
{
    public partial class UsoViewState : System.Web.UI.Page
    {
        /*
         * Uso de los controles para mantener el estado
         * Es posible mantener el estado entre páginas valiéndose
         * de las propiedades de los controles, pero es recomendable
         * hacerlo de modo personalizado utilizando el ViewState o
         * algún otro mecanismo de manejo de control como podrían
         * ser los cookies, o variables de sesión, pues el manejo del 
         * estado de los controles, igualmente se lo hace a través 
         * del ViewState.
         * */

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) //Si es la primera vez que se carga la página
            {
                txtContador.Text = "1";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int contador;
            contador = Convert.ToInt32(txtContador.Text);
            contador++;
            txtContador.Text = Convert.ToString(contador);
        }
    }
}