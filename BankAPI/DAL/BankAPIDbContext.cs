using BankAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPI.DAL
{
    public class BankAPIDbContext : DbContext
    {
        public BankAPIDbContext(DbContextOptions<BankAPIDbContext> options) : base(options)
        {

        }

        //dbset
        public DbSet<Conta> Contas { get; set; }
    }
}
