



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPageAdmin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            if (Session["admin"] != null)
                LinkButtonUser.Text = ((Admin)Session["admin"]).Fn;

    }

    protected void LinkButtonHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("DefaultA.aspx");
    }

    protected void LinkButtonUser_Click(object sender, EventArgs e)
    {
        Response.Redirect("proA.aspx");
    }

    protected void LinkButtonUsers_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserInfo.aspx");
    }

    protected void LinkButtonAdmin_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminInfo.aspx");
    }

    protected void LinkButtonLogut_Click(object sender, EventArgs e)
    {
        Session["admin"] = null;
        Response.Redirect("Default.aspx");
    }

    protected void LinkButtonAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddAcount.aspx");

    }

    protected void LinkButtonAddproduct_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddProducts.aspx");

    }

    protected void LinkButtonAddKindProduct_Click(object sender, EventArgs e)
    {
        Response.Redirect("Addkindproduct.aspx");

    }

    protected void LinkButtonproduct_Click(object sender, EventArgs e)
    {
        Response.Redirect("Product.aspx"); 
    }
}
