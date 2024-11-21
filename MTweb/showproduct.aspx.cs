using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class showproduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) { fill(); }
    }

    private void fill()
    {
        DataTable dt = pruduct.sqlid(Session["IdKind"].ToString());
        DataListpro.DataSource = dt;
        DataListpro.DataBind();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ImageButton imageButton = (ImageButton)DataListpro.Items[i].FindControl("Imagepro");
            imageButton.ImageUrl = "data:image/png;base64," + dt.Rows[i]["Pic"].ToString();
            double price = double.Parse( dt.Rows[i]["Price"].ToString());
            double discount = double.Parse(dt.Rows[i]["Discount"].ToString());
            double priceafter =price*(1.0-discount);

        }
    }
}