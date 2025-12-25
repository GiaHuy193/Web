using AUTO_PARTS_STORE.Models;

namespace AUTO_PARTS_STORE.Services.Interface
{
    public interface ICarModelService
    {
        List<CarModelVm> GetCarModels();
        CarModel? GetCarModelById(int id);
        void CreateCarModel(CarModel carModel);
        void UpdateCarModel(CarModel carModel);
        void DeleteCarModel(int id);
    }
}
