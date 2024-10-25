using BackendBiblioteca.Repository;
using BackendBiblioteca.Models;

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
    }
}