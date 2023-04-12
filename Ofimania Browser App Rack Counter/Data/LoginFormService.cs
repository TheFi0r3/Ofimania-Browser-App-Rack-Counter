namespace Ofimania_Browser_App_Rack_Counter.Data
{
    public class LoginFormService
    {

        public LoginForm LoginData { get; set; }

        public LoginFormService() 
        {
            LoginData = new LoginForm();
        }

        public LoginFormService(string userId, string userPassword)
        {
            LoginData = new LoginForm(userId, userPassword); 
        }

        public async Task SetId(string userId, string userPassword)
        {
            LoginData.UserId = userId;
            LoginData.UserName = userId;
            LoginData.UserPassword = userPassword;
        }
        public async Task<string> GetId( )
        {
            return await Task.FromResult(LoginData.UserId);
        }
    }
}
