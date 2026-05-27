namespace BoredButBrokeFE.Components.Models
{
    public class OpeningHours
    {
        public List<Hour> Hours { get; set; } = new List<Hour>();
        public string HoursType { get; set; } = string.Empty;
        public bool IsOpenNow { get; set; } = false;
    }
}
