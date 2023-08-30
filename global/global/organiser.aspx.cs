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
    public partial class organiser : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(@"Data Source=ANOUAR\SQLEXPRESS;Initial Catalog=revesion;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr,dr1;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cn.Open();
                cmd = new SqlCommand("select* from categorie", cn);
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                DropDownList1.DataSource = dt;
                DropDownList1.DataTextField = "nomcat";
                DropDownList1.DataValueField = "idCat";
                DropDownList1.DataBind();
                cn.Close();
                cn.Open();
                cmd = new SqlCommand("select* from Organisateur", cn);
                dr1 = cmd.ExecuteReader();
                dt1.Load(dr1);
                DropDownList2.DataSource = dt1;
                DropDownList2.DataTextField = "nomOrg";
                DropDownList2.DataValueField = "idOrg";
                DropDownList2.DataBind();
                cn.Close();
            }
            if (Session["org"] == null)
            {
                Response.Redirect("connexion.aspx");
            }
            else
            {
                var res= Session["org"].ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into Campagne values(" + int.Parse(TextBox1.Text) + "," +
                "'" + TextBox2.Text + "','" + TextBox3.Text + "','" + DateTime.Parse( TextBox4.Text).Day + "','"
                + DateTime.Parse(TextBox5.Text )+ "',"+float.Parse(TextBox6.Text)+",'"+TextBox7.Text+"','"+TextBox8.Text+
                "','"+DateTime.Parse(TextBox9.Text)+"',"+DropDownList1.SelectedValue+","+DropDownList2.SelectedValue+")", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}