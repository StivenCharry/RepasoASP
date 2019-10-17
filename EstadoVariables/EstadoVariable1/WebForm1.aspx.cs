using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstadoVariable1
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        int numero=0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack){
                txtNumero.Text = "0";
                
            }
        }

        protected void txtIncrementar_Click(object sender, EventArgs e)
        {
            if (ViewState["numero"] != null)
            {
                numero = (int)ViewState["numero"] + 1;
               
                txtNumero.Text = numero.ToString();
            }
            ViewState["numero"] = numero;
        }
    }
}