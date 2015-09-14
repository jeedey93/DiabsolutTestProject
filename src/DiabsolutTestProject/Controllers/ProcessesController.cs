using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using DiabsolutTestProject.ViewModels;
using System.Diagnostics;
using DiabsolutTestProject.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DiabsolutTestProject.Controllers
{
    [Route("api/[controller]")]
    public class ProcessesController : Controller
    {
        [HttpGet]
        public IEnumerable<ProcessInfoViewModel> Get()
        {
            var processList = Process.GetProcesses().OrderBy(p => p.ProcessName).ToList();

            return processList.Select(p => new ProcessInfoViewModel() { Name = p.ProcessName});
        }

        // GET api/values/7
        [HttpGet("{id}")]
        public ProcessInfoViewModel Get(int id)
        {
            var processList = Process.GetProcesses().OrderBy(p => p.ProcessName).ToList();
            return processList.Select(p => new ProcessInfoViewModel() { Name = p.ProcessName }).First();
        }

        [HttpGet]
        public List<string> Get2()
        {
            var a  = new List<string>() { "HELOO", "ABYEBYE"};
            return a;
        }


        [Route("/api/people")]
        public JsonResult GetPeople()
        {
            var people = new List<Person>()
            {
                new Person { Id = 1, FirstName = "John", LastName = "Doe" },
                new Person { Id = 1, FirstName = "Mary", LastName = "Jane" },
                new Person { Id = 1, FirstName = "Bob", LastName = "Parker" }
            };

            return Json(people);
        }
    }
}
