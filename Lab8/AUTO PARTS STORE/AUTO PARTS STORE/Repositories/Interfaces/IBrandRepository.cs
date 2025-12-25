using AUTO_PARTS_STORE.Models;

namespace AUTO_PARTS_STORE.Repositories.Interfaces
{
    public interface IBrandRepository
    {
        List<Brand> GetAll();
        Brand? GetById(int id);
        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(int id);
    }
}
