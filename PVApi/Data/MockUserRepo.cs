using PVApi.Models;
using System;
using System.Collections.Generic;

namespace PVApi.Data
{
    public class MockUserRepo : IUserRepo
    {
        public IEnumerable<User> GetAllUsers()
        {
            var users = new List<User>
            {
            new User { ID = 1, Nome = "JOAO1", CPF = "72821053088", DataNascimento = new DateTime(2015, 12, 25), Senha = "12345678" },
            new User { ID = 2, Nome = "JOAO2", CPF = "72821053088", DataNascimento = new DateTime(2015, 12, 25), Senha = "12345678" },
            new User { ID = 3, Nome = "JOAOA3", CPF = "72821053088", DataNascimento = new DateTime(2015, 12, 25), Senha = "12345678" }
            };
            return users;            
        }

        public User GetUserByCPF(string cpf)
        {
            return new User { ID = 4, Nome = "Alan Pereira", CPF = "08280562931", DataNascimento = new DateTime(2015, 12, 25), Senha = "12345678" };
        }

        public User GetUserByID(int id)
        {
            return new User { ID = 5, Nome = "Jhonata Simonetto", CPF = "72821053088", DataNascimento = new DateTime(2015, 12, 25), Senha = "12345678" };
        }
    }
}
