using System;
using System.ComponentModel.DataAnnotations;

namespace ForditasokK.Common.QueryModels.FilterModels
{
    public class NameAndDateFilterModel
    {
        [MaxLength(256)]
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
