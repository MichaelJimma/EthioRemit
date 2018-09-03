using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Dto;
using DAL.Entities;
using DAL.Repositories;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        private IEthioRemitEntitiesRepository<Users> _userRepository;
        public UserService(IEthioRemitEntitiesRepository<Users> userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<Users> Login(string username, string password)
        {
            var user = await _userRepository.GetSingle(q => q.Username == username);
            if (user == null)
                return null;
            if (!VerifyPasswordHash(password, user))
                return null;
            return user;
        }

        public async Task<Users> Register(Users user, string password)
        {
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            await _userRepository.Add(user);

            return user;
        }

        public async Task<bool> UserExists(string username)
        {
            if (await _userRepository.GetAny(q => q.Username == username))
                return true;

            return false;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }


        private bool VerifyPasswordHash(string password, Users user)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(user.PasswordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                var x = computedHash.SequenceEqual(user.PasswordHash);
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != user.PasswordHash[i])
                        return false;
                }
                return true;
            }
        }
    }
}
