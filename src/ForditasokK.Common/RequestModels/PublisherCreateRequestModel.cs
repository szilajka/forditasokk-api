using ForditasokK.Common.RequestModels.Channels;
using System.ComponentModel.DataAnnotations;

namespace ForditasokK.Common.RequestModels
{
    public class PublisherCreateRequestModel
    {
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        public byte[] Logo { get; set; }

        public PublisherChannelCreateRequestModel[] PublisherChannel { get; set; }
    }
}
