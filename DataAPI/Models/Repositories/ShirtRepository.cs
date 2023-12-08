namespace DataAPI.Models.Repositories
{
    public class ShirtRepository
    {
        private static List<Shirt> shirts = new List<Shirt>()
        {
            new Shirt { ShirtId = 1, Brand = "Abdur", Color = "Blue", Gender = "Men", Price = 30, Size = 10 },
            new Shirt { ShirtId = 2, Brand = "Abdur", Color = "Black", Gender = "Men", Price = 35, Size = 12 },
            new Shirt { ShirtId = 3, Brand = "Rahman", Color = "Red", Gender = "Women", Price = 40, Size = 8 },
            new Shirt { ShirtId = 4, Brand = "Rahman", Color = "Green", Gender = "Women", Price = 45, Size = 9 }
        };
        
        public static bool ShirtExists(int id)
        {
            return shirts.Any(x => x.ShirtId == id);
        }

        public static Shirt? GetShirtById(int id)
        {
            return shirts.FirstOrDefault(x => x.ShirtId == id);
        }
    }
}
