using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlCheckBox
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTotal_Click(object sender, EventArgs e)
        {
            lblTotal.Text = "Total: $" + Math.Round(CalcularTotal(), 2);
        }

        //Calcula y devuelve el total de la cuenta
        double CalcularTotal()
        {
            double total = 0;
            double iva;
            total = Convert.ToDouble(txtPrecio.Text);
            if (chkPapas.Checked)
                total += Convert.ToDouble(txtPapas.Text);
            if (chkBebida.Checked)
                total += Convert.ToDouble(txtBebida.Text);
            if (chkPostre.Checked)
                total += Convert.ToDouble(txtPostre.Text);
            if (chkIva.Checked)
            {
                iva = total * Convert.ToDouble(txtIva.Text) / 100;
                total = iva + total;
            }
            return total;
        }

        protected void chkIva_CheckedChanged(object sender, EventArgs e)
        {
            lblTotal.Text = "Total: $" + Math.Round(CalcularTotal(), 2);
        }
    }
}