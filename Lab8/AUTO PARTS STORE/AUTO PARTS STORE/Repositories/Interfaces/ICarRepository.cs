using AUTO_PARTS_STORE.Models;

namespace AUTO_PARTS_STORE.Repositories.Interfaces
{
    public interface ICarRepository
    {
        List<Car> GetAll();
        Car? GetById(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(int id);
    }
}
