using System;
using System.Data.SqlClient;
using System.Web.Security;

namespace plataforma_freelancers.Account
{
    public partial class AccountRegister : System.Web.UI.Page
    {
        protected void Register(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "SHA1");
            string type = ddlUserType.SelectedValue;

            using (SqlConnection conn = new SqlConnection(
                System.Configuration.ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Users (Name, Email, Password, UserType) VALUES (@Name, @Email, @Password, @UserType)", conn);

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Typo", type);

                
            cmd.ExecuteNonQuery();
            }

            lblMsg.Text = "Usuário registrado com sucesso!";
        }
    }
}