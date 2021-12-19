using AuthAPI.Entities;
using AuthAPI.Models;
using AuthAPI.Repositories;
using System;

namespace AuthAPI.Services
{
    public class UserService : IUserService
    {
        public readonly IUserRepository userRepo;
        public UserService(IUserRepository userRepo)
        {
            this.userRepo = userRepo;
        }

        public User Login(Login login)
        {
            try
            {
                return userRepo.Login(login);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public string Register(User user)
        {
            try
            {
                var userResult = userRepo.Register(user);
                return userResult == 1 ? "success" : "failure";
            }

            catch (Exception)
            {
                throw;
            }
        }

    }
}
