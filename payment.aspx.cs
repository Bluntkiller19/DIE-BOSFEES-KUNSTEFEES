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
    public partial class payment : System.Web.UI.Page
    {
        string strconnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\konsert.mdf;Integrated Security=True";
        public SqlConnection sqlcon;
        public DataSet ds;
        public SqlDataAdapter adapter;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                Response.Redirect("Login.aspx");


            SqlCommand cmd;
            string sql;
            sqlcon = new SqlConnection(strconnection);
            adapter = new SqlDataAdapter();
            ds = new DataSet();

            sqlcon.Open();
            sql = "SELECT * FROM Bosfees Where payed = 'Later'";
            cmd = new SqlCommand(sql, sqlcon);
            adapter.SelectCommand = cmd;

            adapter.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            sqlcon.Close();
        }

        protected void btnDates_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }
    }
}