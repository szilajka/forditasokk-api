using ForditasokK.Common.ResponseModels.BaseModels;

namespace ForditasokK.Common.ResponseModels
{
    public class SongResponseModel : SongBaseResponseModel
    {
        public SongsAlbumModel Album { get; set; }
        public SongsTranslationModel[] Translations { get; set; }
    }
}
