using SalaryConverter.API.Models;

namespace SalaryConverter.API.Interfaces
{
    public interface IAlfaBankApiService
    {
        Task<IEnumerable<Rate>> GetRates();
    }
}
