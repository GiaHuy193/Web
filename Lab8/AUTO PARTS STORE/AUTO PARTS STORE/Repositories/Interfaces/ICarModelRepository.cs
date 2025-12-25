using AUTO_PARTS_STORE.Models;

namespace AUTO_PARTS_STORE.Repositories.Interfaces
{
    public interface ICarModelRepository
    {
        List<CarModelVm> GetAll();
        CarModel? GetById(int id);
        void Add(CarModel carModel);
        void Update(CarModel carModel);
        void Delete(int id);

    }
}
