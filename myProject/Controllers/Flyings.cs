//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;
//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
//namespace myProject.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class Flyings : ControllerBase
//    {
//       private static List<Order> orders = new List<Order> {
//            (new Order(1,"shlomo","jerusalem","505","@gmail",new Tour("paris","a big ","moyshy","fance",DateTime.Now,DateTime.Now,15))),
//            (new Order(2,"JK","BB","505","@gmail",new Tour("paris","a big ","moyshy","fance",DateTime.Now,DateTime.Now,16)))
//        };
//      private static  List<Order> sortyByLand = new List<Order>();

//        // GET: api/<ValuesController>
//        [HttpGet]
//        public IEnumerable<Order> Get()
//        {
//            return orders;
//        }

//        // GET api/<ValuesController>/5
//        [HttpGet("{id}")]
//        public Order Get(int id)
//        {
//            return orders.Find(x => x.Id == id);
//        }

//        // POST api/<ValuesController>
//        [HttpPost]
//        public void Post([FromBody] Order newOrder)
//        {
//            orders.Add(newOrder);
//        }
//        // PUT api/<ValuesController>/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string updateNameOfTour)
//        {
//            Order o= orders.Find(x => x.Id == id);
//            o.Tour.TName = updateNameOfTour;
//            int x = 5;
//        }

//        // DELETE api/<ValuesController>/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//            orders.Remove(orders.Find(x => x.Id == id));
//        }
//        [HttpGet("SortTourByName/{tourName}")]
//        //הוספת טיול לאדם
//        //סינון לפי טיסה לאיזור מצסויים
//        public List<Order> Get(string tourName)
//        {

//            sortyByLand= orders.Where(x => x.Tour.TName == tourName).ToList();
           
//            return sortyByLand;

//        }
//    }
//}
