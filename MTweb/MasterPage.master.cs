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
                LinkButtonLogout.Visible= true;
            }
            else
            {
                LinkButtonUser.Text = "Login";
                LinkButtonLogout.Visible = false;
            }
        }
    }
    protected void LinkButtonLogout_Click(object sender, EventArgs e)
    {
        Session["user"] = null;
        LinkButtonUser.Text = "Login";
        Response.Redirect("Default.aspx");
    }

    protected void LinkButtonHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");

    }
    protected void LinkButtonUser_Click(object sender, EventArgs e)
    {
            LinkButton linkButton=(LinkButton)sender;
        if(linkButton.Text=="Login") Response.Redirect("Login.aspx"); 
        else Response.Redirect("pro.aspx");
    }

    protected void LinkButtonproduct_Click(object sender, EventArgs e)
    {
        Response.Redirect("Product.aspx");
    }

    protected void LinkButtoncart_Click(object sender, EventArgs e)
    {
        Response.Redirect("Cart.aspx");
    }
}