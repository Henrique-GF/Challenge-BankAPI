using BankAPI.DAL;
using BankAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPI.Controllers
{
    public class ContaController : Controller
    {
        private BankAPIDbContext _dbContext;

        public ContaController(BankAPIDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route ("Cadastro")]

        // GET: Cadastro
        public object Cadastro(string nome, string senha)
        {
            Transacao conta = new Transacao(_dbContext);
            object response = conta.Cadastrar(nome, senha);
            return JsonConvert.SerializeObject(response);
        }
        //public IEnumerable<Conta> GetAllAccounts()
        //{
        //    return _dbContext.Conta.ToList();
        //}

        [HttpGet]
        [Route("Saque")]
        // GET: Saque
        public object Saque(string Conta, decimal Valor, string Senha)
        {
            Transacao conta = new Transacao(_dbContext);
            object response = conta.Sacar(Conta, Valor, Senha);
            return JsonConvert.SerializeObject(response);
        }

        [HttpGet]
        [Route("Deposito")]
        // GET: Deposito
        public object Deposito(string Conta, decimal Valor, string Senha)
        {
            Transacao conta = new Transacao(_dbContext);
            object response = conta.Depositar(Conta, Valor, Senha);
            return JsonConvert.SerializeObject(response);
        }

        [HttpGet]
        [Route("Saldo")]
        // GET: Saldo
        public object Saldo(string Conta, string Senha)
        {
            Transacao conta = new Transacao(_dbContext);
            object response = conta.ConsultarSaldo(Conta, Senha);
            return JsonConvert.SerializeObject(response);
        }

        

    }
}
