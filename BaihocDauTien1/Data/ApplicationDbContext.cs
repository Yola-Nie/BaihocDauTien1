using Microsoft.EntityFrameworkCore;
using BaihocDauTien1;
using BaihocDauTien1.Models;
namespace BaihocDauTien1.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
    }
}
