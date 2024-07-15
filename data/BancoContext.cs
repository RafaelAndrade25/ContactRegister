using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactRegister.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactRegister.data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options){

        }
        public DbSet<ContatoModel> Contatos { get; set; }
    }
}