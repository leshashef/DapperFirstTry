using DapperFirstTry.Data.ModelsDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperFirstTry.Data.Interfaces
{
    public interface IUserRepository
    {
        void Create(User user);
        void CreateMany(List<User> users);
        void Delete(int id);
        User Get(int id);
        List<User> GetUsers();
        void Update(User user);

        bool CreateTable();
    }
}
