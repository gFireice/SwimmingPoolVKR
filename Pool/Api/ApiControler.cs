using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Pool.Model;

namespace Pool.Api
{
    public class ApiControler
    {
        public HttpClient client = new HttpClient();

        public async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://localhost:8081/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Client>> GetAllClient()
        {
            List<Client> clients = null;
            HttpResponseMessage response = await client.GetAsync($"client");
            clients = await response.Content.ReadAsAsync<List<Client>>();

            return clients;
        }


        public async Task<List<Employess>> GetAllEmplooyes()
        {
            List<Employess> employesse = null;
            HttpResponseMessage response = await client.GetAsync($"employess");
            employesse= await response.Content.ReadAsAsync<List<Employess>>();

            return employesse;
        }

        public async Task<List<Service>> GetAllService()
        {
            List<Service> services = null;
            HttpResponseMessage response = await client.GetAsync($"service");
            services = await response.Content.ReadAsAsync<List<Service>>();

            return services;
        }

        public async Task<List<Subscription>> GetAllSybscribe()
        {
            List<Subscription> subscriptions = null;
            HttpResponseMessage response = await client.GetAsync($"subscribe");
            subscriptions = await response.Content.ReadAsAsync<List<Subscription>>();

            return subscriptions;
        }
    }
}
