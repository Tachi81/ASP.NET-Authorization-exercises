using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static System.Net.WebRequestMethods;

namespace PageWithLoggingIn.BusinesLogic
{
    public class MyOwnLogic
    {
      public bool CheckIfUserIsLogged()
      {
          return HttpContext.Current.User.Identity.IsAuthenticated;

      }
    }
}