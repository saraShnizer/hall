using lesson3.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace lesson3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        private readonly DataContext _context;
        public EmployeesController(DataContext context)
        {
            _context = context;
        }



        // GET: api/<EmployeesController>
        [HttpGet]
        public List<Employee> Get()
        {
            return _context.Employees;
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _context.Employees.Find(x=>x.Id==id);
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public void Post([FromBody] Employee newEmp)
        {
            _context.Employees.Add(new Employee
            {
                Id = newEmp.Id,
                Name = newEmp.Name,
                PhoneNumber = newEmp.PhoneNumber
            });
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee e)
        {
            var pe = _context.Employees.Find(x => x.Id == id);
            pe.Name = e.Name;
            pe.PhoneNumber = e.PhoneNumber;
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var pe = _context.Employees.Find(x => x.Id == id);
            _context.Employees.Remove(pe);
        }
    }
}
