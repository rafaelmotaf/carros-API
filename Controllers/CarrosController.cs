using Carros.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Carros.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class CarrosController : ControllerBase
    {
        private static List<Carro> Carros = new List<Carro>()
        {
            new Carro(1,"Mustang", 2010, "Blue"), 
            new Carro(2, "UP TSI", 2019, "White"), 
            new Carro(3, "Uno com escada", 2009, "Red")
        };
       

        [HttpGet(Name = "GetCarro")]
        public List<Carro> Get()
        {
            return Carros;
            
        }

        [HttpPost(Name = "PostCarro")]

        public void Post([FromBody ]Carro carro)
        {
            Carros.Add(carro);
        }

        [HttpDelete("{id}", Name = "DeleteCarro")]

        public void Delete([FromRoute] int id)
        {

            var carroParaRemover = Carros.First(carro => carro.Id == id );
            Carros.Remove(carroParaRemover);
        }

    }
}
