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
                _context.Categories.Add(new Category { Name = "Accesorios" });
                _context.Categories.Add(new Category { Name = "aderezos" });
                _context.Categories.Add(new Category { Name = "arte" });
                _context.Categories.Add(new Category { Name = "Aseo" });
                _context.Categories.Add(new Category { Name = "automoviles" });
                _context.Categories.Add(new Category { Name = "Belleza" });
                _context.Categories.Add(new Category { Name = "celulares" });
                _context.Categories.Add(new Category { Name = "Cocina" });
                _context.Categories.Add(new Category { Name = "comida extranjera" });
                _context.Categories.Add(new Category { Name = "computadores" });
                _context.Categories.Add(new Category { Name = "Electrodomésticos" });
                _context.Categories.Add(new Category { Name = "Herramientas" });
                _context.Categories.Add(new Category { Name = "Moda Hombre" });
                _context.Categories.Add(new Category { Name = "Moda Infantil" });
                _context.Categories.Add(new Category { Name = "Moda Mujer" });
                _context.Categories.Add(new Category { Name = "Muebles y Decoracion" });
                _context.Categories.Add(new Category { Name = "ropa" });
                _context.Categories.Add(new Category { Name = "soldadura" });
                _context.Categories.Add(new Category { Name = "Tecnología" });
                _context.Categories.Add(new Category { Name = "tuberia" });
                await _context.SaveChangesAsync();
            }
        }
    }
}
