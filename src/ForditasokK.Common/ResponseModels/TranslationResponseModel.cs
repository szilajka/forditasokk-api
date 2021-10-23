using ForditasokK.Common.ResponseModels.BaseModels;

namespace ForditasokK.Common.ResponseModels
{
    public class TranslationResponseModel : TranslationBaseResponseModel
    {
        public ArtistsSongModel Song { get; set; }
        public string TranslatorId { get; set; }
    }
}
