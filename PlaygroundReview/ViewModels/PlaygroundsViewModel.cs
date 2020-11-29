using PlaygroundReview.Domain;
using PlaygroundReview.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PlaygroundReview.ViewModels
{
    public class PlaygroundsViewModel : BaseViewModel
    {

        private Playground _selectedPlayground;

        public ObservableCollection<Playground> Playgrounds { get; }
        public Command LoadPlaygroundsCommand { get; }
        public Command AddPlaygroundsCommand { get; }
        public Command<Playground> PlaygroundTapped { get; }

        public PlaygroundsViewModel()
        {
            Title = "Playgrounds";
            Playgrounds = new ObservableCollection<Playground>();
            LoadPlaygroundsCommand = new Command(async () => await ExecuteLoadPlaygroundsCommand());
        }

        async Task ExecuteLoadPlaygroundsCommand()
        {
            IsBusy = true;

            try
            {
                Playgrounds.Clear();
                var playgrounds = await PlaygroundsDataStore.GetItemsAsync(true);

                foreach (var playground in playgrounds)
                {
                    Playgrounds.Add(playground);
                }

            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally { 
                IsBusy = false; 
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedPlayground = null;
        }

        public Playground SelectedPlayground
        {
            get => _selectedPlayground;
            set
            {
                SetProperty(ref _selectedPlayground, value);
                OnPlaygroundSelected(value);
            }
        }

        private async void OnAddPlayground(object obj)
        {
            //await Shell.Current.GoToAsync(nameof(NewPlaygroundPage));
        }

        async void OnPlaygroundSelected(Playground playground)
        {
            if (playground == null)
                return;

            //this will push the PlaygroundDetailPage onto the Navigation Stack
            //await Shell.Current.GoToAsync($"{nameof(PlaygroundDetailPage)}?{nameof(PlaygroundDetailViewModel)}={playground.Id}");

        }
    }
}
