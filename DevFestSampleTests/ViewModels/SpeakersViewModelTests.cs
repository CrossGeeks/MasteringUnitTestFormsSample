using System.Collections.Generic;
using System.Linq;
using DevFestSample.Models;
using DevFestSample.Services;
using DevFestSample.ViewModels;
using DevFestSampleTests.Fixtures;
using FakeItEasy;
using Xunit;
using DevFestSampleTests.Mocks;
using DevFestSampleTests.TestCases;

namespace DevFestSampleTests.ViewModels
{
    public class SpeakersViewModelTests
    {
        [Fact]
        public void GetSpeakersCommand_UsingMockClass_Should_ReturnsSpeakers_When_AppLoading()
        {
            //Arrange
            ISpeakerRepository repository = new SpeakerRepositoryMock();
            var result = repository.GetSpeakers();

            //Act
            var viewModel = new SpeakersViewModel(repository);

            //Assert
            Assert.Equal(result.ToList().Select(x => x.Name), viewModel.Speakers.Select(x => x.Name));
        }

        [Fact]
        public void GetSpeakersCommand_UsingFakeItEasy_Should_ReturnsSpeakers_When_AppLoading()
        {
            //Arrange
            var repository = A.Fake<ISpeakerRepository>();

            var result = new List<Speaker>() { new Speaker("Test", "") };

            A.CallTo(() => repository.GetSpeakers())
              .Returns(result);

            //Act
            var viewModel = new SpeakersViewModel(repository);

            //Assert
            Assert.Equal(result, viewModel.Speakers);
        }

        [Fact]
        public void GetSpeakersCommand_UsingFixture_Should_ReturnsSpeakers_When_AppLoading()
        {
            //Arrange
            var speakers = new List<Speaker>
            {
                new SpeakerFixture().WithName("Speaker A"),
                new SpeakerFixture().WithName("Speaker B"),
            };

            var repository = new SpeakerRepositoryFixture()
                .WitSpeakers(speakers);

            //Act
            var viewModel = new SpeakersViewModel(repository);

            //Assert
            Assert.Equal(speakers, viewModel.Speakers);
        }

        [Fact]
        public void GetSpeakersCommand_Ascending_BeSortedAsExpected_When_SortByChanges()
        {
            //Arrange;
            var speakers = new string[] { "Speaker B", "Speaker A", "Speaker C" };
            var expectedAscSpeakerNames = new string[] { "Speaker A", "Speaker B", "Speaker C" };
           
            var repository = new SpeakerRepositoryFixture()
                .WitSpeakers(speakers.Select(name => (Speaker)new SpeakerFixture().WithName(name)));

            var viewModel = new SpeakersViewModel(repository);

            //Act
            viewModel.SortSpeakersCommand.Execute(SortedBy.Ascending);

            //Assert
            Assert.Equal(expectedAscSpeakerNames, viewModel.Speakers.Select(x => x.Name));
        }

        [Fact]
        public void GetSpeakersCommand_Descending_BeSortedAsExpected_When_SortByChanges()
        {
            //Arrange;
            var speakers = new string[] { "Speaker B", "Speaker A", "Speaker C" };
            var expectedDescSpeakerNames = new string[] { "Speaker C", "Speaker B", "Speaker A" };

            var repository = new SpeakerRepositoryFixture()
                .WitSpeakers(speakers.Select(name => (Speaker)new SpeakerFixture().WithName(name)));

            var viewModel = new SpeakersViewModel(repository);

            //Act
            viewModel.SortSpeakersCommand.Execute(SortedBy.Descending);

            //Assert
            Assert.Equal(expectedDescSpeakerNames, viewModel.Speakers.Select(x => x.Name));
        }

        [Theory]
        [InlineData(SortedBy.Ascending, new string[] { "Speaker B", "Speaker A", "Speaker C" }, new string[] { "Speaker A",  "Speaker B", "Speaker C" })]
        [InlineData(SortedBy.Descending, new string[] { "Speaker A", "Speaker B", "Speaker C" }, new string[] { "Speaker C", "Speaker B", "Speaker A" })]
        public void GetSpeakersCommand_UsingInLine_Should_BeSortedAsExpected_When_SortByChanges(SortedBy sortedBy, string[] speakers, string[] expectedSpeakerNames)
        {
            //Arrange;
            var repository = new SpeakerRepositoryFixture()
                .WitSpeakers(speakers.Select(name => (Speaker) new SpeakerFixture().WithName(name)));

            var viewModel = new SpeakersViewModel(repository);

            //Act
            viewModel.SortSpeakersCommand.Execute(sortedBy);

            //Assert
            Assert.Equal(expectedSpeakerNames, viewModel.Speakers.Select(x => x.Name));
        }

        [Theory]
        [ClassData(typeof(SpeakerSortTestData))]
        public void GetSpeakersCommand_UsingTestData_Should_BeSortedAsExpected_When_SortByChanges(SortedBy sortedBy, List<Speaker> speakers, List<Speaker> expectedSpeakers)
        {
            //Arrange;
            var repository = new SpeakerRepositoryFixture()
                .WitSpeakers(speakers);

            var viewModel = new SpeakersViewModel(repository);

            //Act
            viewModel.SortSpeakersCommand.Execute(sortedBy);

            //Assert
            Assert.Equal(expectedSpeakers, viewModel.Speakers);
        }
    }
}
