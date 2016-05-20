using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int Noti = HayNotificaciones(Session["User"].ToString());
                if (Noti > 0)
                {
                    Label1.Text = "Tienes " + Noti.ToString() + " Nuevas Notificaciones";
                    HyperLink1.NavigateUrl = "Notificaciones.aspx";
                }
                else
                {
                    Label1.Text = "No Hay Notificaciones Disponibles";
                }
            }
            catch {}
        }

        private int HayNotificaciones(string user) {
            SqlConnection con = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Notificaciones where Usuario = '" + user + "'", con);
            con.Open();

            int cont = 0;
            IDataReader dataReader = cmd.ExecuteReader();
            {
                //Loop through your results
                while (dataReader.Read())
                {
                    if (Convert.ToInt32(dataReader["Visualizado"]) == 0) {
                        cont++;
                    }
                }

                return cont;
                
            }
        }
    }
}