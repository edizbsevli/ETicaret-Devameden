using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using WebApplication1.classes;

namespace WebApplication1
{
    public partial class Kayıtol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            SqlCommand commandRegister = new SqlCommand("Insert into Users (Username,Email,Password) values (@pusername,@pmail,@ppass)",SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            string newPass = Class1.ComputeSha256Hash(tboxUsername.Text);
            commandRegister.Parameters.AddWithValue("@pusername", tboxUsername.Text);
            commandRegister.Parameters.AddWithValue("@pmail",tboxMail.Text);
            commandRegister.Parameters.AddWithValue("@ppass", tboxPassword.Text);

            commandRegister.ExecuteNonQuery();
            Response.Redirect("default.aspx");
        }

        private void ClearFields()
        {
            tboxUsername.Text = "";
            tboxPassword.Text = "";
            tboxMail.Text = "";
        }
    }
}
