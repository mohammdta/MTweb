using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddAcount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonU_Click(object sender, EventArgs e)
    {
        if (!user.sqlCheck(TextBoxEmail.Text) && !Admin.sqlCheck(TextBoxEmail.Text))
        {
            user.sqlInsert(TextBoxEmail.Text, TextBoxpass.Text, TextBoxFullname.Text, TextBoxPhone.Text);
            Response.Redirect("AddAcount.aspx");
        }
        else Labelerro.Visible = true;
    }

    protected void ButtonA_Click(object sender, EventArgs e)
    {
        if (!Admin.sqlCheck(TextBoxEmail.Text) && !user.sqlCheck(TextBoxEmail.Text))
        {
            Admin.sqlInsert(TextBoxEmail.Text, TextBoxpass.Text, TextBoxFullname.Text, TextBoxPhone.Text);
            Response.Redirect("AddAcount.aspx");
        }
        else Labelerro.Visible = true;
    }
}