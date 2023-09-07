using ProsperDaily.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProsperDaily.MVVM.ViewModels
{
   public class DashboardViewModel
    {
        public ObservableCollection<Transaction> Transactions { get; set; }
        public DashboardViewModel()
        {
            FillData();
        }

        private void FillData()
        {
            var transactions = App.TransactionRepo.GetItems();
            transactions = transactions.Where(x => x.Amount != 0).OrderByDescending(x => x.OperationDate).ToList();
            Transactions = new ObservableCollection<Transaction>(transactions);
        }
    }
}
