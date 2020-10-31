using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PVApi.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Senha { get; set; }
        public bool Promo_Bonus { get; set; }
        public bool Ativo { get; set; } = true;

    }
}
