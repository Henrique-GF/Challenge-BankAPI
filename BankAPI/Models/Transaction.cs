using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPI.Models
{
    [Table("Transactions")]
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public string TransactionUniqueReference { get; set; }
        public decimal TransactionAmount { get; set; }
        public TranStatus TransactionStatus { get; set; } //enum para definir o status da transação
        public bool IsSuccessful => TransactionStatus.Equals(TranStatus.Success); //depende do valor de TransacitonStatus
        public string TransactionParticulars { get; set; }
        public TranType TransactionType { get; set; }

        public Transaction() 
        {
            TransactionUniqueReference = $"{Guid.NewGuid().ToString().Replace("-", "").Substring(1, 27)}";
        }


    }

    public enum TranStatus
    {
        Failed,
        Success,
        Error
    }

    public enum TranType
    {
        Deposito,
        Saque
    }
}
