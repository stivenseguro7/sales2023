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
                _context.Categories.Add(new Category { Name = "Ropa" });
                _context.Categories.Add(new Category { Name = "Calzado" });
                _context.Categories.Add(new Category { Name = "Accesorios de moda" });
                _context.Categories.Add(new Category { Name = "Joyas" });
                _context.Categories.Add(new Category { Name = "Relojes" });
                _context.Categories.Add(new Category { Name = "Gafas" });
                _context.Categories.Add(new Category { Name = "Bolsos y carteras" });
                _context.Categories.Add(new Category { Name = "Cosméticos" });
                _context.Categories.Add(new Category { Name = "Productos para el cuidado del cabello" });
                _context.Categories.Add(new Category { Name = "Productos para el cuidado de la piel" });
                _context.Categories.Add(new Category { Name = "Perfumes y fragancias" });
                _context.Categories.Add(new Category { Name = "Maquillaje" });
                _context.Categories.Add(new Category { Name = "Productos para el cuidado de las uñas" });
                _context.Categories.Add(new Category { Name = "Productos para el cuidado dental" });
                _context.Categories.Add(new Category { Name = "Equipos de fitness" });
                _context.Categories.Add(new Category { Name = "Suplementos nutricionales" });
                _context.Categories.Add(new Category { Name = "Vitaminas y minerales" });
                _context.Categories.Add(new Category { Name = "Medicamentos de venta libre" });
                _context.Categories.Add(new Category { Name = "Productos para el cuidado de la salud" });
                _context.Categories.Add(new Category { Name = "Artículos deportivos" });
                _context.Categories.Add(new Category { Name = "Equipos deportivos" });
                _context.Categories.Add(new Category { Name = "Ropa deportiva" });
                _context.Categories.Add(new Category { Name = "Accesorios deportivos" });
                _context.Categories.Add(new Category { Name = "Alimentos y bebidas" });
                _context.Categories.Add(new Category { Name = "Bebidas alcohólicas" });
                _context.Categories.Add(new Category { Name = "Bebidas sin alcohol" });
                _context.Categories.Add(new Category { Name = "Productos para el hogar" });
                _context.Categories.Add(new Category { Name = "Artículos de decoración para el hogar" });
                _context.Categories.Add(new Category { Name = "Mobiliario para el hogar" });
                _context.Categories.Add(new Category { Name = "Electrodomésticos" });
                _context.Categories.Add(new Category { Name = "Productos de iluminación para el hogar" });
                _context.Categories.Add(new Category { Name = "Productos para el jardín" });
                _context.Categories.Add(new Category { Name = "Productos para mascotas" });
                _context.Categories.Add(new Category { Name = "Juguetes para mascotas" });
                _context.Categories.Add(new Category { Name = "Accesorios para mascotas" });
                _context.Categories.Add(new Category { Name = "Suministros para oficina" });
                _context.Categories.Add(new Category { Name = "Equipos para oficina" });
                _context.Categories.Add(new Category { Name = "Productos electrónicos" });
                _context.Categories.Add(new Category { Name = "Teléfonos móviles" });
                _context.Categories.Add(new Category { Name = "Ordenadores portátiles" });
                _context.Categories.Add(new Category { Name = "Computadoras de escritorio" });
                _context.Categories.Add(new Category { Name = "Tabletas" });
                _context.Categories.Add(new Category { Name = "Cámaras" });
                _context.Categories.Add(new Category { Name = "Altavoces" });
                await _context.SaveChangesAsync();
            }
        }
    }
}
