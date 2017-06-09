using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyectopruebarepovisual
{
    public partial class wfLeer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {

            lblMostrar.Text = "Este es un mensaje de prueba en la etiqueta de fernando";
            timer.Enabled = true;
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {

            lblMostrar.Text = string.Empty;
            timer.Enabled = false;
        }

        protected void btnMetodo_Click(object sender, EventArgs e)
        {

            usuarioDatos dc = new usuarioDatos();

            lblMetodo.Text = dc.publicarMensaje();

        }
    }
}