using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPI.Models
{
    [Table("Conta")]
    public class Conta
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Numeroconta { get; set; } //Gerar número de conta
        public string Senha { get; set; }
        public decimal Saldo { get; set; }


        //Gerar um número de conta
        Random rand = new Random();

        public Conta()
        {
            //Conta = Convert.ToString((long)rand.NextDouble * 9_000_000_000L + 1_000_000L);
        }
    }
}
