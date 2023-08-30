using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace global
{
    public partial class inscrire : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(@"Data Source=ANOUAR\SQLEXPRESS;Initial Catalog=revesion;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into Participant values("+int.Parse( TextBox1.Text)+",'"+TextBox2.Text+"','"+TextBox3.Text+"','"+TextBox4.Text+"','"+TextBox5.Text+"')", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}