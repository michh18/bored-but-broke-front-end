using System.Security.AccessControl;

namespace BoredButBrokeFE.Components.Models
{
    public class Activity
    {
        public string ActivityId { get; set; }
        public string ActivityName { get; set; }
        public string Address { get; set; }
        public string MainCategory { get; set; }
        public string SubCategory { get; set; }
        public Price Price { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Hours Hours { get; set; }
        public double Rating { get; set; }
        public string LocationUrl { get; set; }
        public string PhotoUrl { get; set; }
    }
}
