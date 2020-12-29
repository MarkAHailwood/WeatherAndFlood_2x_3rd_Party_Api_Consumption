using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using weatherfetcher.Models;

namespace weatherfetcher.Controllers
{
    public interface IFloodService
    {
        Task<List<FloodSummary>> GetFloodForecast(string location);
    }
}
