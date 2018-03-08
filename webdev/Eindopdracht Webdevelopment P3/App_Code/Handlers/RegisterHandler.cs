using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.Data;

/// <summary>
/// Summary description for RegisterHandler
/// </summary>
public class RegisterHandler : IHttpHandler
{
    public RegisterHandler()
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
        var mannaam = context.Request.Form["voornaam_bruidegom"];
        var vrouwnaam = context.Request.Form["voornaam_bruid"];
        var email = context.Request.Form["inputemail"];
        var passwd = context.Request.Form["inputpassword"];
        var uniquekey = Guid.NewGuid().ToString();
        DateTime trouwdatum = Convert.ToDateTime(context.Request.Form["trouwdatum"]);
        

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PresentPlanner.mdf;Integrated Security=True";
        string provider = "System.Data.SqlClient";

        Database db = Database.OpenConnectionString(connectionString, provider);
        var sql = "INSERT INTO Bruidsparen(Mannaam,Vrouwnaam,uniquekey,emailadres,aantalgasten) VALUES(@0,@1,@2,@3,@4)";

        db.Execute(sql, mannaam, vrouwnaam, uniquekey, email, 5);








        System.Diagnostics.Debug.WriteLine(trouwdatum.ToString());

        context.Response.Redirect("home.cshtml");
    }
}