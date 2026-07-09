using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace ncrecordshopfrontend.Model
{
    public class Album
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string Artist { get; set; } = "";
        // string or enum
        public string Genre { get; set; } = "";
        // string or DateOnly
        public DateOnly ReleaseDate { get; set; }
        public List<string> TrackList { get; set; } = new();
        public string ImageUrl { get; set; } = "";

        public static List<Album> GetMockAlbums()
        {
            return new List<Album>
            {
                new Album
                {
                    Id = 1,
                    Quantity = 3,
                    Price = 29.99m,
                    Name = "The Dark Side of the Moon",
                    Description = "The eigth albumn by Pink Floyd, it's a concept album exploring themes of conflict, greed, time",
                    Artist = "Pink Floyd",
                    Genre = "Progressive Rock",
                    ReleaseDate = new DateOnly(1973, 3, 1),
                    ImageUrl = "images/records/the-dark-side-of-the-moon.jpg",
                    TrackList = new List<string>
                    {
                        "Speak To Me",
                        "Breathe",
                        "On The Run",
                        "Time",
                        "The Great Gig In The Sky",
                        "Money",
                        "Us And Them",
                        "Any Colour You Like",
                        "Brain Damage",
                        "Eclipse"
                    }
                },
                new Album
                {
                    Id = 2,
                    Quantity = 0,
                    Price = 19.99m,
                    Name = "Bad",
                    Description = "One of the best selling albums of all time",
                    Artist = "Michael Jackson",
                    Genre = "Dance-pop",
                    ReleaseDate = new DateOnly(1987, 8, 31),
                    ImageUrl = "images/records/bad.jpg",
                    TrackList = new List<string>
                    {
                        "I Just Can't Stop Loving You",
                        "Bad",
                        "The Way You Make Me Feel",
                        "Man in the Mirror",
                        "Dirty Diana",
                        "Another Part of Me",
                        "Smooth Criminal",
                        "Leave Me Alone",
                        "Liberian Girl"
                    }
                },
                new Album
                {
                    Id = 3,
                    Quantity = 17,
                    Price = 21.99m,
                    Name = "21",
                    Description = "Named after Adele's age during it's production",
                    Artist = "Adele",
                    Genre = "Pop",
                    ReleaseDate = new DateOnly(2011, 1, 24),
                    ImageUrl = "images/records/21.jpg",
                    TrackList = new List<string>
                    {
                        "Rolling in the Deep",
                        "Someone like You",
                        "Set Fire to the Rain",
                        "Rumour Has It",
                        "Turning Tables"
                    }
                }
            };
        }
    }
}
