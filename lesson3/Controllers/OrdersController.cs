using lesson3.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace lesson3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly DataContext _context;
        public OrdersController(DataContext context)
        {
            _context = context;
        }
        // GET: api/<OrdersController>
        [HttpGet]
        public List<Order> Get()
        {
            return _context.Orders;
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return _context.Orders.Find(x => x.Id == id); 
        }

        // POST api/<OrdersController>
        [HttpPost]
        public void Post([FromBody] Order newOrder)
        {
            _context.Orders.Add(new Order{
                Id = newOrder.Id,
                NameClient = newOrder.NameClient,
                Date = newOrder.Date,
                DosesCount = newOrder.DosesCount
            });
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Order o)
        {
            var po  = _context.Orders.Find(o => o.Id == id);
            po.NameClient = o.NameClient;
            po.Date = o.Date;
            po.DosesCount = o.DosesCount;
           
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var o = _context.Orders.Find(x => x.Id == id);
            _context.Orders.Remove(o);
        }
    }
}
