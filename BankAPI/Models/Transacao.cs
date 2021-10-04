using BankAPI.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPI.Models
{
    public class Transacao
    {

        private readonly BankAPIDbContext _dbContext;

        public Transacao(BankAPIDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public object Cadastrar(string nome, string senha)
        {
            try
            {
                Conta cadastro = new Conta();
                cadastro.Nome = nome;
                cadastro.Senha = senha;

                Random rand = new Random();
                cadastro.Numeroconta = Convert.ToString((long)rand.Next(100000,999999));
                while (_dbContext.Contas.Any(x => x.Numeroconta == cadastro.Numeroconta)){
                    cadastro.Numeroconta = Convert.ToString((long)rand.Next(100000, 999999));
                }
                

                _dbContext.Contas.Add(cadastro);
                _dbContext.SaveChanges();

                var data = new
                {
                    Cadastro = new
                    {
                        Mensagem = "Sua conta foi cadastrada.",
                        conta = cadastro.Numeroconta
                    }
                };

                return data;
            }
            catch (Exception e)
            {
                var error = new
                {
                    Cadastro = new
                    {
                        Mensagem = "Houve um erro no cadastro"
                    }
                };
                return error;
            }
        }


        public object Sacar(string NConta, decimal Valor, string Senha)
        {
            Conta conta = _dbContext.Contas.Where(x => x.Numeroconta == NConta).FirstOrDefault();

            if (conta == null)
            {
                var erro = new
                {
                    Erro = new
                    {
                        Mensagem = "Não existe uma conta com esse número"
                    }
                };

                return erro;
            }

            if (conta.Senha == Senha)
            {
                conta.Saldo -= Valor;
                if (conta.Saldo < 0) 
                {
                    var error = new
                    {
                        Error = new
                        {
                            Message = "Saldo insuficiente."
                        }
                    };
                    return error;
                }

                _dbContext.SaveChanges();

                var data = new
                {
                    Sacar = new
                    {
                        conta = conta.Numeroconta,
                        saldo = conta.Saldo
                    }
                };

                return data;
            }
            var Erro = new
            {
                Erro = new
                {
                    Mensagem = "Senha incorreta"
                }
            };

            return Erro;


        }

        public object Depositar(string NConta, decimal Valor, string Senha)
        {
            Conta conta = conta = _dbContext.Contas.Where(x => x.Numeroconta == NConta).FirstOrDefault();
            if (conta == null)
            {
                var Erro = new
                {
                    Erro = new
                    {
                        Mensagem = "Não existe uma conta com esse número"
                    }
                };

                return Erro;
            }
            if (conta.Senha == Senha)
            {
                conta.Saldo += Valor;
                _dbContext.SaveChanges();

                var data = new
                {
                    Depositar = new
                    {
                        conta = conta.Numeroconta,
                        saldo = conta.Saldo
                    }
                };

                return data;
            }

            var erro = new
            {
                Erro = new
                {
                    Mensagem = "Senha incorreta"
                }
            };

            return erro;

        }

        public object ConsultarSaldo(string NConta, string Senha)
        {
            Conta conta = _dbContext.Contas.Where(x => x.Numeroconta == NConta).FirstOrDefault();
            if (conta == null)
            {
                var Erro = new
                {
                    Erro = new
                    {
                        Mensagem = "Não existe uma conta com esse número"
                    }
                };

                return Erro;
            }
            if (conta.Senha != Senha)
            {
                var error = new
                {
                    Erro = new
                    {
                        Mensagem = "Senha incorreta"
                }
                };

                return error;
            }

            var data = new
            {
                Saldo = new
                {
                    conta = conta.Numeroconta,
                    saldo = conta.Saldo
                }
            };

            return data;
            
        }

    }
}
