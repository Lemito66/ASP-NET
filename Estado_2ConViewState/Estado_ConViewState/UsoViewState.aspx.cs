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
         * Uso del ViewState
         * El ViewState es un objeto que permite mantener el estado
         * del formulario web entre petición y petición. De ese
         * modo no es necesario pasar valores entre páginas usando 
         * métodos como get o post.
         * El ViewState puede almacenar tantos elementos como se 
         * necesite y cada uno de ellos puede ser de diferente tipo.
         * El ViewState inicia como null y requiere que se haga 
         * el correspondiente casting.
         * 
         * Ejercicio:
         * Cambie este programa para que el valor que consta
         * en el cuadro de texto también se actualice según
         * lo que el usuario indique entre llamada y llamada y
         * el valor actual del contador, se sume con lo que el
         * cuadro de texto indique.
         * */

        private int contador;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) //Si es la primera vez que se carga la página
            {
                lblValorActual.Text = "ValorActual: 0";
                if (ViewState["clic"] == null)
                {
                    ViewState["clic"] = 0;
                }
            }
            txtContador.Text = "1";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Se revisa si ya existe el elemento "clic" en el ViewState
            if(ViewState["clic"]!=null)
            {
                contador = (int)ViewState["clic"] + 1;
                lblValorActual.Text = "Valor actual: " + contador;
                ViewState["clic"] = contador;
            }
        }
    }
}