using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ArtistSystem.Models
{
    public class Album
    {
        private ICollection<Song> songs;
        private ICollection<Artist> artists;
        private ICollection<Image> images;
             
        public Album()
        {
            this.Id = Guid.NewGuid();
            this.Songs = new HashSet<Song>();
            this.Artists = new HashSet<Artist>();
            this.Images = new HashSet<Image>();
        }

        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        /// <summary>
        /// Nullable if the album is not released
        /// </summary>
        public DateTime? ReleasedOn { get; set; }

        [Required]
        public AlbumState Status { get; set; }

        [Column("Price", TypeName = "money")]
        public decimal? Price { get; set; }

        public virtual ICollection<Image> Images
        {
            get
            {
                return this.images;
            }
            set
            {
                this.images = value;
            }
        }

        public virtual ICollection<Song> Songs
        {
            get
            {
                return this.songs;
            }
            set
            {
                this.songs = value;
            }
        }

        public virtual ICollection<Artist> Artists
        {
            get
            {
                return this.artists;
            }
            set
            {
                this.artists = value;
            }
        }
    }
}
