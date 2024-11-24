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
            Image Image = (Image)DataListpro.Items[i].FindControl("Imagepro");
            Image.ImageUrl = "data:image/png;base64," + dt.Rows[i]["Pic"].ToString();
            double price = double.Parse(dt.Rows[i]["Price"].ToString());
            double discount = double.Parse(dt.Rows[i]["Discount"].ToString());
            Label labelPrice = (Label)DataListpro.Items[i].FindControl("LabelPrice");
            labelPrice.Text = (price * (discount/100)).ToString();
        }
    }
}