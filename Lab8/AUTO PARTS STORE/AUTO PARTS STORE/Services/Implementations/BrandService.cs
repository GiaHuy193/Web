using AUTO_PARTS_STORE.Models;
using AUTO_PARTS_STORE.Repositories.Interfaces;
using AUTO_PARTS_STORE.Services.Interface;

namespace AUTO_PARTS_STORE.Services.Implementations
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;

        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }
        public List<Brand> GetAllBrands()
        {
            return _brandRepository.GetAll();
        }
        public Brand? GetBrandById(int id)
        {
            return _brandRepository.GetById(id);
        }
        public void CreateBrand(Models.Brand brand)
        {
            _brandRepository.Add(brand);
        }
        public void UpdateBrand(Models.Brand brand)
        {
            _brandRepository.Update(brand);
        }
        public void DeleteBrand(int id)
        {
            _brandRepository.Delete(id);
        }
    }
}
