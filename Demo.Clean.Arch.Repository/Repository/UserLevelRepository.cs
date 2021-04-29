using Demo.Clean.Arch.Model;
using Demo.Clean.Arch.Repository.Interface;
using System.Threading.Tasks;
using Dapper;
using Npgsql;

namespace Demo.Clean.Arch.Repository
{
    public class UserLevelRepository : IUserLevelRepository
    {
        private readonly DemoContext _context;
        public UserLevelRepository(DemoContext context)
        {
            _context = context;
        }
        public async Task<bool> SaveUserLevel(UserLevelModel userLevel)
        {
            await _context.UserLevel.AddAsync(userLevel);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteUserLevel(int Id)
        {
            using (var connection = new NpgsqlConnection(""))
            {
                await connection.OpenAsync();
                var sqlStatement = "DELETE UserLevel WHERE Id = @Id";
                await connection.ExecuteAsync(sqlStatement, new { Id = Id });
            }
            return true;
        }
        private bool result()
        {
            return
                true;
        }
    }
}
