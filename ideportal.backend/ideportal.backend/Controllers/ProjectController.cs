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

        Project[] _data = new[]
            {
                new Project() { Id =1, ProjectName = "ArrayElementDummy1", ProjectLink = "http://www.vg.no", ProjectCategory = "C#" },
                new Project() { Id = 2, ProjectName = "ArrayElementDummy2", ProjectLink = "http://www.vg.no", ProjectCategory = "JavaScript" }
            };




        //Let's get 'em CRUDz!

        [HttpGet("{id}")]
        public async Task<Project> GetOne(int id)
        {
            return await Task.Run(() =>
              _data.SingleOrDefault(p=>p.Id==id)
            );


        }


        [HttpGet]
        //public async Task<IEnumerable<Project>> GetMany()
        //{
        //    //return await Task.Run(() => _data);
        //   //return await _context.Projects.ToList<>;

        //}
        public ActionResult<IEnumerable<Project>> GetVask()
        {

            return _context.Projects.ToList();

        }



        [HttpPost]
        public async Task<int> Create(Project project)
        {
            return await Task.Run(() => 1);
        }


        [HttpPut]
        public async Task<int> Edit(Project project)
        {
            return await Task.Run(() => 1);
        }

        [HttpDelete]
        public async Task<int> Delete(int id)
        {
            return await Task.Run(() => 1);
        }

    }
}
