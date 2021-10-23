using System.ComponentModel.DataAnnotations;

namespace ForditasokK.Common.RequestModels
{
    public class TranslationCreateRequestModel
    {
        [Required]
        [MaxLength(256)]
        public string Title { get; set; }

        [Required]
        [MaxLength(40000)]
        public string Lyrics { get; set; }

        [Required]
        public long SongId { get; set; }

        [Required]
        public string TranslatorId { get; set; }
    }
}
