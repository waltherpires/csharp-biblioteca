using BackendBiblioteca.Data;
using BackendBiblioteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendBiblioteca.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _db;

        public UserService(ApplicationDbContext db){
            _db = db;
        }

        public IEnumerable<User> FindAllUsers()
        {
            IEnumerable<User> users = _db.Users.ToList();
            return users;
        } 

        public User? FindUserById(int id)
        {
            return _db.Users.Find(id);
        }

        public User SaveUser(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();

            return user;
        }

        public User UpdateUser(int id, User updateUser)
        {
            User? user = _db.Users.Find(id);

            if(user == null)
            {
                throw new Exception("User not found!");
            }

            user.Name = updateUser.Name;
            user.Email = updateUser.Email;

            _db.Update(user);
            _db.SaveChanges();

            return user;
        }

        public void DeleteUser(int id)
        {
            User? user = _db.Users.Find(id);

            if(user == null)
            {
                throw new Exception("User not found!");
            }

            _db.Users.Remove(user);
            _db.SaveChanges();
        }
    }
}