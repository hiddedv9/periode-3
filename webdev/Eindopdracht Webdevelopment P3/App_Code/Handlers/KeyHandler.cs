using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.Data;

/// <summary>
/// Verzorgt een inlogpoging door een gast met een unique key
/// </summary>
public class KeyHandler : IHttpHandler, System.Web.SessionState.IRequiresSessionState
{
    public KeyHandler()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public bool IsReusable => false;

    public void ProcessRequest(HttpContext context)
    {
        //variables
        
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PresentPlanner.mdf;Integrated Security=True";
        string provider = "System.Data.SqlClient";
        string sql;
        Database db = Database.OpenConnectionString(connectionString, provider);
        var uniquekey = context.Request.Form["inputuniquekey"];




        //ophalen cadeaus waar het unieke id overeenkomt met hetgeen ingevuld en welke gemarkeerd zijn als nog niet gekocht.
        sql = "SELECT * FROM Kados WHERE Uniquekey=@0 AND IsGekocht=@1";
        dynamic result = db.Query(sql, uniquekey, "nee");
        if (result != null)
        {//vul sessie vars
            context.Session["uniquekey"] = uniquekey;
            context.Session["Mode"] = "Gast";
            context.Session["kadoresults"] = result;
        }
        db.Close();
        context.Response.Redirect("kadolijst.cshtml");




    }
}