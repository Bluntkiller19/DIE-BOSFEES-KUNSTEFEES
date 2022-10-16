using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Project_2
{
    public partial class user_bookings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                if (Session["user"] == null)
                Response.Redirect("Login.aspx");


            SqlCommand sqlcmd;
            SqlConnection cnn = new SqlConnection();
            DataSet ds;
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter();
            ds = new DataSet();

            cnn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\konsert.mdf;Integrated Security=True";
            cnn.Open();
            sqlcmd = new SqlCommand();
            sqlcmd.CommandText = "SELECT * FROM [Bosfees] WHERE Email = @Email";
            sqlcmd.Parameters.AddWithValue("@Email", Session["user"].ToString());
            sqlcmd.Connection = cnn;
            //sqlcmd.ExecuteNonQuery();
            adapter.SelectCommand = sqlcmd;
            adapter.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            cnn.Close();



        }

        protected void btnMybookings_Click(object sender, EventArgs e)
        {
            Response.Redirect("main.aspx");
        }
    }
}