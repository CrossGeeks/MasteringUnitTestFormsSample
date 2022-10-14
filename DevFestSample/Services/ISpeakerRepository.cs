using System.Collections.Generic;
using DevFestSample.Models;

namespace DevFestSample.Services
{
    public interface ISpeakerRepository
    {
        IEnumerable<Speaker> GetSpeakers();
    }
}
