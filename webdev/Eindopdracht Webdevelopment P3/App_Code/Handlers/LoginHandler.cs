using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using WebMatrix.Data;

/// <summary>
/// Verzorgt loginpogingen voor bruidsparen met email/wachtwoord.
/// </summary>
public class LoginHandler : IHttpHandler, System.Web.SessionState.IRequiresSessionState
{
    public LoginHandler()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public bool IsReusable
    {
        get { return false; }

    }



    public void ProcessRequest(HttpContext context)
    {
        //data ophalen uit form
        var email = context.Request.Form["inputemail"];
        var passwd = context.Request.Form["inputpassword"];




        //db vars
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PresentPlanner.mdf;Integrated Security=True";
        string provider = "System.Data.SqlClient";
        string sql = "SELECT passhash FROM Bruidsparen WHERE emailadres=@0";

        //ophalen password hash

        Database db = Database.OpenConnectionString(connectionString, provider);
        dynamic result = db.QuerySingle(sql, email);




        // verificatie van wachtwoord
        try
        {
            var passhashresult = result.passhash;
            if (Crypto.VerifyHashedPassword(passhashresult, passwd))
            { // zet modus op "Bruidspaar" vul de sessievariabelen met data uit db


                sql = "SELECT Mannaam, Vrouwnaam,Uniquekey FROM Bruidsparen WHERE emailadres=@0";
                result = db.Query(sql, email);

                object mannaam = result[0].Mannaam;
                object vrouwnaam = result[0].Vrouwnaam;
                object uniquekey = result[0].Uniquekey;

                context.Session["Mannaam"] = mannaam;
                context.Session["Vrouwnaam"] = vrouwnaam;
                context.Session["Mode"] = "Bruidspaar"; 
                context.Session["Uniquekey"] = uniquekey;
               
                context.Response.Redirect("kadolijst.cshtml");

            }
            else //Geef een error
                System.Diagnostics.Debug.WriteLine("Error");
            context.Response.Redirect("error.cshtml");
        }

        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
        {
            context.Response.Redirect("error.cshtml");
        }











    }
}