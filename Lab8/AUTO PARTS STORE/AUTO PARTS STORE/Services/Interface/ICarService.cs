using AUTO_PARTS_STORE.Models;

namespace AUTO_PARTS_STORE.Services.Interface
{
    public interface ICarService
    {
        List<Car> GetAllCars();
        Car? GetCarById(int id);
        void CreateCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(int id);
    }
}
