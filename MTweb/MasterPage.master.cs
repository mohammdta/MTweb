using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if ((user)Session["user"] != null)
            {
                LinkButtonUser.Text = ((user)Session["user"]).Fn;
                LinkButtonUser.Visible = true;
                LinkButtonLogin.Visible = false;
            }
            else
            {
                LinkButtonUser.Visible = false;
                LinkButtonLogin.Visible = true;
            }
            
        }
    }
    protected void LinkButtonLogin_Click(object sender, EventArgs e)
    {
            Response.Redirect("Login.aspx");
    }
    protected void LinkButtonLogout_Click(object sender, EventArgs e)
    {
        Session["user"] = null;
        LinkButtonLogin.Text = "Login";
        Response.Redirect("Default.aspx");
    }

    protected void LinkButtonHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");

    }
    protected void LinkButtonUser_Click(object sender, EventArgs e)
    {
        Response.Redirect("pro.aspx");
    }
}