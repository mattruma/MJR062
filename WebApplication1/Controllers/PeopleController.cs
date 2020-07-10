using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly WideWorldImportersDbContext _dbContext;

        public PeopleController(
            WideWorldImportersDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<PeopleData> Get()
        {
            return _dbContext.People.Take(10).ToList();
        }
    }
}
