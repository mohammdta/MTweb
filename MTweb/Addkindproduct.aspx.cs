using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Addkindproduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonAppKind_Click(object sender, EventArgs e)
    {
        if (TextBoxName.Text!="")
        {
            byte[] by = FileUploadpic.FileBytes;
            string pic = Convert.ToBase64String(by);
            kindproducts.sqlInsert(TextBoxName.Text, pic);
            Response.Redirect("Addkindproduct.aspx");
        }
        else Labelerro.Visible = true;
    }
}