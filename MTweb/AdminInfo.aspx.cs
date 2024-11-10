using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminAd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GridViewinfoFill();
        }
    }
    public void GridViewinfoFill()
    {
        DataTable dt = Admin.sqlAll();
        GridViewinfo.DataSource = dt;
        GridViewinfo.DataBind();
    }
    protected void GridViewinfo_edit(object sender, GridViewEditEventArgs e)
    {
        GridViewinfo.EditIndex = e.NewEditIndex;
        GridViewinfoFill();
    }

    protected void GridViewinfo_cancel(object sender, GridViewCancelEditEventArgs e)
    {
        GridViewinfo.EditIndex = -1;
        GridViewinfoFill();
    }

    protected void GridViewinfo_Delete(object sender, GridViewDeleteEventArgs e)
    {
        Label email = (Label)GridViewinfo.Rows[e.RowIndex].FindControl("LabelEmail");
        if (email.Text != ((Admin)Session["Admin"]).email)
        {
            Admin.sqlDelete(email.Text);
            GridViewinfoFill();
        }
    }
    protected void GridViewinfo_updat(object sender, GridViewUpdateEventArgs e)
    {
        Label email = (Label)GridViewinfo.Rows[e.RowIndex].FindControl("LabelEmailEdit");
        TextBox fn = (TextBox)GridViewinfo.Rows[e.RowIndex].FindControl("TextBoxFN");
        TextBox password = (TextBox)GridViewinfo.Rows[e.RowIndex].FindControl("TextBoxPassword");
        TextBox phone = (TextBox)GridViewinfo.Rows[e.RowIndex].FindControl("TextBoxPhone");
        Admin.sqlUpdate(email.Text, password.Text, fn.Text, phone.Text);
        GridViewinfo.EditIndex = -1;
        GridViewinfoFill();
    }

    protected void IndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridViewinfo.PageIndex = e.NewPageIndex;
        GridViewinfoFill();
    }
}