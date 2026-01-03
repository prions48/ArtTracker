using System.ComponentModel.DataAnnotations;

namespace ArtTracker.Data.Trophies
{
    public class Effort
    {
        [Key] public Guid ID { get; set; } = Guid.NewGuid();
        public Guid ItemID { get; set; }
        public int EffortLevel { get; set; }
        public int HoursSpent { get; set; }
        public DateTime CreatedTimeStamp { get; set; }
        public string? EffortNotes { get; set; }
        public Item? Item { get; set; }
        public EffortChartPt CalculatePoint()
        {
            return new()
            {
                TotalEffort = EffortLevel * HoursSpent,
                Date = CreatedTimeStamp
            };
        }
    }
}