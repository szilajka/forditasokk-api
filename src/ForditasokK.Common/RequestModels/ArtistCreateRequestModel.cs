using ForditasokK.Common.RequestModels.Channels;
using System;
using System.ComponentModel.DataAnnotations;

namespace ForditasokK.Common.RequestModels
{
    public class ArtistCreateRequestModel
    {
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        public DateTime DebutDate { get; set; }


        public byte[] ProfilePicture { get; set; }

        [MaxLength(256)]
        public string FansName { get; set; }

        [Required]
        public long PublisherId { get; set; }

        public ArtistChannelCreateRequestModel[] ArtistChannels { get; set; }
    }
}
