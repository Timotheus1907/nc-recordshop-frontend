namespace ncrecordshopfrontend.Model
{
    public class Album
    {
        //Todo add price, image

        public int Id { get; set; }
        public int Quantity { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string Artist { get; set; } = "";
        // string or enum
        public string Genre { get; set; } = "";
        // string or DateOnly
        public DateOnly ReleaseDate { get; set; }
        public List<string> TrackList { get; set; } = new();

        public static List<Album> GetMockAlbums()
        {
            return new List<Album>
            {
                new Album
                {
                    Id = 1,
                    Quantity = 3,
                    Name = "The Dark Side of the Moon",
                    Description = "The eigth albumn by Pink Floyd, it's a concept album exploring themes of conflict, greed, time",
                    Artist = "Pink Floyd",
                    Genre = "Progressive Rock",
                    ReleaseDate = new DateOnly(1973, 3, 1),
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
                    Name = "Bad",
                    Description = "One of the best selling albums of all time",
                    Artist = "Michael Jackson",
                    Genre = "Dance-pop",
                    ReleaseDate = new DateOnly(1987, 8, 31),
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
                    Name = "21",
                    Description = "Named after Adele's age during it's production",
                    Artist = "Adele",
                    Genre = "Pop",
                    ReleaseDate = new DateOnly(2011, 1, 24),
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
