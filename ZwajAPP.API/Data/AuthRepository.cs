using System.Threading.Tasks;
using ZwajAPP.API.Models;

namespace ZwajAPP.API.Data {
    // public class AuthRepository : IAuthRepository {
    //     private readonly DataContext _context;

    //     public AuthRepository (DataContext context) {
    //         _context = context;

    //     }
    //     public Task<User> Login (string username, string password) {
    //         throw new System.NotImpIementedException ();
    //     }

    //     public async Task<User> Register (User user, string password) {
    //         byte[] passwordHash, passwordSalt;
    //         CreatePasswordHash (password, out passwordHash, out passwordSalt);
    //         user.passwordSalt = passwordSalt;
    //         usre.passwordHash= passwordHash;
    //         await _context.Users.AddAsync(user);
    //         await _context.SaveChangesAsync();
    //         return user;
    //     }
    //     private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    //     {
    //         using(var hmac = new System.Security.Cryptography.HMACSHA512())
    //         {
    //             passwordSalt = hmac.Key;
    //             passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
    //         }
    //     }

    //     public Task<bool> UserExists (string username) {
    //         throw new System.NotImpIementedException ();
    //     }

    // }
}