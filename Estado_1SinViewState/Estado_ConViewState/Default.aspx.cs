using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Estado_ConViewState
{
    /*
     * Este ejemplo ilustra el hecho de que HTTP no mantiene el estado entre
     * llamada y llamada al servidor, pues la variable contador no se incrementa
     * si no que siempre que se cargue la página inicia con 0
     * Si se requiere que el contador se mantenga luego de presionar el botón,
     * es decir cuando se vuelva a llamar al servidor, es necesario mantener
     * el estado de la página y para eso hay algunas formas.
     * */
    public partial class _Default : Page
    {
        public int contador;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) //Si es la primera vez que se carga la página
                txtContador.Text = "0";

        }

        protected void btnIncrementar_Click(object sender, EventArgs e)
        {
            contador++;
            txtContador.Text = Convert.ToString(contador);
        }
    }
}