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
    public partial class AppointmentPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
            string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand kmt = new SqlCommand("select (p.first_name+' '+p.last_name) as name, s.service_name, w.description from cas.person as p inner join cas.work as w on w.staff_id = p.user_id inner join cas.service as s on s.service_id = w.service_id", connection);
            SqlDataReader dr = kmt.ExecuteReader();
            DataList1.DataSource = dr;
            DataList1.DataBind();
            connection.Close();

            

        }
    }
}