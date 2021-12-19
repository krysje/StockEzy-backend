using AuthAPI.DBContext;
using AuthAPI.Entities;
using AuthAPI.Models;
using System;
using System.Linq;

namespace AuthAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly StockMarketDBContext smContext;

        public UserRepository(StockMarketDBContext smContext) { this.smContext = smContext; }

        public int Register(User user)
        {
            try
            {
                smContext.Users.Add(user);
                return smContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public User Login(Login login)
        {
            try
            {
                return smContext.Users.Where(u => u.Email == login.Email && u.Password == login.Password).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
