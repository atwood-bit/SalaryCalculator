using RestSharp;

namespace SalaryConverter.API.Services
{
    public abstract class ApiService
    {
        private RestClient _client = new();

        protected void SetClient(string baseUrl)
        {
            _client = new RestClient(baseUrl);
        }

        public Task<T[]?> Get<T>(string url) => _client.GetJsonAsync<T[]>(url);
    }
}
