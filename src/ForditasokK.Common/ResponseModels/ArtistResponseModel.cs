using ForditasokK.Common.ResponseModels.BaseModels;

namespace ForditasokK.Common.ResponseModels
{
    public class ArtistResponseModel : ArtistBaseResponseModel
    {
        public PublisherWithContractModel ActivePublisher { get; set; }
        public PublisherWithContractModel[] PastPublishers { get; set; }
        public AlbumResponseModel[] Albums { get; set; }
        public ArtistsSongModel[] Songs { get; set; }
    }
}
