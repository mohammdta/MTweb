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
    public string Id { get; set; }
    public string Pic { get; set; }
    public string KindProducts { get; set; }
    public string Price { get; set; }
    public string Discount { get; set; }
    public string Name { get; set; }
    public string Count { get; set; }
    public bool Private { get; set; }
    public static void sqlInsert(string Id, string KindProducts, string Price, string Discount, string Name, string Pic, string Count, bool Private)
    {
        string sql = "INSERT INTO [products] ([Id], [KindProducts], [Price], [Discount], [Name], [Pic], [Count], [Private]) VALUES (@Id, @KindProducts, @Price, @Discount, @Name, @Pic, @Count, @Private)";
        string[] parameters = { "@Id", "@KindProducts", "@price", "@Discount", "@name", "@Pic", "@Count", "@Private" };
        string[] values = { Id, KindProducts, Price, Discount, Name, Pic, Count, Private.ToString() };
        Dbase.ChangeTable(sql, parameters, values, "Tcehpc.accdb");
    }

}
public class kindproducts
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Pic { get; set; }
    public static void sqlInsert( string Name, string Pic)
    {
        string sql = "INSERT INTO [kindproduct] ([Name], [Pic]) VALUES ( @Name, @Pic)";
        string[] parameters = { "@Name", "@Pic" };
        string[] values = { Name, Pic };
        Dbase.ChangeTable(sql, parameters, values, "Tcehpc.accdb");
    }
    public static DataTable sqlAll()
    {
        string sql = "SELECT * FROM [kindproduct]";
        string[] parmert = { };
        string[] values = { };
        return Dbase.SelectFromTable(sql, parmert, values, "Tcehpc.accdb");
    }    
    public static bool sqlCheck(string Id)
    {
        string sql = "SELECT * FROM [kindproduct] Where [Id]=@Id";
        string[] parmert = { "@Id" };
        string[] values = { Id };
        DataTable dt = Dbase.SelectFromTable(sql, parmert, values, "Tcehpc.accdb");
        if (dt.Rows.Count == 1)
            return true;
            return false;
    }
}

