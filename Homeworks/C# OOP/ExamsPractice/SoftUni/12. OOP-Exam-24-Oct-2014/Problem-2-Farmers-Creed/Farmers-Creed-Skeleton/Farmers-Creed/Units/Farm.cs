namespace FarmersCreed.Units
{
    using System;
    using System.Collections.Generic;
    using FarmersCreed.Interfaces;

    public class Farm : GameObject, IFarm
    {
        private List<Plant> plants;
        private List<Animal> animals;
        private List<Product> products;

        public Farm(string id)
            : base(id)
        {
            this.plants = new List<Plant>();
            this.animals = new List<Animal>();
            this.products = new List<Product>();
        }

        public List<Plant> Plants
        {
            get
            {
                return this.plants;
            }
        }

        public List<Animal> Animals
        {
            get
            {
                return this.animals;
            }
        }

        public List<Product> Products
        {
            get
            {
                return this.products;
            }
        }

        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        public void Exploit(IProductProduceable productProducer)
        {
            throw new NotImplementedException();
        }

        public void Feed(Animal animal, IEdible edibleProduct, int productQuantity)
        {
            throw new NotImplementedException();
        }

        public void Water(Plant plant)
        {
            throw new NotImplementedException();
        }

        public void UpdateFarmState()
        {
            // TODO: Process all animal and plant behavior
            //throw new NotImplementedException();
        }
    }
}
