using ProsperDaily.MVVM.ViewModels;

namespace ProsperDaily.MVVM.Views;

public partial class StatisticPage : ContentPage
{
	public StatisticPage()
	{
		InitializeComponent();
		BindingContext = new  StatisticViewModel();
	}
    protected override void OnAppearing()
    {
        var vm = (StatisticViewModel)BindingContext;
        vm.GetTransactionsSummary();
    }
}