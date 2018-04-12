using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;

namespace GVOne
{
    public static class GetUserID
    {
        public static int UserID(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("UserID");
            return (claim != null) ? Convert.ToInt32(claim.Value) : 0;
        }
        public static int LoanID(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("LoanID");
            return (claim != null) ? Convert.ToInt32(claim.Value) : 0;
        }
    }
}