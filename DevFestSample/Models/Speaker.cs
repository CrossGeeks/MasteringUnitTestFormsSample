namespace DevFestSample.Models
{
    public class Speaker
    {
        public Speaker(string name, string photo, string headline= null, string tag= null)
        {
            Name = name;
            Photo = photo;
            Headline = headline;
            Tag = tag;
        }

        public string Name { get; }
        public string Photo { get; }
        public string Headline { get; }
        public string Tag { get; }
    }
}
