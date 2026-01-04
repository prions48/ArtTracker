using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtTracker.Data.Trophies
{
    public class Item
    {
        [Key] public Guid ID { get; set; } = Guid.NewGuid();
        public Guid CategoryID { get; set; }
        public string ItemName { get; set; } = "";
        public string? ItemDescription { get; set; }
        public DateTime CreatedTimeStamp { get; set; }
        public bool Completed { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int? EstEffort { get; set; }
        public Category? Category { get; set; }
        public List<Effort> Efforts { get; set; } = [];
        public int Score => Efforts.Sum(e => e.HoursSpent * e.EffortLevel);
        public List<EffortChartPt> CalculatePt()
        {
            return Efforts.Select(e => e.CalculatePoint()).ToList();
        }
        [NotMapped] public bool ViewEfforts { get; set; } = false;
    }
}