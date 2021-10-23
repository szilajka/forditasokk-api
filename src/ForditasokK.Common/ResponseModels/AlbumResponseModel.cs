using System;
using ForditasokK.Common.ResponseModels.BaseModels;

namespace ForditasokK.Common.ResponseModels
{
    public class AlbumResponseModel : AlbumBaseResponseModel
    {
        public AlbumsArtistModel Artist { get; set; }
        public ArtistsSongModel[] Songs { get; set; }
    }
}
