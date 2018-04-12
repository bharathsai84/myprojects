using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GVOne.Models
{
    public class LoanListModel
    {
        public long LoanId { get; set; }
        public string Name { get; set; }
        public string ActualLoanId { get; set; }
        public string Address { get; set; }
    }
}