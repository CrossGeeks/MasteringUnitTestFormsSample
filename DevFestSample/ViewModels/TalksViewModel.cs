using System.Collections.Generic;
using System.Windows.Input;
using DevFestSample.Models;
using DevFestSample.Services;
using Xamarin.Forms;

namespace DevFestSample.ViewModels
{
    public class TalksViewModel
    {
        public TalksViewModel(ITalksRepository speakerRepository)
        {
            GetTalksCommand = new Command(() =>
            {
                Talks = speakerRepository.GetTalks();
            });

            GetTalksCommand.Execute(null);
        }


        public IEnumerable<Talk> Talks { get; private set; }
        public ICommand GetTalksCommand { get; }
    }
}
