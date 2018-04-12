using GVOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
namespace GVOne.Controllers
{
    [Authorize (Roles ="admin")]
    public class AuthenticationController : ApiController
    {
        [HttpGet]
        [Route("api/authentication/GetLoans")]
        public IEnumerable<LoanListModel> GetLoans(int pagenumber,int size)
        {
            using (GVOneEntities1 db = new GVOneEntities1())
            {
                List<LoanListModel> loanList = (from l in db.tblLoans
                                                where l.PrimaryBorrowerID == l.tblUser.tblUserID
                                                orderby l.tblLoanID
                                                select new LoanListModel
                                                {
                                                    LoanId = l.tblLoanID,
                                                    Name = l.tblUser.Name,
                                                    ActualLoanId = l.ActualLoanID,
                                                    Address = l.tblUser.Address
                                                }).Skip(pagenumber * size).Take(size).ToList();
                return loanList;
            }
        }
        [HttpGet]
        [Route("api/authentication/GetLoanDetails")]
        public HttpResponseMessage GetLoanDetails()
        {
            using (GVOneEntities1 db = new GVOneEntities1())
            {
                int loanID = User.Identity.LoanID();
                LoanDetailsModel loanDetails = (from l in db.tblLoans
                                                where l.tblLoanID == loanID
                                                select new LoanDetailsModel
                                                {
                                                    Name = l.tblUser.Name,
                                                    ActualLoanID = l.ActualLoanID,
                                                    Address = l.tblUser.Address,
                                                    Description = l.tblLoanStatu.Description,
                                                    Lable = l.tblLoanStatu.Lable,
                                                    Borrowers = l.tblUserLoans.Where(m => m.tblRole.Name == "User").SelectMany(z => l.tblUserLoans.Select(v => new UsersModel()
                                                    {
                                                        UserId = z.tblUserID,
                                                        Name = z.tblUser.Name,
                                                        Email = z.tblUser.Email,
                                                        Mobile = z.tblUser.Mobile
                                                    })).ToList().Distinct(),
                                                    Agent = l.tblUserLoans.Where(m => m.tblRole.Name == "Agent").Select(n => new UsersModel()
                                                    {
                                                        UserId = n.tblUserID,
                                                        Name = n.tblUser.Name,
                                                        Email = n.tblUser.Email,
                                                        Mobile = n.tblUser.Mobile
                                                    }).FirstOrDefault(),
                                                }).First();
                return Request.CreateResponse(HttpStatusCode.OK, loanDetails);
            }
        }
        [HttpGet]
        [Route("api/authentication/GetAlerts")]
        public IEnumerable<AlertsModel> GetAlerts(int pagenumber,int size)
        {
            using (GVOneEntities1 db = new GVOneEntities1())
            {
                int userID = User.Identity.UserID();
                List<AlertsModel> alertList = new List<AlertsModel>();
                alertList = (from ua in db.tblUserAlerts
                             where (ua.tblUserID == userID && ua.IsDeleted == false)
                             orderby ua.tblAlertID descending
                             select new AlertsModel
                             {
                                 tblAlertID = ua.tblAlert.tblAlertID,
                                 Subject = ua.tblAlert.Subject,
                                 Description = ua.tblAlert.Description,
                                 Createdat = ua.tblAlert.CreatedAt
                             }).Skip(pagenumber * size).Take(size).ToList();
                return alertList;
            }
        }
        [HttpGet]
        [Route("api/authentication/GetSettings")]
        public HttpResponseMessage GetSettings()
        {
            using (GVOneEntities1 db = new GVOneEntities1())
            {
                int userID = User.Identity.UserID();
                SettingsModel settings = (from s in db.tblSettings where s.tblUserID == userID
                                          select new SettingsModel
                                          {
                                              IsAlertNotificationEnable = s.IsAlertNotificationEnable,
                                              IsAllSettingEnable = s.IsAllSettingEnable,
                                              IsPushNotificationEnable = s.IsPushNotificationEnable
                                          }).FirstOrDefault();
                db.tblSettings.FirstOrDefault(x => x.tblUserID == userID);
                if (settings == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "NotThere");
                }
                return Request.CreateResponse(HttpStatusCode.OK, settings);
            }
        }
        [HttpPost]
        [Route("api/authentication/EnablePushNotification")]
        public HttpResponseMessage EnablePushNotification()
        {
            using (GVOneEntities1 db = new GVOneEntities1())
            {
                int userID = User.Identity.UserID();
                (from s in db.tblSettings where s.tblUserID == userID select s).ToList().ForEach(x => x.IsPushNotificationEnable = true);
                return Request.CreateResponse(HttpStatusCode.OK, "Enabled Push Notification");
            }
        }
        [HttpPost]
        [Route("api/authentication/DisablePushNotification")]
        public HttpResponseMessage DisablePushNotification()
        {
            using (GVOneEntities1 db = new GVOneEntities1())
            {
                int userID = User.Identity.UserID();
                (from s in db.tblSettings where s.tblUserID == userID select s).ToList().ForEach(x => x.IsPushNotificationEnable = false);
                return Request.CreateResponse(HttpStatusCode.OK, "Disabled Push Notification");
            }
        }
    }
}
