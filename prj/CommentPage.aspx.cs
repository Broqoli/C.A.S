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
    public partial class CommentPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                string id1 = Request.QueryString["id"];
                int id2 = Convert.ToInt32(id1);

                string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();
                SqlCommand kmt = new SqlCommand("select * from cas.comment as com inner join cas.workplace as wp on wp.wp_id=com.wp_id inner join cas.person as p on p.user_id=com.user_id where wp.wp_id = @input", connection);
                kmt.Parameters.AddWithValue("@input", id1);
                SqlDataReader dr = kmt.ExecuteReader();
                DataList1.DataSource = dr;
                DataList1.DataBind();
                connection.Close();




                connection.Open();
                SqlCommand kmt2 = new SqlCommand("select wp.wp_name, wp.about,wp.wp_id from cas.workplace as wp where wp.wp_id = @input2", connection);
                kmt2.Parameters.AddWithValue("@input2", id1);
                SqlDataReader dr2 = kmt2.ExecuteReader();
                DataList2.DataSource = dr2;
                DataList2.DataBind();
                connection.Close();
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string id1 = Request.QueryString["id"];
            string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand kmt = new SqlCommand("insert into cas.comment(comment,wp_id,user_id) values(@p1,@p2,1)", connection);
            kmt.Parameters.AddWithValue("@p1", TextBox2.Text);
            kmt.Parameters.AddWithValue("@p2", id1);
            kmt.ExecuteNonQuery();
            connection.Close();

        }
    }
}