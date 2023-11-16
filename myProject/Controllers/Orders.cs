using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace myProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController1 : ControllerBase
    {
        private static List<Order> orders = new List<Order> { new Order(1,"shimi","jerusalem","05041","@gmail"),
        new Order(2,"yoni","bb","05041","@gmail")};
        // GET: api/<ValuesController1>
        [HttpGet]
        public List<Order> Get()
        {
            return orders;
        }

        // GET api/<ValuesController1>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return orders.Find(x => x.Id == id);
        }

        // POST api/<ValuesController1>
        [HttpPost]
        public void Post([FromBody] Order newOrder)
        {
            orders.Add(newOrder);
        }

        // PUT api/<ValuesController1>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            var order = orders.Find(x => x.Id == id);
            order.Addrass = value;
        }

        // DELETE api/<ValuesController1>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            orders.Remove(orders.First(x => x.Id == id));
        }
        [HttpGet("ordersInTheSameCity/{city}")]
        public List<Order> Get(string city)
        {
        return orders.Where(x=>x.Addrass==city).ToList();
        }

    }
}
