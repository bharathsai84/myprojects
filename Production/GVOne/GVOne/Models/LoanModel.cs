using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GVOne.Models
{
    public class LoanModel
    {
        public long tblLoanID { get; set; }
        public string Name { get; set; }
        public long PrimaryBorrowerID { get; set; }
        public string ActualLoanID { get; set; }
        public string Address { get; set; }
    }
}