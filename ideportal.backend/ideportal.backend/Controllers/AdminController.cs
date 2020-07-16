using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ideportal.backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ideportal.backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly AdminDbContext _context;

        public AdminController(AdminDbContext context)
        {
            _context = context;
        }



        [HttpGet]
    public ActionResult<IEnumerable<Admin>> GetAll()
    {
        return _context.Administrators.ToList();
    }


    [HttpPost]
    public async Task<Admin> Create(Admin Administrator)
    {
        _context.Administrators.Add(Administrator);
        await _context.SaveChangesAsync();
        return Administrator;
    }


        [HttpDelete("{id}")]
        public async Task<ActionResult<Admin>> Delete(long id)
        {
            var selectedAdmin = await _context.Administrators.FindAsync(id);
            _context.Administrators.Remove(selectedAdmin);
            await _context.SaveChangesAsync();

            return Ok();
        }


    }



}
