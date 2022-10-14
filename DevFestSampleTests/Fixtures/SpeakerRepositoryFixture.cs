using System;
using System.Collections.Generic;
using DevFestSample.Models;
using DevFestSample.Services;
using DevFestSampleTests.ViewModels;

namespace DevFestSampleTests.Fixtures
{
    public class SpeakerRepositoryFixture : IBuilder, ISpeakerRepository
    {
        public SpeakerRepositoryFixture WitSpeakers(IEnumerable<Speaker> speakers) => this.With(ref _speakers, speakers);

        public IEnumerable<Speaker> GetSpeakers() => _speakers;

        private IEnumerable<Speaker> _speakers = new List<Speaker> { new SpeakerFixture() , new SpeakerFixture().WithName("Pedro Luis"), new SpeakerFixture().WithName("José Ramos") };
    }
}
