using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>>  GetUsers() // Zamiast IEn można użyć List<> ale ma 
                                                            //ona za dużo niepotrzebnych metod jak tylko na wyświetlenie listy. Więc IEn<> wystarczy
        {
            return await _context.Users.ToListAsync();
        }
        // api/users/3
        [HttpGet("{id}")] // oznacza to, że jeśli w ścieżce zapytania będzie jakieś id, to zostanie użyta metoda GetUser a nie GetUsers
        public async Task<ActionResult<AppUser>>  GetUser(int id) 
        {
            return await _context.Users.FindAsync(id);           
        }
    }
}