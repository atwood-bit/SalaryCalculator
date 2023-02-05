using SalaryConverter.API.Interfaces;
using SalaryConverter.Commands;
using SalaryConverter.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace SalaryConverter.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public ICommand Command { get; set; }
        public SalaryModel Salary { get; } = new();

        public MainViewModel(IAlfaBankApiService apiService)
        {
            Command = new ConvertSalaryCommand(apiService);
        }
    }
}
