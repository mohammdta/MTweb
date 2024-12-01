using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fill();
        }
    }

    private void fill()
    {
        string st = ((user)(Session["user"])).Email;
        DataTable dt = cart.sqlGetAllnobuy(st);
        GridViewcart.DataSource = dt;
        GridViewcart.DataBind();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            Label laberprice = (Label)GridViewcart.Rows[i].FindControl("LabelPriceAfter");
            double price = double.Parse(dt.Rows[i]["Price"].ToString());
            double diccount = double.Parse(dt.Rows[i]["Discount"].ToString());
            laberprice.Text = (price/100* diccount).ToString();
            Image Imagepic = (Image)GridViewcart.Rows[i].FindControl("Imagepic");
            Imagepic.ImageUrl = "data:image/png;base64," + dt.Rows[i]["Pic"].ToString();
        }
    }
}