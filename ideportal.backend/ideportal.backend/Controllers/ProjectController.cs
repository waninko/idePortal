using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ideportal.backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ideportal.backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly ProjectDbContext _context;
        
        public ProjectController(ProjectDbContext context)
        {
            _context = context;
        }

        Project[] _dummyData = new[]
            {
                new Project() { Id =1, ProjectName = "ArrayElementDummy1", ProjectLink = "http://www.vg.no", ProjectCategory = "C#" },
                new Project() { Id = 2, ProjectName = "ArrayElementDummy2", ProjectLink = "http://www.vg.no", ProjectCategory = "JavaScript" }
            };




        //Let's get 'em CRUDz!

        [HttpGet("{id}")]  //trengs dette i det hele tatt? 
        public async Task<Project> GetOne(int id)
        {
            return await Task.Run(() =>
              _dummyData.SingleOrDefault(p=>p.Id==id)
            );


        }


        [HttpGet]
        public ActionResult<IEnumerable<Project>> GetAll()
        {

            return _context.Projects.ToList();

        }


        [HttpPost] //add project
        public async Task<Project> Create(Project project)
        {
            //return await Task.Run(() => "Funks!");
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();

            return project;
        }


            [HttpPut("{id}")] //edit project
        public async Task<ActionResult<Project>> Edit(int id, [FromBody] Project project)
        {
            //return await Task.Run(() => "Funks!");
            var projectExists = await _context.Projects.AnyAsync(p => p.Id == id);
            if (!projectExists)
            {
                Console.Beep();
                return NotFound();  //actionResult for å få brukt disse innebygde
            }

            _context.Projects.Update(project);
            await _context.SaveChangesAsync();
            return Ok(); //actionResult for å få brukt disse innebygde
        }



        [HttpDelete("{id}")] //remove project
        public async Task<ActionResult<Project>> Delete(long id)
        {
            var selectedProject = await _context.Projects.FindAsync(id);
            _context.Projects.Remove(selectedProject);
            await _context.SaveChangesAsync();

            return Ok();
           // return await Task.Run(() => "Funks!");
        }

    }
}
