using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsunami.Coaster.ApplicationService.Models;
using Tsunami.SafetyLine.BusinessObjects;

namespace Tsunami.Coaster.ApplicationService
{
    public class UserAppService : IUserAppService
    {
        public async Task<UserDto> Get(string companyId, string login, string password)
        {
            try
            {
                int companyPk = CompanyUtilities.GetPrimaryKey(companyId);

                UserUtilities userUtilities = new UserUtilities(companyPk);
                var user = userUtilities.GetUser(login, password);
                
                var companyDto = new UserDto()
                {
                    Id = user.UserId,
                    Name = user.FirstName,
                    LastName = user.LastName,
                    PhoneNumber = user.Phone
                };

                return await Task.FromResult(companyDto);
            }
            catch (Exception ex)
            {
                throw new Exception("User not found.", ex);
            }
        }
    }
}
