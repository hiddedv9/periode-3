using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.Data;
using System.Web.Helpers;

/// <summary>
/// Verzorgt een registratierequest door een bruidspaar.
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
    }


}