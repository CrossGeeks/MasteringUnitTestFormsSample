using DevFestSample.Services;
using DevFestSample.ViewModels;
using Xamarin.Forms;

namespace DevFestSample.Views
{
    public partial class TalksPage : ContentPage
    {
        public TalksPage()
        {
            InitializeComponent();
            BindingContext = new TalksViewModel(new TalksRepository());
        }
    }
}
