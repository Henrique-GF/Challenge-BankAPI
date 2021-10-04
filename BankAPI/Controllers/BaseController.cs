using BankAPI.DAL;
using BankAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPI.Controllers
{
    public class BaseController : Controller
    {
        private readonly BankAPIDbContext _dbContext;

        public BaseController(BankAPIDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public string Index()
        {
            return "This is my default action...";
        }

        public dynamic Cadastrar(dynamic parameters)
        {
            string nome = parameters.nome;
            string conta = parameters.conta;
            int senha = parameters.senha;
            decimal saldo = parameters.saldo;
            var todoItem = "";

            return todoItem;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
