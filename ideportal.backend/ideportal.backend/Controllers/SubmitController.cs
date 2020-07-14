using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ideportal.backend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ideportal.backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[EnableCors("AllowOrigin")]
    public class SubmitController : ControllerBase
    {
        private readonly SubmitDbContext _context;

        public SubmitController(SubmitDbContext context)
        {
            _context = context;
        }

        //Add Submission
        [HttpPost] 
        public async Task<Submit> Create(Submit submission)
        {
            _context.SubmittedProjects.Add(submission);
            await _context.SaveChangesAsync();
            //Response.Headers[""] = submission;
            return submission;
        }


        //Get All
        [HttpGet]
        public ActionResult<IEnumerable<Submit>> GetAll()
        {
            return _context.SubmittedProjects.ToList();
        }

        //Delete Specific
        [HttpDelete("{id}")] 
        public async Task<ActionResult<Submit>> Delete(long id)
        {
            var selectedProject = await _context.SubmittedProjects.FindAsync(id);
            _context.SubmittedProjects.Remove(selectedProject);
            await _context.SaveChangesAsync();

            return Ok();
        }


        //evt Updates gjøres etter alt er hentet, en er selected - evt oppdatering før push i Projects table
        //ingen endringer i submittable, bare slette de som er tullball



    }
}
