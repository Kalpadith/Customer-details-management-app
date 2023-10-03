using CustomerDetailsManagementApp.Services.ServiceInterfaces;

namespace CustomerDetailsManagementApp.Services
{
    public class LoginService : ILoginService
    {
        private readonly IConfiguration _configuration;

        public LoginService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

      
    }
}
