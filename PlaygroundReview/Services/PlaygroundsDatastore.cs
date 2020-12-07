using Newtonsoft.Json;
using PlaygroundReview.Domain;
using PlaygroundReview.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace PlaygroundReview.Services
{
    public class PlaygroundsDatastore : IDataStore<Playground>
    {
        readonly List<Playground> playgrounds;
        static HttpClient client = new HttpClient();

        public PlaygroundsDatastore()
        {
            /*
            playgrounds = new List<Playground>()
            {
                new Playground { Id = Guid.NewGuid().ToString(), Name = "First Park", Description="This is an park description." },
                new Playground { Id = Guid.NewGuid().ToString(), Name = "Second Park", Description="This is an park description." },
            };
            */
            playgrounds = new List<Playground>();
        }

        public async Task<bool> AddItemAsync(Playground item)
        {
            playgrounds.Add(item);

            return await Task.FromResult(true);
        }

        

        /*
        public async Task<Playground> GetItemAsync(string id)
        {
            return await Task.FromResult(playgrounds.FirstOrDefault(s => s.Id == id));
        }
        */

        public async Task<Playground> GetItemAsync(string id)
        {

            
            return await Task.FromResult(playgrounds.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Playground>> GetItemsAsync(bool forceRefresh = false)
        {
            IEnumerable<Playground> playgrounds = null;
            HttpResponseMessage response = await client.GetAsync(Secrets.WebApi_Playgrounds_GetAll);
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                playgrounds = JsonConvert.DeserializeObject<IEnumerable<Playground>>(data);
            }
            return playgrounds;

            //return await Task.FromResult(playgrounds);
        }

        public async Task<bool> UpdateItemAsync(Playground item)
        {
            var oldItem = playgrounds.Where((Playground arg) => arg.Id == item.Id).FirstOrDefault();
            playgrounds.Remove(oldItem);
            playgrounds.Add(item);

            return await Task.FromResult(true);
        }

        Task<bool> IDataStore<Playground>.DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
