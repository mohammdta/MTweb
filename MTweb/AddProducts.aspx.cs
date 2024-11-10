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
        DataTable dt = kindpruduct.sqlAll();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ListItem item = new ListItem(dt.Rows[i]["name"].ToString(), dt.Rows[i]["ID"].ToString());
            DropDownListkind.Items.Add(item);
        }
    }

    protected void Buttonadd_Click(object sender, EventArgs e)
    {
        string id = DropDownListkind.SelectedValue;
        string dis = TextBoxdis.Text;
        string price = TextBoxprice.Text;
        string name = TextBoxname.Text;
        string id1 = TextBoxID.Text;
        if (dis != "" && price != "" && name != "" && id1 != "")
        {
            Labelerro.Visible = false;
            pruduct.sqlInsert(id1,id,price,dis,name);
        }
        else Labelerro.Visible = true;
    }
}