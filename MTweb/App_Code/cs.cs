﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI.WebControls.Expressions;
using System.Xml.Linq;

/// <summary>
/// Summary description for User
/// </summary>
/// /// </summary>
public class cart
{
    public string Porduct;
    public string User;
    public string Date;
    public bool IsBuy;
    public string Count;
    public static void sqlInsert(string Porduct, string User, string Date)
    {
        string sql = "SELECT * FROM [cart] Where [Porduct]=@Porduct and [User]=@User and [IsBuy]=@IsBuy";
        string[] parmert = { "@Porduct", "@User", "@IsBuy" };
        string[] values = { Porduct, User, "False" };
        DataTable dt = Dbase.SelectFromTable(sql, parmert, values, "Tcehpc.accdb");
        if (dt.Rows.Count == 0)
        {
            string sql1 = "INSERT INTO [cart] ([Porduct], [User], [Date], [IsBuy], [Count]) VALUES (@Porduct, @User, @Date, @IsBuy, @Count)";
            string[] parameters1 = { "@Porduct", "@User", "@Date", "@IsBuy", "@Count" };
            string[] values1 = { Porduct, User, Date, "False", "1" };
            Dbase.ChangeTable(sql1, parameters1, values1, "Tcehpc.accdb");
        }
        else
        {
            string sql2 = "UPDATE [cart] SET [Count] = @Count WHERE [Id] = @Id";
            string[] parameters2 = { "@Count", "@Id" };
            string[] values2 = { (int.Parse(dt.Rows[0]["Count"].ToString()) + 1).ToString(), dt.Rows[0]["Id"].ToString() };
            Dbase.ChangeTable(sql2, parameters2, values2, "Tcehpc.accdb");
        }
    }
    public static DataTable sqlemail(string email, bool thebuy)
    {
        string sql = "SELECT * FROM [cart] Where [User]=@User and [IsBuy]=@IsBuy";
        string[] parmert = { "@User", "@IsBuy" };
        string[] values = { email, thebuy.ToString() };
        return Dbase.SelectFromTable(sql, parmert, values, "Tcehpc.accdb");
    }
    public static void sqlupdate(bool buy,string id)
    {
        string sql2 = "UPDATE [cart] SET [IsBuy] = @IsBuy WHERE [Id] = @Id";
        string[] parameters2 = { "@IsBuy", "@Id" };
        string[] values2 = { buy.ToString(), id };
        Dbase.ChangeTable(sql2, parameters2, values2, "Tcehpc.accdb");
    }
public static DataTable sqlGetAllbuy(string email,bool buy)
    {
        string sql = "SELECT products.Name, products.Pic, products.Discount, products.Price, products.Count AS count1, cart.Count, cart.Id FROM products INNER JOIN cart ON products.Id = cart.Porduct ";
        sql += "WHERE cart.User = @email AND cart.IsBuy = @buy";
        string[] parmert = { "@email", "@buy" };
        string[] values = { email, buy.ToString() };
        return Dbase.SelectFromTable(sql, parmert, values, "Tcehpc.accdb");
    }
    
}

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
    public string MaxBuyForUser { get; set; }
    public static void sqlInsert(string Id, string KindProducts, string Price, string Discount, string Name, string Pic, string Count, bool Private )
    {
        string sql = "INSERT INTO [products] ([Id], [KindProducts], [Price], [Discount], [Name], [Pic], [Count], [Private]) VALUES (@Id, @KindProducts, @Price, @Discount, @Name, @Pic, @Count, @Private)";
        string[] parameters = { "@Id", "@KindProducts", "@price", "@Discount", "@name", "@Pic", "@Count", "@Private" };
        string[] values = { Id, KindProducts, Price, Discount, Name, Pic, Count, Private.ToString() };
        Dbase.ChangeTable(sql, parameters, values, "Tcehpc.accdb");
    }
    public static DataTable sqlid(string KindProducts)
    {
        string sql = "SELECT * FROM [products] Where [KindProducts]=@KindProducts and [Private]=@Private ";
        string[] parmert = { "@KindProducts", "@Private" };
        string[] values = { KindProducts, "True" };
        return Dbase.SelectFromTable(sql, parmert, values, "Tcehpc.accdb");
    }
    

}
public class kindproducts
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Pic { get; set; }
    public static void sqlInsert(string Name, string Pic)
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
        string sql = "SELECT * FROM [kindproduct] 123451 Where [Id]=@Id";
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
        ;
        string sql = "INSERT INTO [Admin] ([Email], [PassWord], [Fn], [Phone]) VALUES (@Email, @PassWord, @Fn, @Phone)";
        string[] parameters = { "@Email", "@PassWord", "@Fn", "@Phone" };
        string[] values = { Email, Pass, Fn, Phone };
        Dbase.ChangeTable(sql, parameters, values, "Tcehpc.accdb");
    }
    public static void sqlUpdate(string Email, string pass, string Fn, string Phone)
    {
        string sql = "UPDATE [Admin] SET [PassWord] = @PassWord, [Fn] = @Fn, [Phone] = @Phone WHERE [Email] = @Email";
        string[] parameters = { "@PassWord", "@Fn", "@Phone", "@Email" };
        string[] values = { pass, Fn, Phone, Email };
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
        string sql = "SELECT * FROM [User] Where [Email]=@Email";
        string[] parmert = { "@Email" };
        string[] values = { Email };
        DataTable dt = Dbase.SelectFromTable(sql, parmert, values, "Tcehpc.accdb");
        if (dt.Rows.Count == 1)
            return true;
        return false;
    }
    public static void sqlInsert(string Email, string pass, string Fn, string Phone)
    {
        string sql = "INSERT INTO [User] ([Email], [PassWord], [Fn], [Phone]) VALUES (@Email, @PassWord, @Fn, @Phone)";
        string[] parameters = { "@Email", "@PassWord", "@Fn", "@Phone" };
        string[] values = { Email, pass, Fn, Phone };
        Dbase.ChangeTable(sql, parameters, values, "Tcehpc.accdb");
    }
    public static void sqlUpdateUser(string Email, string pass, string Fn, string Phone)
    {
        string sql = "UPDATE [User] SET [PassWord] = @PassWord, [Fn] = @Fn, [Phone] = @Phone WHERE [Email] = @Email";
        string[] parameters = { "@PassWord", "@Fn", "@Phone", "@Email" };
        string[] values = { pass, Fn, Phone, Email };
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