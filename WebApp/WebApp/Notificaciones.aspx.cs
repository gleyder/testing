using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Notificaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { try
            {
                SqlDataSource1.SelectCommand = "SELECT [Mensaje], [Tipo], [Fecha] FROM [Notificaciones] Where [Visualizado] < 2 And [Usuario] = '" + Session["User"].ToString() + "'";
            }
            catch {
                Server.Transfer("Login.aspx");
            }
            
            }
    }
}