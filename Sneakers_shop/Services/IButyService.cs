using Microsoft.Extensions.Hosting;
using Sneakers_shop.Models;

namespace Sneakers_shop.Services
{
    public interface IButyService
    {
        public int Save(Buty but);

        public bool Delete(int? id);

        public ICollection<Buty> FindAll();
    }
}
