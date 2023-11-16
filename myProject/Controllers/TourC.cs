using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace myProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourC : ControllerBase
    {
        private static List<Tour> tours = new List<Tour> { new Tour("Australian", "a nice place", "Australia", "benz",DateTime.Now, DateTime.Now, 11) };

        // GET: api/<TourC>
        [HttpGet]
        public IEnumerable<Tour> Get()
        {
            return tours;
        }

        // GET api/<TourC>/5
        [HttpGet("{code}")]
        public Tour Get(int code)
        {
            return tours.Find(x => x.Code == code);
        }

        // POST api/<TourC>
        [HttpPost]
        public void Post([FromBody] Tour newT)
        {
            tours.Add(newT);
        }

        // PUT api/<TourC>/5
        [HttpPut("{code}")]
        public void Put(int code, [FromBody] string value)
        {
            var t = (Tour)tours.Find(x => x.Code == code);
            t.Land=value;
        }

        // DELETE api/<TourC>/5
        [HttpDelete("{code}")]
        public void Delete(int code)
        {
            tours.Remove(tours.Find(x=>x.Code==code));
        }
    }
}
