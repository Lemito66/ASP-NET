using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlBulletList
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BulletedList3_Click(object sender, BulletedListEventArgs e)
        {
            string cad;
            ListItem lb = blCiudades.Items[e.Index];
            cad = "Índice: " + e.Index + ", ";
            cad += "Texto: " + lb.Text + ", ";
            cad += "Value: " + lb.Value;
            lblCiudades.Text = cad;
        }
    }
}