using System.Collections.Generic;
using DevFestSample.Models;

namespace DevFestSampleTests.TestCases
{
    public class SpeakerSortTestData : IEnumerable<object[]>
    {
        private Speaker _speaker1 = new Speaker("SPEAKER 1", "", "");
        private Speaker _speaker2 = new Speaker("SPEAKER 2", "", "");
        private Speaker _speaker3 = new Speaker("SPEAKER 3", "", "");

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { SortedBy.Ascending, new List<Speaker> { _speaker2, _speaker1, _speaker3 }, new List<Speaker> { _speaker1, _speaker2, _speaker3 } };
            yield return new object[] { SortedBy.Descending, new List<Speaker> { _speaker2, _speaker1, _speaker3 }, new List<Speaker> { _speaker3, _speaker2, _speaker1 } };
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
