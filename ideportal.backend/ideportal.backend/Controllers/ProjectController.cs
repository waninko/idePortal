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

        [HttpGet("{id}")]
        public async Task<Project> GetOne(int id)
        {
            return await Task.Run(() =>
              _dummyData.SingleOrDefault(p=>p.Id==id)
            );


        }


        [HttpGet]
        //public async Task<IEnumerable<Project>> GetMany()
        //{
        //    //return await Task.Run(() => _data);
        //   //return await _context.Projects.ToList<>;

        //}
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


        [HttpPut] //edit project
        public async Task<string> Edit(Project project)
        {
            return await Task.Run(() => "Funks!");
        }

        [HttpDelete] //remove project
        public async Task<string> Delete(int id)
        {
            return await Task.Run(() => "Funks!");
        }

    }
}
