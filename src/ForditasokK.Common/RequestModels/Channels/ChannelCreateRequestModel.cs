using Forditasokk.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace ForditasokK.Common.RequestModels.Channels
{
    public class ChannelCreateRequestModel
    {
        [Required]
        public ChannelTypes ChannelType { get; set; }

        [Required]
        [MaxLength(512)]
        public string Link { get; set; }
    }
}
