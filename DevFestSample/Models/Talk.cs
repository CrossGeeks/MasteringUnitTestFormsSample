using System;
namespace DevFestSample.Models
{
    public class Talk
    {
        public Talk(string title, string description, Speaker speaker, DateTime startTime, DateTime endTime)
        {
            Title = title;
            Description = description;
            StartTime = startTime;
            EndTime = endTime;
            Speaker = speaker;
        }

        public string Title { get; }
        public string Description { get; }
        public Speaker Speaker { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
    }
}
