using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void Buttonsignup_Click(object sender, EventArgs e)
    {
        if (user.sqlCheck(TextBoxEmail.Text))
        {
            user.sqlInsert(TextBoxEmail.Text, TextBoxpass.Text, TextBoxFullname.Text, TextBoxPhone.Text);
            Response.Redirect("Login.aspx");
        }
        else Labelerro.Visible=true;
    }
}