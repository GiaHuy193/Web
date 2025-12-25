using AUTO_PARTS_STORE.Models;
using AUTO_PARTS_STORE.Repositories.Interfaces;
using AUTO_PARTS_STORE.Services.Interface;

namespace AUTO_PARTS_STORE.Services.Implementations
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _repository;

        public CarService(ICarRepository repository)
        {
            _repository = repository;
        }
        public List<Car> GetAllCars()
        {
            return _repository.GetAll();
        }
        public Car? GetCarById(int id)
        {
            return _repository.GetById(id);
        }
        public void CreateCar(Car car)
        {
            _repository.Add(car);
        }
        public void UpdateCar(Car car)
        {
            _repository.Update(car);
        }
        public void DeleteCar(int id)
        {
            _repository.Delete(id);
        }
    }
}
