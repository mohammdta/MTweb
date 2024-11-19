using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Product : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            filllist();
        }
    }

    private void filllist()
    {
        DataTable dt = kindproducts.sqlAll();
        DataListpro.DataSource = dt;
        DataListpro.DataBind();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ImageButton imageButton = (ImageButton)DataListpro.Items[i].FindControl("ImageButton1");
            imageButton.ImageUrl = "data:image/png;base64," + dt.Rows[i]["Pic"].ToString();
        }
    }


    protected void DataListpro_ItemCommand(object source, DataListCommandEventArgs e)
    {
        Session["IdKind"] =e.CommandArgument.ToString();
        Response.Redirect("showproduct.aspx");
    }
}