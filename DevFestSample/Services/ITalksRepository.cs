using System.Collections.Generic;
using DevFestSample.Models;

namespace DevFestSample.Services
{
    public interface ITalksRepository
    {
        IEnumerable<Talk> GetTalks();
    }
}
