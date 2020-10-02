using System.ComponentModel;
using Xamarin.Forms;
using PlaygroundReview.ViewModels;

namespace PlaygroundReview.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}