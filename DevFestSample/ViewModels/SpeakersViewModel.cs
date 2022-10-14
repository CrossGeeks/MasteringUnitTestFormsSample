using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using DevFestSample.Models;
using DevFestSample.Services;
using Xamarin.Forms;

namespace DevFestSample.ViewModels
{
    public class SpeakersViewModel : INotifyPropertyChanged
    {
        public SpeakersViewModel(ISpeakerRepository speakerRepository)
        {
            GetSpeakersCommand = new Command(() =>
            {
                Speakers = new ObservableCollection<Speaker>(speakerRepository.GetSpeakers());
            });

            SortSpeakersCommand = new Command<object>((sortedBy) =>
            {
                var so = Enum.Parse(typeof(SortedBy), sortedBy.ToString());

                IEnumerable<Speaker> sortedList = new List<Speaker>();
                switch (so)
                {
                    case SortedBy.Ascending:
                        sortedList = Speakers.OrderBy(x => x.Name);
                        break;
                    case SortedBy.Descending:
                        sortedList = Speakers.OrderByDescending(x => x.Name);
                        break;
                    default:
                        break;
                }

                Speakers = new ObservableCollection<Speaker>(sortedList);
            });
            GetSpeakersCommand.Execute(null);
        }


        public ObservableCollection<Speaker> Speakers
        {
            get
            {
                return _speakers;
            }
            set
            {
                _speakers = value;
                OnPropertyChanged(nameof(Speakers));
            }
        }

        public ICommand GetSpeakersCommand { get; }
        public ICommand SortSpeakersCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<Speaker> _speakers;
    }
}
