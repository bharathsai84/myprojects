using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GVOne.Models
{
    public class AlertsModel
    {
        public long tblAlertID { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime Createdat { get; set; }
    }
}