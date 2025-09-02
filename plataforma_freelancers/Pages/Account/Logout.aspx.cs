using System;

namespace plataforma_freelancers.Account
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["jwt"] != null)
            {
                Response.Cookies["jwt"].Expires = DateTime.Now.AddDays(-1);
            }

            Response.Redirect("~/Pages/Account/Login.aspx");
        }
    }
}