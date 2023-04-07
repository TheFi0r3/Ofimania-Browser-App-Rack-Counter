namespace Ofimania_Browser_App_Rack_Counter.Data
{
    public class LoginFromService
    {

        public LoginForms loginData { get; set; }

        public LoginFromService() 
        {
        
        }

        public async Task<string> GetName( )
        {
            return await Task.FromResult(loginData.UserName);
        }
    }
}
