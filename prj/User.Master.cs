using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;//contain classes for accessing and managing data from diverse
using System.Configuration;

namespace Coiffeur_Appointment_System
{
    public partial class User : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           /* DropDownList dd = (DropDownList)FindControl("DropDownList" + 1);

            string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand kmt = new SqlCommand("select * from cas.city", connection);
            SqlDataReader dr = kmt.ExecuteReader();
            dd.DataTextField = "city";
            dd.DataValueField = "city_id";

            dd.DataSource = dr;
            dd.DataBind();
            connection.Close();*/

        }
    }
}