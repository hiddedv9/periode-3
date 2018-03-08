using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LoginHandler
/// </summary>
public class LoginHandler : IHttpHandler
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
        var email = context.Request.Form["inputemail"];
        var passwd = context.Request.Form["inputwachtwoord"];

        System.Diagnostics.Debug.WriteLine(email + " " + passwd);
        

        
    }
}