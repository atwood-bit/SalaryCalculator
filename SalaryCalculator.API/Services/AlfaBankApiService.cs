using Microsoft.Extensions.Options;
using SalaryConverter.API.Interfaces;
using SalaryConverter.API.Models;

namespace SalaryConverter.API.Services
{
    public class AlfaBankApiService : ApiService, IAlfaBankApiService
    {
        private readonly SettingsAPI _settings;
        public AlfaBankApiService(IOptions<SettingsAPI> settings)
        {
            _settings = settings.Value;
            SetClient(_settings.BaseUrl);
        }

        public async Task<IEnumerable<Rate>> GetRates()
        {
            var res = await Get<Rate>(_settings.RatesUrl);

            return res?.ToList() ?? new List<Rate>();
        }
    }
}
