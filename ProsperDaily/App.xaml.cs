using ProsperDaily.MVVM.Models;
using ProsperDaily.MVVM.Views;
using ProsperDaily.Repositories;

namespace ProsperDaily;

public partial class App : Application
{
	public static BaseRepository<Transaction> TransactionRepo { get; private set; }
	public App(BaseRepository<Transaction> _transactionsRepo)
	{
		
		InitializeComponent();
        TransactionRepo = _transactionsRepo;
        MainPage = new DashboardPage();
        //MainPage = new StatisticPage();
        //MainPage = new TransactionsPage();
	}
}
