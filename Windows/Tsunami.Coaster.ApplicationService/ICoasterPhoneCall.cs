using System.Threading.Tasks;
using Tsunami.Coaster.ApplicationService.Models;

namespace Tsunami.Coaster.ApplicationService
{
    public interface ICoasterPhoneCall
    {
        Task SendPhoneCall(PhoneOptions phoneOptions);
    }
}