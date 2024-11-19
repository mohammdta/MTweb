using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        byte[] by = FileUpload1.FileBytes;
        string pic = Convert.ToBase64String(by);

            string sql = "UPDATE [Admin] SET [Pic] = @Pic  WHERE [Id] = @Id";
            string[] parameters = { "@Pic", "@Id" };
            string[] values = { pic, TextBox1.Text };
            Dbase.ChangeTable(sql, parameters, values, "Tcehpc.accdb");

    }
}