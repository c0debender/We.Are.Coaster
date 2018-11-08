using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsunami.Coaster.ApplicationService.Models;
using TsunamiSolutions.SafetyLine.Services.Notifications;

namespace Tsunami.Coaster.ApplicationService
{
    public class CoasterPhoneCall : ICoasterPhoneCall
    {
        private PhoneCallClient _phoneCallClient;

        public CoasterPhoneCall()
        {
            string serviceBusConnectionString = ConfigurationManager.AppSettings["ServiceBusConnectionString"];
            string serviceBusQueue = ConfigurationManager.AppSettings["ServiceBusQueue"];

            _phoneCallClient = new PhoneCallClient(serviceBusConnectionString, serviceBusQueue);
        }

        public async Task SendPhoneCall(PhoneOptions phoneOptions)
        {
            PhoneCall phoneCall = new PhoneCall()
            {
                NotificationTypeID = 1,
                CompanyID = phoneOptions.CompanyID,
                TargetUserID = phoneOptions.TargetUserID,
                SubjectUserID = phoneOptions.TargetUserID,
                SourcePhoneNumber = phoneOptions.SourcePhoneNumber,
                TargetPhoneNumber = phoneOptions.TargetPhoneNumber,
                CallConnectedURL = phoneOptions.CallConnectedURL,
                TwilioAPISID = ConfigurationManager.AppSettings["TwilioAPISID"],
                TwilioAPISecret = ConfigurationManager.AppSettings["TwilioAPISecret"]
            };

            await _phoneCallClient.SendAsync(phoneCall);
        }
    }
}
