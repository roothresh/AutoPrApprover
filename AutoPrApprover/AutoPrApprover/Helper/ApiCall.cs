using AutoPrApprover.Interfaces;
using AutoPrApprover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AutoPrApprover.Helper
{
    public class ApiCall : IApiCall
    {
        public async Task<string> Approve(string apiUrl, string jsonBody, AuthModel authModel)
        {
            using HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes($":{authModel.Password}")));

            try
            {
                HttpResponseMessage response = await client.PutAsync(apiUrl, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    return "PR Başarıyla Onaylandı";
                }
                else
                {
                    return $"Başarısız {response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }

        Task<string> IApiCall.Reject()
        {
            throw new NotImplementedException();
        }
    }
}
