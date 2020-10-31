using PVApi.Models;
using System.Collections.Generic;

namespace PVApi.Data
{
    public interface IUserRepo
    {
        IEnumerable<User> GetAllUsers();
        User GetUserByCPF(string cpf);
        User GetUserByID(int  id);
    }
}
