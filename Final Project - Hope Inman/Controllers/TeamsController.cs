using Final_Project___Hope_Inman.Data;
using Final_Project___Hope_Inman.Module;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project___Hope_Inman.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly AppDbContext2 _appDbContext2;

        public TeamsController(AppDbContext2 appDbContext2)
        {
            _appDbContext2 = appDbContext2;
        }

        [HttpPost]
        public ActionResult<Teams> Create([FromBody] Teams teams)
        {
            _appDbContext2.Teams.Add(teams);
            _appDbContext2.SaveChanges();
            return Ok(teams);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Teams>> GetAll()
        {
            return _appDbContext2.Teams.ToList();
        }

        [HttpGet("{id:int}")]
        public ActionResult<Teams> GetById(int id)
        {
            var teams = _appDbContext2.Teams.Find(id);
            return Ok(teams);
        }

        [HttpPut("{id:int}")]
        public ActionResult<Teams> Update([FromBody] Teams teams)
        {
            _appDbContext2.Teams.Update(teams);
            _appDbContext2.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public ActionResult DeleteById(int id)
        {
            var teams = _appDbContext2.Teams.Find(id);

            if (teams == null)
            {
                return NotFound(new { Message = $"Player with id {id} not found." });
            }

            _appDbContext2.Teams.Remove(teams);
            _appDbContext2.SaveChanges();
            return Ok();
        }

    }
}


