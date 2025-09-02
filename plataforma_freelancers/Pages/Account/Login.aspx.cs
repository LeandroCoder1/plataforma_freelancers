using System;
using System.Web;
using plataforma_freelancers.Helpers;

namespace plataforma_freelancers.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if (user == "admin" && pass == "123")
            {
                string token = JwtHelper.GenerateToken(user);
                
                var cookie = new HttpCookie("AuthToken", token)
                {
                    HttpOnly = true,
                    Secure = false,
                    Expires = DateTime.Now.AddMinutes(60)
                };
            }
            else
            {
                Response.Write("<script>alert('Usuário ou senha inválidos, tente novamente')<script/>");
            }

        }
    }
}