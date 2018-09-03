using DAL.Dto;
using DAL.Entities;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IUserService
    {
        Task<Users> Register(Users user, string password);
        Task<Users> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}
