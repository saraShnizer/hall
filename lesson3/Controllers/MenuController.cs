using lesson3.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace lesson3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {

        private readonly DataContext _context;
        public MenuController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<MenuController>
        [HttpGet]
        public List<Dose> Get()
        {
            return _context.Doses;
        }

        // GET api/<MenuController>/5
        [HttpGet("{id}")]
        public Dose Get(int id)
        {
            return _context.Doses.Find(x=>x.Id==id);
        }

        // POST api/<MenuController>
        [HttpPost]
        public void Post([FromBody] Dose newD)
        {
            _context.Doses.Add(new Dose
            {
                Id=newD.Id,
                Name=newD.Name,
                Price=newD.Price,
            });
        }

        // PUT api/<MenuController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Dose d)
        {
            var pd= _context.Doses.Find(x=>x.Id==id);
            pd.Name=d.Name;
            pd.Price=d.Price;
        }

        // DELETE api/<MenuController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var d= _context.Doses.Find(x=>x.Id==id);
            _context.Doses.Remove(d);

        }
    }
}
