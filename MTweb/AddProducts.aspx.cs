using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddProducts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            filldropdownlist();
        }
    }

    private void filldropdownlist()
    {

        DataTable dt = kindproducts.sqlAll();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ListItem item = new ListItem(dt.Rows[i]["Name"].ToString(), dt.Rows[i]["Id"].ToString());
            DropDownListkind.Items.Add(item);
        }
    }

    protected void Buttonadd_Click(object sender, EventArgs e)
    {
        string id = DropDownListkind.SelectedValue;
        string discount = TextBoxDiscount.Text;
        string price = TextBoxprice.Text;
        string name = TextBoxname.Text;
        string id1 = TextBoxID.Text;
        string count = TextBoxcount.Text;
        bool ok = true;
        if (RadioButtonNo.Checked)
            ok = false;
        byte[] by= FileUploadpic.FileBytes;
        string pic = Convert.ToBase64String(by);
        if (discount != "" && price != "" && name != "" && id1 != "" && count != "")
        {
            Labelerro.Visible = false;
            pruduct.sqlInsert(id1, id, price, discount, name, pic, count, ok);
        }
        else Labelerro.Visible = true;
    }
}