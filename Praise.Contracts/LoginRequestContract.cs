namespace Praise.Contracts
{
    public class LoginRequestContract
    {
        public LoginRequestContract(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public string UserName { get; private set; }
        public string Password { get; private set; }
    }
}
