using PlaygroundReview.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundReview.Services
{
    public class PlaygroundsDatastore : IDataStore<Playground>
    {
        readonly List<Playground> playgrounds;


        public PlaygroundsDatastore()
        {
            playgrounds = new List<Playground>()
            {
                new Playground { Id = Guid.NewGuid().ToString(), Text = "First Park", Description="This is an park description." },
                new Playground { Id = Guid.NewGuid().ToString(), Text = "Second Park", Description="This is an park description." },
            };
        }

        public Task<bool> AddItemAsync(Playground item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Playground> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Playground>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(playgrounds);
        }

        public Task<bool> UpdateItemAsync(Playground item)
        {
            throw new NotImplementedException();
        }
    }
}
