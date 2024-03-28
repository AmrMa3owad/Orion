namespace Orion.Models
{
    public class Event : BaseEntity<int>
    {
        public DateTime EventDate { get; set; }
        public string EventTitle { get; set; }
        public string EventPlace { get; set; }
    }
}
