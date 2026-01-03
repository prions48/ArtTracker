using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ArtTracker.Data.Trophies
{
    public class TrophyService
    {
        private readonly TrophyContext _context;
        public TrophyService(TrophyContext context)
        {
            _context = context;
        }
        public List<Category> GetCategoriesByUserID(Guid userid)
        {
            return _context.TrophyCategories
                .Where(e => e.UserID == userid)
                .Include(e => e.Items)
                .ThenInclude(e => e.Efforts)
                .OrderBy(e => e.OrderNumber)
                .ToList();
        }
        public void CreateCategory(Category cat)
        {
            _context.TrophyCategories.Add(cat);
            _context.SaveChanges();
        }
        public void UpdateCategory(Category cat)
        {
            _context.TrophyCategories.Update(cat);
            _context.SaveChanges();
        }
        public void DeleteCategory(Category cat)
        {
            _context.TrophyCategories.Remove(cat);
            _context.SaveChanges();
        }
        public void CreateItem(Item item)
        {
            _context.TrophyItems.Add(item);
            _context.SaveChanges();
        }
        public void UpdateItem(Item item)
        {
            _context.TrophyItems.Update(item);
            _context.SaveChanges();
        }
        public void DeleteItem(Item item)
        {
            _context.TrophyItems.Remove(item);
            _context.SaveChanges();
        }
        public void CreateEffort(Effort effort)
        {
            _context.TrophyItemEfforts.Add(effort);
            _context.SaveChanges();
        }
        public void UpdateEffort(Effort effort)
        {
            _context.TrophyItemEfforts.Update(effort);
            _context.SaveChanges();
        }
    }
}