using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactRegister.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string email { get; set; }
        public string celular { get; set; }
    }
}