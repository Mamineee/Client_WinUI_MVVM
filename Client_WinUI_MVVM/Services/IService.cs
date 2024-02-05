using Client_WinUI_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Client_WinUI_MVVM.Services
{
    public interface IService
    {
        Task<List<Series>> GetSeriesAsync(string nomControleur, int Id);
        Task<List<Series>> PutSerieAsync(string nomControleur, int Id);
        Task<List<Series>> PostSerieAsync(string nomControleur, int Id);
        Task<HttpResponseMessage> DeleteSerieAsync(string nomControleur, int Id);
        Task<List<Series>> GetSerieAsync(string nomControleur, int Id);
    }
}
