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
    public partial class ProcedurePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataList1.DataSource = baglanti();
            DataList1.DataBind();
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
        public DataTable baglanti()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataTable dtCourse = new DataTable();
            if (connection.State == ConnectionState.Open)
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM cas.service", connection);

                adapter.Fill(dtCourse);
            }
            return dtCourse;
        }

    }
}