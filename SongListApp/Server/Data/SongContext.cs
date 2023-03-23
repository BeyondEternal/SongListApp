using Microsoft.EntityFrameworkCore;
using SongListApp.Shared.Model;

namespace SongListApp.Server.Data
{
    public class SongContext : DbContext
    {
        public SongContext(DbContextOptions<SongContext> options) : base(options)
        {
        }

        public DbSet<Song> Songs { get; set; }
    }

}
