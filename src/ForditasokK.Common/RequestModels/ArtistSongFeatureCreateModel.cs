using System.ComponentModel.DataAnnotations;

namespace ForditasokK.Common.RequestModels
{
    public class ArtistSongFeatureCreateModel
    {
        [Required]
        public long ArtistId { get; set; }

        [Required]
        public bool IsMainArtist { get; set; }
    }
}
