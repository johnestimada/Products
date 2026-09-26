using JB.Models.DTO;

namespace JB.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetAllAsync();
        Task<ProductDTO?> GetByIdAsync(int id);
        Task<ProductDTO> CreateAsync(CreateProductDTO input);
    }
}
