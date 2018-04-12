using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GVOne.Models
{
    public class UsersModel
    {
        public long UserId { get; set; }
        //public long UserID { get; internal set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}