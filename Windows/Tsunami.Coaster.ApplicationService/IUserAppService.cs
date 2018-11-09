using System.Threading.Tasks;
using Tsunami.Coaster.ApplicationService.Models;

namespace Tsunami.Coaster.ApplicationService
{
    public interface IUserAppService
    {
        Task<UserDto> Get(string companyId, string login, string password);
    }
}