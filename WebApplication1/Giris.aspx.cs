using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.classes;
using System.Web.UI.HtmlControls;

namespace WebApplication1
{
    public partial class Kayıt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand commandlogin = new SqlCommand("Select * from Users where Email=@pmail and Password=@ppass", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            string shaPass = Class1.ComputeSha256Hash(tboxPassword.Text);


            commandlogin.Parameters.AddWithValue("@pmail", tboxMail.Text);
            commandlogin.Parameters.AddWithValue("@ppass", tboxPassword.Text);

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(commandlogin);
            
            da.Fill(dt);
            

            if (dt.Rows.Count > 0)
            {
                Response.Write("Giriş Yapıldı");
                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "Refresh";
                meta.Content = "2;url=default.aspx";
                this.Page.Controls.Add(meta);
                
            }
            else
            {
                Response.Write("Mail adresi veya şifre hatalı");
            }
            
        }
    }
}