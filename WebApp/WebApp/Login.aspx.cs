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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private String VerificarCuenta(string user, string pass)
        {
            String Passworddd = null;
            SqlConnection con = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios where Matricula = '" + user + "'", con);
            con.Open();

            IDataReader dataReader = cmd.ExecuteReader();
            {
                //Loop through your results
                while (dataReader.Read())
                {
                    Passworddd = (Convert.ToString(dataReader["Password"]));
                }

                if (Passworddd != null)
                {
                    if (Passworddd == pass)
                    {
                        return user;
                    }
                    else { return null; }
                }
                else { return null; }
            }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string usuario = VerificarCuenta(TextMatricula.Text, TextPass.Text);

            Session["User"] = usuario;

            if (usuario != null)
            {
                //ir a otra pagina
                Server.Transfer("Home.aspx");
            }
        }
    }
}