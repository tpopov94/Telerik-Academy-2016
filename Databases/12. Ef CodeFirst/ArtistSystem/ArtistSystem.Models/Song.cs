using System;
using System.ComponentModel.DataAnnotations;

namespace ArtistSystem.Models
{
    public class Song
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Title { get; set; }

        /// <summary>
        /// Song duration in seconds.
        /// </summary>
        [Required]
        [Range(0, 200000)]
        public int Duration { get; set; }

        public Guid AlbumId { get; set; }

        public virtual Album Album { get; set; }
    }
}
