using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GVOne.Models
{
    public class LoanDetailsModel
    {
        public string Name { get; set; }
        public string ActualLoanID { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Lable { get; set; }
        public IEnumerable<UsersModel> Borrowers { get; set; }
        public UsersModel Agent { get; set; }
    }
}