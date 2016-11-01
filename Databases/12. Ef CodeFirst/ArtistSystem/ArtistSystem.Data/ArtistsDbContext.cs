using System.Data.Entity;

using ArtistSystem.Models;

namespace ArtistSystem.Data
{
    public class ArtistsDbContext : DbContext
    {
        // ArtistDb is the connection string
        public ArtistsDbContext()
            : base("ArtistsDb")
        {
        }

        /// <summary>
        /// DbSet can be made virtual if we want to unit test them
        /// </summary>
        public virtual IDbSet<Album> Albums { get; set; }

        public virtual IDbSet<Song> Songs { get; set; }

        public virtual IDbSet<Artist> Artists { get; set; }

        public virtual IDbSet<Image> Images { get; set; }

        public virtual IDbSet<Category> Categories { get; set; }
    }
}
