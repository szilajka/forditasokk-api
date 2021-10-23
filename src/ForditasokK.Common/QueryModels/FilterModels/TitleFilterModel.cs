using System.ComponentModel.DataAnnotations;

namespace ForditasokK.Common.QueryModels.FilterModels
{
    public class TitleFilterModel
    {
        [MaxLength(256)]
        public string Title { get; set; }
    }
}
