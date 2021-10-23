using System;

namespace ForditasokK.Common.ResponseModels.BaseModels
{
    public class AlbumBaseResponseModel : HistoryInformationsModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public byte[] Cover { get; set; }
    }
}