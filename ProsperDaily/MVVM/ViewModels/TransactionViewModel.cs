using ProsperDaily.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProsperDaily.MVVM.ViewModels
{
    public class TransactionViewModel
    {
        Transaction Transaction { get; set; } = new Transaction() { OperationDate = DateTime.Now, Amount = 50, Name = "Coca-Cola"};

        public string SaveTransaction()
        {
            App.TransactionRepo.SaveItem(Transaction);
            return App.TransactionRepo.StatusMessage;
        }
    }
}
