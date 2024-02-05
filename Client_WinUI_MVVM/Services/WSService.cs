using Client_WinUI_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;


namespace Client_WinUI_MVVM.Services
{
    public class WSService : IService
    {
        private HttpClient client;


        public HttpClient Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
            }
        }
        public WSService(String urii)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(urii);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<List<Series>> GetSeriesAsync(string nomControleur, int Id)
        {
            try
            {
                return await client.GetFromJsonAsync<List<Series>>("/series/"+Id);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<List<Series>> PutSerieAsync(string nomControleur, int Id)
        {
            try
            {
                return await client.GetFromJsonAsync<List<Series>>(nomControleur);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<List<Series>> PostSerieAsync(string nomControleur, int Id)
        {
            try
            {
                return await client.GetFromJsonAsync<List<Series>>(nomControleur);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<HttpResponseMessage> DeleteSerieAsync(string nomControleur, int Id)
        {
            try
            {

                return await client.DeleteAsync(("/series/" + Id);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<List<Series>> GetSerieAsync(string nomControleur, int Id)
        {
            try
            {
                return await client.GetFromJsonAsync<List<Series>>(nomControleur);
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}