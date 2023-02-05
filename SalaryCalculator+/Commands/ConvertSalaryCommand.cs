using SalaryConverter.API.Interfaces;
using SalaryConverter.Models;
using System.Windows.Input;

namespace SalaryConverter.Commands
{
    internal class ConvertSalaryCommand : ICommand
    {
        private IAlfaBankApiService _apiService;
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => parameter is SalaryModel model && model.SalaryNetto > 0;

        public ConvertSalaryCommand(IAlfaBankApiService apiService)
        {
            _apiService = apiService;
        }

        public void Execute(object parameter)
        {
            var model = (SalaryModel)parameter;
            var test = _apiService.GetRates();
            var q = 0;
        }
    }
}
