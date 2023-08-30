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
    public partial class connexion : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(@"Data Source=ANOUAR\SQLEXPRESS;Initial Catalog=revesion;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
      

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Org.Checked)
            {
                cn.Open();
                cmd = new SqlCommand("select* from Organisateur", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    if (TextBox1.Text == dr[3].ToString() && TextBox2.Text == dr[4].ToString())
                    {
                        if (Memoires.Checked)
                        {

                            HttpCookie co = new HttpCookie("ex1");
                            co.Values.Add("email", TextBox1.Text);
                            co.Values.Add("pass", TextBox2.Text);
                            co.Expires.AddDays(1);
                            Response.Cookies.Add(co);
                           Session["org"] = dr[0].ToString();
                            Response.Redirect("Acceuil.aspx");

                        }
                        else
                        {
                            Session["org"] = dr[0].ToString();
                            //Response.Redirect("Acceuil.aspx");
                            Response.Redirect("organiser.aspx");
                        }
                    }
                    
                }
                cn.Close();
            }
            if (Prticpa.Checked)
            {
                cn.Open();
                cmd = new SqlCommand("select* from Participant", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    if (TextBox1.Text == dr[3].ToString() && TextBox2.Text == dr[4].ToString())
                    {
                        if (Memoires.Checked)
                        {

                            HttpCookie co = new HttpCookie("ex1");
                            co.Values.Add("email", TextBox1.Text);
                            co.Values.Add("pass", TextBox2.Text);
                            co.Expires.AddDays(1);
                            Response.Cookies.Add(co);
                            Session["org"] = dr[0].ToString();
                            Response.Redirect("Acceuil.aspx");

                        }
                        else
                        {
                            Session["org"] = dr[0].ToString();
                            Response.Redirect("Acceuil.aspx");
                        }
                    }
                    
                }
                cn.Close();
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}