using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace myProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Leaders : ControllerBase
    {
        private static List<Leader> leaders = new List<Leader> {new Leader(111,
    new Tour("paris","a big ","moyshy","fance",DateTime.Now,DateTime.Now,15),
    new List<Order>{new Order(1,"shlomo","jerusalem","505","@gmail"),new Order(4,"dan","ta","88","@gmail") }),
          new Leader(222,  new Tour("paris","a big ","moyshy","fance",DateTime.Now,DateTime.Now,16),
              new List<Order>
              { new Order(2,"JK","BB","505","@gmail") })
};
        // GET: api/<Leader>
        [HttpGet]
        public List<Leader> Get()
        {
            return leaders;
        }
        // GET api/<Leader>/5
        [HttpGet("{ld}")]
        public Leader Get(int ld)
        {
            return leaders.Find(x=>x.Ld==ld);
        }

        // POST api/<Leader>
        [HttpPost]
        public void Post(int id,[FromBody] Leader l)
        {
            leaders.Add(l);
        }

        // PUT api/<Leader>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] int value)
        {
           
                Order o = (Order)leaders.Select(x => x.GroupLeader.Where(y => y.Id == id));
                o.Id = value;
            

        }

        // DELETE api/<Leader>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Leader l = leaders.Find(x => x.Ld == id) ;
            leaders.Remove(l);
        }
    }
}
