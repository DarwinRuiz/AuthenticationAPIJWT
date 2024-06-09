using AuthenticationAPIJWT.Models;

namespace AuthenticationAPIJWT.Data
{
    public static class DBContext
    {
        public static List<Country> Countries { get; set; }
        public static List<Product> Products { get; set; }
        public static List<Employee> Employees { get; set; }
        public static List<User> Users { get; set; }

        static DBContext()
        {

            Countries =
            [
                new Country() { Name = "Guatemala" },
                new Country() { Name = "Argentina" },
                new Country() { Name = "Mexico" },
            ];

            Products =
            [
                new Product() { Name = "Coca Cola", Description = "Bebida con gas" },
                new Product() { Name = "Agua Mineral", Description = "Agua mineral de 2L" },
            ];

            Employees =
            [
                new Employee() { FirstName = "Darwin Orlando", LastName = "Ruiz Mateo", Email = "druiz@email.com" },
                new Employee() { FirstName = "Kelly Yasmine", LastName = "Rivera Zacapa", Email = "krivera@email.com" },
            ];

            Users =
            [
                new User() { Username = "druiz", Password = "admin123", Rol = "Administrador", EmailAddress = "druiz@email.com", FirstName = "Darwin Orlando", LastName = "Ruiz Mateo" },
                new User() { Username = "krivera", Password = "admin123", Rol = "Vendedor", EmailAddress = "krivera@email.com", FirstName = "Kelly Yasmine", LastName = "Rivera Zacapa" },
            ];
        }
    }
}
