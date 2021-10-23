using System;
using System.ComponentModel.DataAnnotations;

namespace ForditasokK.Common.RequestModels
{
    public class AlbumCreateRequestModel
    {
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public byte[] Cover { get; set; }

        [Required]
        public long ArtistId { get; set; }
    }
}
