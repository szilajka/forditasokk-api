using ForditasokK.Common.RequestModels.Channels;
using System.ComponentModel.DataAnnotations;

namespace ForditasokK.Common.RequestModels
{
    public class SongCreateRequestModel
    {
        [Required]
        [MaxLength(256)]
        public string Title { get; set; }

        [Required]
        [MaxLength(40000)]
        public string Lyrics { get; set; }

        [Required]
        public long AlbumId { get; set; }

        public SongChannelCreateRequestModel[] SongChannels { get; set; }

        public ArtistSongFeatureCreateModel ArtistSongFeatures { get; set; }
    }
}
