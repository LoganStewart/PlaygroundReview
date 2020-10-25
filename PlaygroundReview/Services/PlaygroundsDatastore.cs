using PlaygroundReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

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

        public async Task<bool> AddItemAsync(Playground item)
        {
            playgrounds.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = playgrounds.Where((Item arg) => arg.Id == id).FirstOrDefault();
            playgrounds.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Playground> GetItemAsync(string id)
        {
            return await Task.FromResult(playgrounds.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Playground>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(playgrounds);
        }

        public async Task<bool> UpdateItemAsync(Playground item)
        {
            var oldItem = playgrounds.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            playgrounds.Remove(oldItem);
            playgrounds.Add(item);

            return await Task.FromResult(true);
        }
    }
}
