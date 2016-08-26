namespace MasterChef.Models
{
    using System;
    using Contracts;

    public abstract class Vegetable : IVegetable
    {
        public bool IsCutted { get; set; }

        public bool IsPeeled { get; set; }
    }
}
