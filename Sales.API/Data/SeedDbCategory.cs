using Sales.shared.entities;

namespace Sales.API.Data
{
    public class SeedDbCategory
    {
        private readonly DataContext _context;

        public SeedDbCategory(DataContext context)
        {
            _context = context;
        }
        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckConstraintAsync();
        }

        private async Task CheckConstraintAsync()
        {
            if (!_context.Categories.Any())
            {
                _context.Categories.Add(new Category { Name = "Tecnología" });
                _context.Categories.Add(new Category { Name = "Electrodomésticos" });
                _context.Categories.Add(new Category { Name = "Moda Infantil" });
                await _context.SaveChangesAsync();
            }
        }
    }
}
