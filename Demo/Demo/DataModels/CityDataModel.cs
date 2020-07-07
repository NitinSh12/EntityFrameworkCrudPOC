using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.DataModels
{
    public class CityDataModel
    {
        [Key]
        public Guid CityId { get; set; }
        public string CityName { get; set; }
        public string AbbreviatedName { get; set; }
        public Guid StateId { get; set; }
        public long Pincode { get; set; }
        public bool IsActive { get; set; }
    }
}
