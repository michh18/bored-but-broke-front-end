using System.Security.AccessControl;

namespace BoredButBrokeFE.Components.Models
{
    public class Activity
    {
        public string ActivityId { get; set; } = "";
        public string ActivityName { get; set; } = "";
        public string Address { get; set; } = "";
        public string MainCategory { get; set; } = "";
        public string SubCategory { get; set; } = "";
        public Price Price { get; set; } = Price.Cheap;
        public double Latitude { get; set; } = 0.00;
        public double Longitude { get; set; } = 0.00;
        public Hours Hours { get; set; } = default; 
        public double Rating { get; set; } = 0.00;
        public string LocationUrl { get; set; } = "";
        public string PhotoUrl { get; set; } = "";
    }
}
