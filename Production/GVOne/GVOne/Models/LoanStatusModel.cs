using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GVOne.Models
{
    public class LoanStatusModel
    {
        public long tblLoanStatusID { get; set; }
        public Nullable<long> tblLoanID { get; set; }
        public string Description { get; set; }
        public string Lable { get; set; }
        public bool IsActive { get; set; }

        public virtual tblLoan tblLoan { get; set; }
    }
}