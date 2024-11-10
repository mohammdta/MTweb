using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButtonSignUp_Click(object sender, EventArgs e)
    {
        Response.Redirect("Signup.aspx");
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        user x = user.sqlLogin(txtEmail.Text, txtPassword.Text);
        Admin Admin = Admin.sqlLogin(txtEmail.Text, txtPassword.Text);
        if (x!=null)
        {
            Session["user"] = x;
            Response.Redirect("Default.aspx");
        }
        else if(Admin != null)
        {
            Session["Admin"] = Admin;
            Response.Redirect("DefaultA.aspx");
        }
        else lblMessage.Text = "UserName or Password is incorrect"; 
    }
}