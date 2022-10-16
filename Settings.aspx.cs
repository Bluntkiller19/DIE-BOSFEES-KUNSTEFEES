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
    public partial class Settings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
                Label1.Text = "" + Session["user"];
            else
                Response.Redirect("Login.aspx");
        }



        protected void btnMybookings_Click(object sender, EventArgs e)
        {
            Response.Redirect("main.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

            

        }

        protected void btnDelete_Click1(object sender, EventArgs e)
        {
            string confirmValue = Request.Form["confirm_value"];

            if (confirmValue == "Yes")
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You clicked YES!')", true);
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\users.mdf;Integrated Security=True");

                string sqlStatement = "DELETE FROM users WHERE Email = @Email";

                try
                {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlStatement, connection);
                cmd.Parameters.AddWithValue("@Email", Session["user"].ToString());
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                }
                finally
                {
                connection.Close();
                Session.RemoveAll();
                Session.Abandon();
                Response.Redirect("Login.aspx");
                }
                
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You clicked NO!')", true);
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string confirmValue = Request.Form["confirm_value"];
            if (confirmValue == "Yes")
            {
                
                if (txtpwd.Text == txtCpwd.Text)
                {
                    SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\users.mdf;Integrated Security=True");
                    string statement = "UPDATE users SET Password = @password WHERE Email = @Email";
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(statement, cnn);
                    cmd.Parameters.AddWithValue("@password", txtpwd.Text);
                    cmd.Parameters.AddWithValue("@Email", Session["user"].ToString());
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('password succesfully changed!')", true);
                }
                else
                    Label2.Visible = true;
                

            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('request canceled')", true);
            }
        }
    }
}