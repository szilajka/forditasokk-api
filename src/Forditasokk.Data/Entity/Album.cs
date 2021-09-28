using System;
using System.Collections.Generic;

namespace Forditasokk.Data.Entity
{
    public class Album : BaseEntity
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string CoverPath { get; set; }
        public long ArtistId { get; set; }
        public Artist Artist { get; set; }
        public IList<Song> Songs { get; set; }
    }
}
