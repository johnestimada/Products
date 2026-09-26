namespace JB.Repositories
{
    public interface Iproduct_Repositories
    {

        Task<IEnumerable<ProductDTO>> GetAllAsync();
        Task<ProductDTO?> GetByIdAsync(int id);
        Task<ProductDTO> CreateAsync(Product input);

    }
}