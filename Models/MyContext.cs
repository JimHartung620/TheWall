using Microsoft.EntityFrameworkCore;

namespace TheWall.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}
    }
}