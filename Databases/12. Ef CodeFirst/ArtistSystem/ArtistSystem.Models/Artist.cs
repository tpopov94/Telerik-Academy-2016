using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtistSystem.Models
{
    public class Artist
    {
        private ICollection<Album> albums;

        public Artist()
        {
            this.Members = 1;
            this.albums = new HashSet<Album>();
        }

        public int Id { get; set; }

        [Range(0, 200)]
        public int Age { get; set; }

        [Required]
        [MaxLength(40)]
        //[Index(IsUnique = true)]
        public string Name { get; set; }

        [Index]
        public bool IsGroup { get; set; }

        public int Members { get; set; }

        public virtual ICollection<Album> Albums
        {
            get
            {
                return this.albums;
            }
            set
            {
                this.albums = value;
            }
        }
    }
}