public class Admin
{
    public string Fn { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string PassWord { get; set; }
    public Admin()
    {
    }
    public static Admin sqlLogin(string Email, string PassWord)
    {
        Admin x = new Admin();
        x.Email = Email;
        x.PassWord = PassWord;
        string sql = "SELECT * FROM [Admin] Where [Email]=@Email and [PassWord]=@PassWord";
        string[] parmert = { "@Email", "@PassWord" };
        string[] values = { x.Email, x.PassWord };
        DataTable dt = Dbase.SelectFromTable(sql, parmert, values, "Tcehpc.accdb");
        if (dt.Rows.Count == 1)
        {
            x.Fn = dt.Rows[0]["Fn"].ToString();
            x.Phone = dt.Rows[0]["Phone"].ToString();
        }
        else x = null;
        return x;
    }
    public static bool sqlCheck(string Email)
    {
        string sql = "SELECT * FROM [Admin] Where [Email]=@Email";
        string[] parmert = { "@Email" };
        string[] values = { Email };
        DataTable dt = Dbase.SelectFromTable(sql, parmert, values, "Tcehpc.accdb");
        if (dt.Rows.Count == 1)
            return true;
        return false;
    }
    public static void sqlInsert(string Email, string Pass, string Fn, string Phone)
    {
        Admin x = new Admin();
        x.Email = Email;
        x.PassWord = Pass;
        x.Fn = Fn;
        x.Phone = Phone;
        string sql = "INSERT INTO [Admin] ([Email], [PassWord], [Fn], [Phone]) VALUES (@Email, @PassWord, @Fn, @Phone)";
        string[] parameters = { "@Email", "@PassWord", "@Fn", "@Phone" };
        string[] values = { x.Email, x.PassWord, x.Fn, x.Phone };
        Dbase.ChangeTable(sql, parameters, values, "Tcehpc.accdb");
    }
    public static void sqlUpdate(string Email, string pass, string Fn, string Phone)
    {
        user x = new user();
        x.Email = Email;
        x.PassWord = pass;
        x.Fn = Fn;
        x.Phone = Phone;
        string sql = "UPDATE [Admin] SET [PassWord] = @PassWord, [Fn] = @Fn, [Phone] = @Phone WHERE [Email] = @Email";
        string[] parameters = { "@PassWord", "@Fn", "@Phone", "@Email" };
        string[] values = { x.PassWord, x.Fn, x.Phone, x.Email };
        Dbase.ChangeTable(sql, parameters, values, "Tcehpc.accdb");
    }
    public static DataTable sqlAll()
    {
        string sql = "SELECT * FROM [Admin]";
        string[] parmert = { };
        string[] values = { };
        return Dbase.SelectFromTable(sql, parmert, values, "Tcehpc.accdb");
    }
    public static void sqlDelete(string Email)
    {
        string sql = "DELETE FROM [Admin] WHERE Email= '";
        sql += Email + "'";
        string[] parmert = { };
        string[] values = { };
        Dbase.SelectFromTable(sql, parmert, values, "Tcehpc.accdb");
    }
}
public class user
{
    public string Fn { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string PassWord { get; set; }
    public user()
    {
    }
    public static user sqlLogin(string Email, string pass)
    {
        user x = new user();
        x.Email = Email;
        x.PassWord = pass;
        string sql = "SELECT * FROM [User] Where [Email]=@Email and [PassWord]=@PassWord";
        string[] parmert = { "@Email", "@PassWord" };
        string[] values = { x.Email, x.PassWord };
        DataTable dt = Dbase.SelectFromTable(sql, parmert, values, "Tcehpc.accdb");
        if (dt.Rows.Count == 1)
        {
            x.Fn = dt.Rows[0]["Fn"].ToString();
            x.Phone = dt.Rows[0]["Phone"].ToString();
        }
        else x = null;
        return x;
    }
    public static bool sqlCheck(string Email)
    {
        user x = new user();
        x.Email = Email;
        string sql = "SELECT * FROM [User] Where [Email]=@Email";
        string[] parmert = { "@Email" };
        string[] values = { x.Email };
        DataTable dt = Dbase.SelectFromTable(sql, parmert, values, "Tcehpc.accdb");
        if (dt.Rows.Count == 1)
            return true;
        return false;
    }
    public static void sqlInsert(string Email, string pass, string Fn, string Phone)
    {
        user x = new user();
        x.Email = Email;
        x.PassWord = pass;
        x.Fn = Fn;
        x.Phone = Phone;
        string sql = "INSERT INTO [User] ([Email], [PassWord], [Fn], [Phone]) VALUES (@Email, @PassWord, @Fn, @Phone)";
        string[] parameters = { "@Email", "@PassWord", "@Fn", "@Phone" };
        string[] values = { x.Email, x.PassWord, x.Fn, x.Phone };
        Dbase.ChangeTable(sql, parameters, values, "Tcehpc.accdb");
    }
    public static void sqlUpdateUser(string Email, string pass, string Fn, string Phone)
    {
        user x = new user();
        x.Email = Email;
        x.PassWord = pass;
        x.Fn = Fn;
        x.Phone = Phone;
        string sql = "UPDATE [User] SET [PassWord] = @PassWord, [Fn] = @Fn, [Phone] = @Phone WHERE [Email] = @Email";
        string[] parameters = { "@PassWord", "@Fn", "@Phone", "@Email" };
        string[] values = { x.PassWord, x.Fn, x.Phone, x.Email };
        Dbase.ChangeTable(sql, parameters, values, "Tcehpc.accdb");
    }
    public static DataTable sqlAll()
    {
        string sql = "SELECT * FROM [User]";
        string[] parmert = { };
        string[] values = { };
        return Dbase.SelectFromTable(sql, parmert, values, "Tcehpc.accdb");
    }
    public static void sqlDelete(string Email)
    {
        string sql = "DELETE FROM [User] WHERE Email= '";
        sql += Email + "'";
        string[] parmert = { };
        string[] values = { };
        Dbase.SelectFromTable(sql, parmert, values, "Tcehpc.accdb");
    }
}