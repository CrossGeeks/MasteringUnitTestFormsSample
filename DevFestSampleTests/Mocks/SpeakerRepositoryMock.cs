using System.Collections.Generic;
using DevFestSample.Models;
using DevFestSample.Services;

namespace DevFestSampleTests.Mocks
{
    public class SpeakerRepositoryMock : ISpeakerRepository
    {
        public IEnumerable<Speaker> GetSpeakers()
        {
            return new List<Speaker>
            {
                new Speaker("Speaker 1", ""),
                new Speaker("Speaker 3", ""),
                new Speaker("Speaker 2", ""),
            };
        }
    }
}
