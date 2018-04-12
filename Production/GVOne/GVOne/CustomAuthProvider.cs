using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace GVOne
{
    public class CustomAuthProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            using (GVOneEntities1 db = new GVOneEntities1())
            {
                if (db.tblUsers.Any(m => m.Email == context.UserName && m.Password == context.Password))
                {
                    tblUser u = db.tblUsers.First(n => n.Email == context.UserName);
                    tblLoan l = db.tblLoans.First(n => n.PrimaryBorrowerID == u.tblUserID);
                    identity.AddClaim(new Claim(ClaimTypes.Role, "admin"));
                    identity.AddClaim(new Claim("UserID", u.tblUserID.ToString()));
                    identity.AddClaim(new Claim("LoanID", l.tblLoanID.ToString())); 
                    context.Validated(identity);
                }
                else
                {
                    context.SetError("Message", "invalid credentials");
                }
            }
        }
        
    }
}