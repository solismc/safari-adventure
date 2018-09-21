using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using orm_safari.Models;

namespace safari_adventure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        public object LastSeenAt { get; private set; }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<SeenAnimals>> Get()
        {
            var db = new SafariAdventureContext();
            
            return db.SeenAnimals;
        }
        
        [HttpPost]
        public ActionResult<SeenAnimals> Post ([FromBody] string species)
        {
            var animal = new SeenAnimals {
                Species = species,
                LocationOfLastSeen = "outside",
        };
            var db = new SafariAdventureContext();

            db.SeenAnimals.Add(animal);

            db.SaveChanges();

            return animal;

    }

}

}
