using Demo.Clean.Arch.Model;
using System.Threading.Tasks;

namespace Demo.Clean.Arch.Repository.Interface
{
    public interface IUserLevelRepository
    {
        Task<bool> SaveUserLevel(UserLevelModel userLevel);
        Task<bool> DeleteUserLevel(int Id);
    }
}
