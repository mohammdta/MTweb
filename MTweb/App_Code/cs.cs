using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
/// /// </summary>
public class pruduct
{
    public string ID { get; set; }
    public string pic { get; set; }
    public string kindproducts { get; set; }
    public string price { get; set; }
    public string discount { get; set; }
    public string name { get; set; }
    public static void sqlInsert(string ID, string kindproducts, string price ,string discount, string name,string pic)
    {
        string sql = "INSERT INTO [products] ([ID], [kindproducts], [price], [discount], [name], [pic]) VALUES (@ID, @kindproducts, @price, @discount, @name, @pic)";
        string[] parameters = { "@ID", "@kindproducts", "@price", "@discount", "@name", "@pic" };
        string[] values = { ID, kindproducts, price, discount,name,pic};
        Dbase.ChangeTable(sql, parameters, values, "Tcehpc.accdb");
    }

}
public class kindpruduct
{
    public string ID { get; set; }
    public string name { get; set; }
    public static DataTable sqlAll()
    {
        string sql = "SELECT * FROM [kindproduct]";
        string[] parmert = { };
        string[] values = { };
        return Dbase.SelectFromTable(sql, parmert, values, "Tcehpc.accdb");
    }
}

public class Admin
{
    public string fn { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    public string password { get; set; }
    public Admin()
    {
    }
    public static Admin sqlLogin(string email, string pass)
    {
        Admin x = new Admin();
        x.email = email;
        x.password = pass;
        string sql = "SELECT * FROM [Admin] Where [email]=@email and [password]=@password";
        string[] parmert = { "@email", "@password" };
        string[] values = { x.email, x.password };
        DataTable dt = Dbase.SelectFromTable(sql, parmert, values, "Tcehpc.accdb");
        if (dt.Rows.Count == 1)
        {
            x.fn = dt.Rows[0]["fn"].ToString();
            x.phone = dt.Rows[0]["phone"].ToString();
        }
        else x = null;
        return x;
    }
    public static bool sqlCheck(string email)
    {
        user x = new user();
        x.email = email;
        string sql = "SELECT * FROM [Admin] Where [email]=@email";
        string[] parmert = { "@email" };
        string[] values = { x.email };
        DataTable dt = Dbase.SelectFromTable(sql, parmert, values, "Tcehpc.accdb");
        if (dt.Rows.Count == 1)
            return true;
        return false;
    }
    public static void sqlInsert(string email, string pass, string fn, string phone)
    {
        user x = new user();
        x.email = email;
        x.password = pass;
        x.fn = fn;
        x.phone = phone;
        string sql = "INSERT INTO [Admin] ([email], [password], [fn], [phone]) VALUES (@Email, @Password, @Fn, @Phone)";
        string[] parameters = { "@Email", "@Password", "@Fn", "@Phone" };
        string[] values = { x.email, x.password, x.fn, x.phone };
        Dbase.ChangeTable(sql, parameters, values, "Tcehpc.accdb");
    }
    public static void sqlUpdate(string email, string pass, string fn, string phone)
    {
        user x = new user();
        x.email = email;
        x.password = pass;
        x.fn = fn;
        x.phone = phone;
        string sql = "UPDATE [Admin] SET [password] = @Password, [fn] = @Fn, [phone] = @Phone WHERE [email] = @Email";
        string[] parameters = { "@Password", "@Fn", "@Phone", "@Email" };
        string[] values = { x.password, x.fn, x.phone, x.email };
        Dbase.ChangeTable(sql, parameters, values, "Tcehpc.accdb");
    }
    public static DataTable sqlAll()
    {
        string sql = "SELECT * FROM [Admin]";
        string[] parmert = { };
        string[] values = { };
        return Dbase.SelectFromTable(sql, parmert, values, "Tcehpc.accdb");
    }
    public static void sqlDelete(string email)
    {
        string sql = "DELETE FROM [Admin] WHERE email= '";
        sql += email + "'";
        string[] parmert = { };
        string[] values = { };
        Dbase.SelectFromTable(sql, parmert, values, "Tcehpc.accdb");
    }
}
public class user
{
    public string fn { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    public string password { get; set; }
    public user()
    {
    }
    public static user sqlLogin(string email, string pass)
    {
        user x = new user();
        x.email = email;
        x.password = pass;
        string sql = "SELECT * FROM [User] Where [email]=@email and [password]=@password";
        string[] parmert = { "@email", "@password" };
        string[] values = { x.email, x.password };
        DataTable dt = Dbase.SelectFromTable(sql, parmert, values, "Tcehpc.accdb");
        if (dt.Rows.Count == 1)
        {
            x.fn = dt.Rows[0]["fn"].ToString();
            x.phone = dt.Rows[0]["phone"].ToString();
        }
        else x = null;
        return x;
    }
    public static bool sqlCheck(string email)
    {
        user x = new user();
        x.email = email;
        string sql = "SELECT * FROM [User] Where [email]=@email";
        string[] parmert = { "@email" };
        string[] values = { x.email };
        DataTable dt = Dbase.SelectFromTable(sql, parmert, values, "Tcehpc.accdb");
        if (dt.Rows.Count == 1)
            return true;
        return false;
    }
    public static void sqlInsert(string email, string pass, string fn, string phone)
    {
        user x = new user();
        x.email = email;
        x.password = pass;
        x.fn = fn;
        x.phone = phone;
        string sql = "INSERT INTO [User] ([email], [password], [fn], [phone]) VALUES (@Email, @Password, @Fn, @Phone)";
        string[] parameters = { "@Email", "@Password", "@Fn", "@Phone" };
        string[] values = { x.email, x.password, x.fn, x.phone };
        Dbase.ChangeTable(sql, parameters, values, "Tcehpc.accdb");
    }
    public static void sqlUpdateUser(string email, string pass, string fn, string phone)
    {
        user x = new user();
        x.email = email;
        x.password = pass;
        x.fn = fn;
        x.phone = phone;
        string sql = "UPDATE [User] SET [password] = @Password, [fn] = @Fn, [phone] = @Phone WHERE [email] = @Email";
        string[] parameters = { "@Password", "@Fn", "@Phone", "@Email" };
        string[] values = { x.password, x.fn, x.phone, x.email };
        Dbase.ChangeTable(sql, parameters, values, "Tcehpc.accdb");
    }
    public static DataTable sqlAll()
    {
        string sql = "SELECT * FROM [User]";
        string[] parmert = { };
        string[] values = { };
        return Dbase.SelectFromTable(sql, parmert, values, "Tcehpc.accdb");
    }
    public static void sqlDelete(string email)
    {
        string sql = "DELETE FROM [User] WHERE email= '";
        sql += email + "'";
        string[] parmert = { };
        string[] values = { };
        Dbase.SelectFromTable(sql, parmert, values, "Tcehpc.accdb");
    }
}