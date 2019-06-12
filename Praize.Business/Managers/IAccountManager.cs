using Praize.Contracts;

namespace Praize.Business.Managers
{
    public interface IAccountManager
    {
        void CreateUser(RegisterUserContract registerUserContract);
    }
}