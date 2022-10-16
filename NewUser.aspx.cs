using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Project_2
{

    public partial class NewUser : System.Web.UI.Page
    {
        SqlCommand sqlcmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            /*txtEmail.Text = "";
            txtVan.Text = "";
            txtName.Text = "";
            txtpwd.Text = "";
            txtpwdConfirm.Text = "";*/
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        { 
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\users.mdf;Integrated Security=True";
            cnn.Open();
            sqlcmd = new SqlCommand();
            sqlcmd.CommandText = "SELECT * FROM [users] WHERE Email = @Email";
            sqlcmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            sqlcmd.Connection = cnn;
            SqlDataReader rd = sqlcmd.ExecuteReader();

            if (rd.HasRows)
                Label2.Visible = true;
            else if (txtpwd.Text == txtpwdConfirm.Text)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\users.mdf;Integrated Security=True");

                string insert_query = "INSERT INTO users VALUES(@Naam,@Van,@Email,@Password)";
                con.Open();
                sqlcmd = new SqlCommand(insert_query, con);
                sqlcmd.Parameters.AddWithValue("@Naam", txtName.Text);
                sqlcmd.Parameters.AddWithValue("@Van", txtVan.Text);
                sqlcmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                sqlcmd.Parameters.AddWithValue("@Password", txtpwd.Text);
                sqlcmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("Login.Aspx");
            }
            else
                Label1.Visible = true;
        }
    }
}