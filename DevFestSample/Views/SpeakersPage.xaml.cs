using DevFestSample.Services;
using DevFestSample.ViewModels;
using Xamarin.Forms;

namespace DevFestSample.Views
{
    public partial class SpeakersPage : ContentPage
    {
        public SpeakersPage()
        {
            InitializeComponent();
            BindingContext = new SpeakersViewModel(new SpeakerRepository());
        }
    }
}
