using System;
using PAM2_Study.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PAM2_Study.Services
{
    public class MonitorService
    {
        private Models.Monitor monitor;
        private HttpClient client;
        private ObservableCollection<Models.Monitor> monitors;
        private JsonSerializerOptions serializerOptions;

        public MonitorService() {
            client = new HttpClient();
            serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

        }

        public async Task<List<Models.Monitor>> getAllMonitorsAsync()
        {
            


        }

    }
}
