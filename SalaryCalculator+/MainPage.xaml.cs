using SalaryConverter.API.Interfaces;
using SalaryConverter.ViewModels;

namespace SalaryCalculator_;

public partial class MainPage : ContentPage
{
	public MainPage(IAlfaBankApiService apiService)
	{
		InitializeComponent();
        BindingContext = new MainViewModel(apiService);
    }
}

