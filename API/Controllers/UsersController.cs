using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ChatApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;

        }
        [HttpGet]
        public async Task <ActionResult <IEnumerable<AppUser>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
           
        }
        [HttpGet("{id}")]
        public async Task <ActionResult<AppUser>> GetUser(int id)
        {
             return await _context.Users.FindAsync(id);
          
        }
    }
}
