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
    public partial class Admin : System.Web.UI.Page
    {
        string strconnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\konsert.mdf;Integrated Security=True";
        public SqlConnection sqlcon;
        public DataSet ds;
        public SqlDataAdapter adapter;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
                lblGreeting.Text = "Welcom back " + Session["user"];
            else
                Response.Redirect("Login.aspx");


            SqlCommand cmd;
            string sql;
            sqlcon = new SqlConnection(strconnection);
            adapter = new SqlDataAdapter();
            ds = new DataSet();

            sqlcon.Open();
            sql = "SELECT * FROM Bosfees";
            cmd = new SqlCommand(sql, sqlcon);
            adapter.SelectCommand = cmd;

            adapter.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            sqlcon.Close();
        }

        protected void btnSysUsers_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminUsers.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

        protected void btnpayments_Click(object sender, EventArgs e)
        {
            Response.Redirect("payment.aspx");
        }
    }
}