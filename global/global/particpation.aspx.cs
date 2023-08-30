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
    public partial class particpation : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(@"Data Source=ANOUAR\SQLEXPRESS;Initial Catalog=revesion;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr, dr1;
        DataTable dt = new DataTable();

        protected void Button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("insert into Participant values(" + TextBox1.Text + ",'" + DateTime.Parse(TextBox2.Text).Day + "'," + float.Parse(TextBox3.Text) + "," + int.Parse(DropDownList1.SelectedValue) + "" + int.Parse(DropDownList2.SelectedValue) + ",)", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("pagecategorie.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
    }
}