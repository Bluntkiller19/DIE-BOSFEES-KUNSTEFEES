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
    public partial class main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
                Label1.Text = "" + Session["user"];
            else
                Response.Redirect("Login.aspx");
            
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

        protected void btnSettings_Click(object sender, EventArgs e)
        {
            Response.Redirect("Settings.aspx");
        }

        protected void Btnbook_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtSurname.Text != "" && rbtnNow.Checked == true && children.SelectedIndex > 0 && Adult.SelectedIndex > 0)
            {
                if (children.SelectedValue.ToString() == "0" && Adult.SelectedValue.ToString() == "0")
                {
                    Label6.Text = "You must buy a ticket you cant buy 0 tickets";
                    Label6.Visible = true;
                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\konsert.mdf;Integrated Security=True");
                    SqlCommand sqlcmd;

                    con.Open();
                    string insert_query = "INSERT INTO Bosfees VALUES(@Name,@Surname,@Email,@Childrentickets,@Adulttickets,@payed)";

                    sqlcmd = new SqlCommand(insert_query, con);
                    sqlcmd.Parameters.AddWithValue("@Name", txtName.Text);
                    sqlcmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                    sqlcmd.Parameters.AddWithValue("@Email", Session["user"].ToString());
                    sqlcmd.Parameters.AddWithValue("@Childrentickets", children.Text);
                    sqlcmd.Parameters.AddWithValue("@Adulttickets", Adult.Text);
                    sqlcmd.Parameters.AddWithValue("@payed", rbtnNow.Text);
                    sqlcmd.ExecuteNonQuery();
                    con.Close();
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('booking was succesfull!')", true);
                    txtName.Text = "";
                    txtSurname.Text = "";
                    children.SelectedIndex = 0;
                    Adult.SelectedIndex = 0;
                    rbtnNow.Checked = false;
                }
            }
            else if (txtName.Text != "" && txtSurname.Text != "" && rbtnLater.Checked == true && children.SelectedIndex > 0 && Adult.SelectedIndex > 0)
            {
                if (children.SelectedValue.ToString() == "0" && Adult.SelectedValue.ToString() == "0")
                {
                    Label6.Text = "You must buy a ticket you cant buy 0 tickets";
                    Label6.Visible = true;
                }
                else
                {
                    SqlCommand sqlcmd;
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\konsert.mdf;Integrated Security=True");

                    string insert_query = "INSERT INTO Bosfees VALUES(@Name,@Surname,@Email,@Childrentickets,@Adulttickets,@payed)";
                    con.Open();
                    sqlcmd = new SqlCommand(insert_query, con);
                    sqlcmd.Parameters.AddWithValue("@Name", txtName.Text);
                    sqlcmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                    sqlcmd.Parameters.AddWithValue("@Email", Session["user"].ToString());
                    sqlcmd.Parameters.AddWithValue("@Childrentickets", children.Text);
                    sqlcmd.Parameters.AddWithValue("@Adulttickets", Adult.Text);
                    sqlcmd.Parameters.AddWithValue("@payed", rbtnLater.Text);
                    sqlcmd.ExecuteNonQuery();
                    con.Close();
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('booking was succesfull!')", true);
                    txtName.Text = "";
                    txtSurname.Text = "";
                    children.SelectedIndex = 0;
                    Adult.SelectedIndex = 0;
                    rbtnLater.Checked = false;
                }
            }
            else
                Label6.Visible = true;
        }

        protected void btnbookingsmade_Click(object sender, EventArgs e)
        {
            Response.Redirect("user bookings.aspx");
        }
    }
}