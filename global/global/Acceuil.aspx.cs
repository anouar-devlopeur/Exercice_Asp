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
    public partial class Acceuil : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(@"Data Source=ANOUAR\SQLEXPRESS;Initial Catalog=revesion;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["org"] == null)
            {
                Response.Redirect("connexion.aspx");
            }
            else
            {
                Label2.Text = Session["org"].ToString();
            }
            if (Request.Cookies["ex1"]!=null)
            {
 HttpCookie x = Request.Cookies["ex1"];
            Label1.Text = x.Values.Get("email").ToString();
            }
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
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
         
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("select c.idCamp,c.nomCamp,count(c.montantCamp)as montant,c.nomBeneficiare from Campagne c,categorie cat,Organisateur o where c.idCat = " + DropDownList1.SelectedValue + " and c.idOrg = " + Label2.Text + " group by c.idCamp, c.nomCamp, c.nomBeneficiare", cn);
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
    
}