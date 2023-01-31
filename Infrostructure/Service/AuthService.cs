using Application.Abstractions;
using Infrostructure.Abstractions;
using Infrostructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrostructure.Service
{
    public class AuthService : IAuthService
    {
        private readonly ApplicationDbContext _context;
        private readonly IHashProvider _hashProvider;
        private readonly ITokenServiceInterface1 _tokenServiceInterface1;

        public async Task<string> loginasync(string fullName, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Fullname == fullName);

            if (user == null)
            {
                throw new Exception("User not found");
            }

            if (user.PasswordHash != _hashProvider.GetHash(password))
            {
                throw new Exception("Password is wrong");
            }

            return _tokenServiceInterface1.genericasynctoken(user);
        }
    }
}
