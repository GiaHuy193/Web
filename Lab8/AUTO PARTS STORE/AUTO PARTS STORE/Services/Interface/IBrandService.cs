using AUTO_PARTS_STORE.Models;

namespace AUTO_PARTS_STORE.Services.Interface
{
    public interface IBrandService
    {
        List<Brand> GetAllBrands();
        Brand? GetBrandById(int id);
        void CreateBrand(Brand brand);
        void UpdateBrand(Brand brand);
        void DeleteBrand(int id);
    }
}
