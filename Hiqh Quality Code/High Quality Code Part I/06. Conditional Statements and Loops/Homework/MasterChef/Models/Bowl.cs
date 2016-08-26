namespace MasterChef.Models
{
    using System.Collections.Generic;

    using Contracts;

    public class Bowl
    {
        private IList<IVegetable> ingredients;

        public Bowl()
        {
            this.ingredients = new List<IVegetable>();
        }

        public IList<IVegetable> Ingredients
        {
            get
            {
                return this.ingredients;
            }

            set
            {
                this.ingredients = new List<IVegetable>();
            }
        }

        public void Add(IVegetable vegetable)
        {
            this.ingredients.Add(vegetable);
        }
    }
}
