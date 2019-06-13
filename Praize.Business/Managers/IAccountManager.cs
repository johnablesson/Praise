using Praize.Contracts;
using System.Threading.Tasks;

namespace Praize.Business.Managers
{
    public interface IAccountManager
    {
        Task<int> CreateUser(RegisterUserContract registerUserContract);
    }
}