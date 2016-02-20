using System;
using System.Net.Configuration;
using System.Runtime.CompilerServices;

namespace Task1
{
    public struct Notebook
    {
        private string model;
        private string manufacturer;
        private decimal price;

        public Notebook(string model,string manufacturer, decimal price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public Notebook(string model,string manufacturer)
           :this(model, manufacturer, 0)
        {
            
        }

        public Notebook(string model)
            : this(model, "", 0)
        {
            
        }
        public string Model{get { return model; } }
        public string Manufacturer { get { return manufacturer; } }
        public decimal Price { get { return price; } }
        public void ShowNotebookInfo()
        {
            Console.WriteLine("Model: {0} Manufacturer: {1} Price: {2}",model,manufacturer,price);
        }
    }
}