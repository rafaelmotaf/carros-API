using Microsoft.Extensions.Primitives;

namespace Carros.API.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Carro(int id, string model, int year, string color)
        {
            Id = id;
            Model = model;
            Year = year;
            Color = color;
        }

        public Carro()
        {
            
        }

    }
}
