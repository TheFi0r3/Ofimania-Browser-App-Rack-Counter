using Ofimania_Browser_App_Rack_Counter.Data;

namespace Ofimania_Browser_App_Rack_Counter.Services
{
    public class LoginFormService
    {

        public LoginForm LoginData { get; set; }

        public LoginFormService()
        {
            LoginData = new LoginForm();
        }

        public LoginFormService(string userId, string userPassword, string serverName)
        {
            LoginData = new LoginForm(userId, userPassword, serverName);
        }

        public async Task SetId(string userId, string userPassword, string serverName)
        {
            LoginData.UserId = userId;
            LoginData.UserName = userId;
            LoginData.UserPassword = userPassword;
            LoginData.ServerName = serverName;
        }
        public async Task<string> GetUserName()
        {
            return await Task.FromResult(LoginData.UserId);
        }

        public async Task<string> GetServerName() 
        {
            return await Task.FromResult(LoginData.ServerName);
        }
    }
}
