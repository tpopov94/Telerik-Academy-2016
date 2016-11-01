using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtistSystem.Models
{
    public class Category
    {
        private ICollection<Category> categories;

        public Category()
        {
            this.categories = new HashSet<Category>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int ParentId { get; set; }

        [InverseProperty("Subcategories")]
        public virtual Category Parent { get; set; }

        public virtual ICollection<Category> Subcategories
        {
            get
            {
                return this.categories;
            }
            set
            {
                this.categories = value;
            }
        }
    }
}
