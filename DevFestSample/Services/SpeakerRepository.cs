using System.Collections.Generic;
using DevFestSample.Models;

namespace DevFestSample.Services
{
    public class SpeakerRepository : ISpeakerRepository
    {
        public IEnumerable<Speaker> GetSpeakers()
        {
            return new List<Speaker>
            {
                new Speaker("Daviana Núñez", "https://puu.sh/JoNFt/bb266b87a8.png", "Profesional en Marketing Digital", "UI/UX"),
                new Speaker("Andres Pineda", "https://puu.sh/JoNCB/381cf30a2a.png", "Un tiguere duro", "Developer"),
                new Speaker("Alice", "https://puu.sh/JoNHi/e4d0f22d65.png", "Ingeniera en sistemas","UI/UX"),
                new Speaker("Christian Moreno", "https://puu.sh/JoNFj/ad950819de.png", "GDE in Web Technologies", "Developer"),
                new Speaker("Carlos Huamán", "https://puu.sh/JoNF8/8283a35bf5.png", "BCP Dad", "Developer"),
                new Speaker("José Aquino", "https://puu.sh/JoNFG/4c6a62191d.png", "Ingeniero en sistemas", "Developer")
            };
        }
    }
}
