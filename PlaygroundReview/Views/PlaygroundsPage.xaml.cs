using PlaygroundReview.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlaygroundReview.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlaygroundsPage : ContentPage
    {
        PlaygroundsViewModel _viewModel;

        public PlaygroundsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new PlaygroundsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}