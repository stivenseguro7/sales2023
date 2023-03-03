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
                _context.Categories.Add(new Category { Name = "Moda Hombre" });
                _context.Categories.Add(new Category { Name = "Moda Mujer" });
                _context.Categories.Add(new Category { Name = "Aseo" });
                _context.Categories.Add(new Category { Name = "Cocina" });
                _context.Categories.Add(new Category { Name = "Muebles y Decoracion" });
                _context.Categories.Add(new Category { Name = "Accesorios" });
                _context.Categories.Add(new Category { Name = "Belleza" });
                await _context.SaveChangesAsync();
            }
        }
    }
}
