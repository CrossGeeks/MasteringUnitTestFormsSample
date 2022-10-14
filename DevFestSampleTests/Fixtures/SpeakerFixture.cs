using DevFestSample.Models;

namespace DevFestSampleTests.ViewModels
{
    internal class SpeakerFixture : IBuilder
    {
        public static implicit operator Speaker(SpeakerFixture fixture) => fixture.Build();

        public SpeakerFixture WithName(string name) => this.With(ref _name, name);

        public SpeakerFixture WithPhoto(string photo) => this.With(ref _photo, photo);

        public SpeakerFixture WithHeadline(string headline) => this.With(ref _headline, headline);

        private Speaker Build() =>
            new Speaker(_name, _photo, _headline);

        private string _name = "Juan Perex";
        private string _photo = "N/A";
        private string _headline = "Tester";

    }
}
