namespace AUTO_PARTS_STORE.Models
{
    public class CarModelVm
    {
        public int Id { get; set; }
        public string CarModelName { get; set; } = null!;
        public int BrandId { get; set; }
        public string BrandName { get; set; } = null!;
    }
}
