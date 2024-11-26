using System;
using PAM2_Study.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net.Http;

namespace PAM2_Study.Services
{
    public class MonitorService
    {
        private Models.Monitor monitor;
        private HttpClient client;
        private ObservableCollection<Models.Monitor> monitors;
        private JsonSerializerOptions serializerOptions;
        private Uri uri;
 

        public MonitorService() {
            client = new HttpClient();
            serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

        }

        public async Task<Models.Monitor> UpdateMonitorAsync(Models.Monitor monitor)
        {
            return monitor; 
        }

        public async Task<Models.Monitor> GetMonitorsByIdAsync(long id)
        {
            uri = new Uri($"LOCALDOSERVIDOR:8080/MONITORES/{id}");
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    monitor = JsonSerializer.Deserialize<Models.Monitor>(content, serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return monitor;
        }


        public async Task DeleteMonitorAsync(long id)
        {
            uri = new Uri($"LOCALDOSERVIDOR:8080/MONITORES/{id}");
            
            await client.DeleteAsync(uri);
        }

        public async Task<ObservableCollection<Models.Monitor>> getAllMonitorsAsync()
        {

            Uri uri = new Uri("http://localhost:8080/");
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    monitors = JsonSerializer.Deserialize<ObservableCollection<Models.Monitor>>(content, serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return monitors;
        

        }

    }
}
