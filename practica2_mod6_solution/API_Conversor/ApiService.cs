using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace API_Conversor
{
    public class ApiService
    {
        private readonly HttpClient HttpClient;
        private readonly string ApiUrl;
        public ApiService(string apiUrl)
        {
            HttpClient = new HttpClient();
            ApiUrl =$"https://v6.exchangerate-api.com/v6/ade178ca382d06582982fc42/latest/{apiUrl}";
        }
        public async Task<string> CallApiAsync() {


            try
            {
                HttpResponseMessage response = await HttpClient.GetAsync(ApiUrl);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new HttpRequestException($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }



            }
            catch (Exception ex) {

                throw new Exception($"Error de solicitud HTTP: {ex.Message}");


            }
        
        
        }


    }
}
