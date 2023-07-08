using BlogWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebsite.Services
{
    public class UsersService
    {
        private readonly BLOGDBContext _dbContext;
        public UsersService(BLOGDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<User> GetUsers()
        {
            var users = _dbContext.Users.ToList();
            return users;
        }

        public User DetailsUser(int id)
        {
            var user = _dbContext.Users.Single(u => u.Id == id);
            return user;
        }

        public void CreateUser(User user)
        {
            _dbContext.Add(user);
            _dbContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _dbContext.Update(user);
            _dbContext.SaveChanges();
        }

        public void ChangeProfile(User updateUser)
        {
            var user = _dbContext.Users.Find(updateUser.Id);

            user.UserName = updateUser.UserName;
            user.UserLogin = updateUser.UserLogin;
            user.UserEmail = updateUser.UserEmail;

            _dbContext.SaveChanges();
        }

        public void ChangePassword(int id, string password)
        {
            var user = _dbContext.Users.Find(id);
            user.UserPassword = password;
            _dbContext.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            _dbContext.Remove(new User { Id = id });
            _dbContext.SaveChanges();
        }

        public User Login(string name, string password)
        {
            var user = _dbContext.Users.FirstOrDefault(u => (u.UserLogin == name && u.UserPassword == password) || (u.UserEmail == name && u.UserPassword == password));
            if (user != null)
            {
                return user;
            }
            return null;
        }

        public bool CheckPassWord(int id, string password)
        {
            var user = _dbContext.Users.Single(u => u.Id == id && u.UserPassword == password);
            if (user != null)
            {
                return true;
            }
            return false;
        }
    }
}
