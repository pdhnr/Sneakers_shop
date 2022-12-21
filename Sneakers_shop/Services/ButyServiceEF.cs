using Sneakers_shop.Models;
using Microsoft.EntityFrameworkCore;

namespace Sneakers_shop.Services
{
    public class ButyServiceEF : IButyService
    {
        private readonly AppDbContext _context;

        public ButyServiceEF(AppDbContext context)
        {
            _context = context;
        }

        public bool Delete(int? id)
        {
            if (id is null)
            {
                return false;
            }

            var find = _context.Buty.Find(id);
            if (find is not null)
            {
                _context.Buty.Remove(find);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public ICollection<Buty> FindAll()
        {
            return _context.Buty.ToList();
        }

        public int Save(Buty buty)
        {
            try
            {
                var entityEntry = _context.Buty.Add(buty);
                _context.SaveChanges();
                return entityEntry.Entity.Id;
            }
            catch
            {
                return -1;
            }
        }
    }
}
