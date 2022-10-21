using LenfestConsultingV2.Model;
using System.Collections.Generic;

namespace LenfestConsultingV2.Repositories
{
    public interface IUserRepository
    {
        User GetByFirebaseUserId(string firebaseUserId);
        List<User> GetAll();
        User GetById(int id);
        void Add(User userProfile);
    }
}
