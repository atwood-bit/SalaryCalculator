using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SalaryConverter.Models
{
    public class SalaryModel : INotifyPropertyChanged
    {
        private double _salaryNetto;
        private DateTime _salaryDate;

        public double SalaryNetto
        {
            get => _salaryNetto;
            set
            {
                if (_salaryNetto != value)
                {
                    _salaryNetto = value;
                    OnPropertyChanged();
                }
            }
        }
        public DateTime SalaryDate
        {
            get => _salaryDate;
            set
            {
                if (_salaryDate != value)
                {
                    _salaryDate = value;
                    OnPropertyChanged();
                }
            }
        }
        public double CreditAmount { get; set; }
        public double CreditUsd { get; set; }

        public SalaryModel()
        {
            _salaryNetto = 0;
            _salaryDate = DateTime.Now.Date;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
