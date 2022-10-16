using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Project_2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\users.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("select * from users where Email=@Email and Password=@Password", con);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Password", txtpwd.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (dt.Rows.Count > 0)
            {
                Session["user"] = txtEmail.Text;
                Response.Redirect("main.aspx");
                Session.RemoveAll();
            }
            else if (txtEmail.Text == "Admin" && txtpwd.Text == "Admin")
            {
                Session["user"] = "Admin";
                Response.Redirect("Admin.aspx");
                Session.RemoveAll();
            }
            else
            {
                Label1.Visible = true;
            }
        }

        protected void lbtnForget_Click(object sender, EventArgs e)
        {
            Response.Redirect("Forgot password.aspx");
        }

        protected void lbtnCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewUser.aspx");                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
        }
    }
}