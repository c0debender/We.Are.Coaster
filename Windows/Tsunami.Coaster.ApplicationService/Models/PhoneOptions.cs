using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsunami.Coaster.ApplicationService.Models
{
    public class PhoneOptions
    {
        public int NotificationTypeID { get; set; }
        public string CompanyID { get; set; }
        public string CompanyLogin { get; set; }
        public string TargetUserID { get; set; }
        public string SubjectUserID { get; set; }
        public string TargetUserLoginId { get; set; }
        public string SourcePhoneNumber { get; set; }
        public string TargetPhoneNumber { get; set; }
        public string CallConnectedURL { get; set; }
        public string TwilioAPISID { get; set; }
        public string TwilioAPISecret { get; set; }
        public string Message { get; set; }
        public string LanguageCode { get; set; }
    }
}
