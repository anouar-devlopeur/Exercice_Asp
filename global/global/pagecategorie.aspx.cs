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
    public partial class pagecategorie : System.Web.UI.Page
    {  SqlConnection cn = new SqlConnection(@"Data Source=ANOUAR\SQLEXPRESS;Initial Catalog=revesion;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("select* from categorie", cn);
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            cn.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[1].Text;
            TextBox2.Text = GridView1.SelectedRow.Cells[2].Text;
         
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            TextBox1.Text = GridView1.Rows[e.NewSelectedIndex].Cells[1].Text;
            TextBox2.Text = GridView1.Rows[e.NewSelectedIndex].Cells[2].Text;
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into categorie values(" + int.Parse(TextBox1.Text) + ",'" + TextBox2.Text +  "')", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}