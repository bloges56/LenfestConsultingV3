using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using LenfestConsultingV2.Data;
using LenfestConsultingV2.Model;
using LenfestConsultingV2.Repositories;

namespace LenfestConsultingV2.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public User GetByFirebaseUserId(string firebaseUserId)
        {
            var user = _context.User.FirstOrDefault(u => u.FirebaseUserId == firebaseUserId);
            return user;

        }

        public List<User> GetAll()
        {
            return _context.User.ToList();
        }

        public User GetById(int id)
        {
            return _context.User.FirstOrDefault(p => p.Id == id);
        }

        public void Add(User userProfile)
        {
            _context.Add(userProfile);
            _context.SaveChanges();
        }
    }
}