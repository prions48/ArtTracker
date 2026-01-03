using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtTracker.Data.Trophies
{
    public class Category
    {
        [Key] public Guid ID { get; set; } = Guid.NewGuid();
        public Guid UserID { get; set; }
        public string CategoryName { get; set; } = "";
        public MudBlazor.Color CategoryColor { get; set; }
        public int OrderNumber { get; set; }
        public List<Item> Items { get; set; } = [];
        public int Score => Items.Where(e => e.Completed).Sum(e => e.Score);
        public List<EffortChartPt> Points(bool inprogress) => Items.Where(e => e.Completed || inprogress).SelectMany(e => e.CalculatePt()).ToList();
    }
}