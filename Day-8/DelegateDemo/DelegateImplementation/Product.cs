using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateImplementation
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Product()
        {

        }
        public Product(string name, int id, decimal price, string description)
        {
            this.Name = name;
            this.Id = id;
            this.Price = price;
            this.Description = description;
        }

        public override string ToString()
        {
            return $"{Name},{Id},{Price},{Description}";
        }

        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                if (obj is Product)
                {
                    Product other = obj as Product;
                    if (this == other)
                        return true;

                    if (!this.Name.Equals(other.Name))
                        return false;

                    if (!this.Id.Equals(other.Id))
                        return false;

                    if (!this.Price.Equals(other.Price))
                        return false;

                    if (!this.Description.Equals(other.Description))
                        return false;

                    return true;
                }
                else
                    throw new ArgumentException($"argument was sent to the method is of type {obj.GetType().Name} instead of expected type {this.GetType().Name}");
            }
            else
                throw new NullReferenceException($"null reference was passed to the method");
        }

        public override int GetHashCode()
        {
            const int prime = 23;
            return this.Id.GetHashCode() * prime;
        }
    }
}
