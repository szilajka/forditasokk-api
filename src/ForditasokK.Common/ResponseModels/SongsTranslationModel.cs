using ForditasokK.Common.ResponseModels.BaseModels;

namespace ForditasokK.Common.ResponseModels
{
    public class SongsTranslationModel : TranslationBaseResponseModel
    {
        public long SongId { get; set; }
        public string TranslatorId { get; set; }
    }
}
