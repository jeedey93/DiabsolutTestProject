using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using DiabsolutTestProject.ViewModels;
using System.Diagnostics;

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

            return processList.Select(p => new ProcessInfoViewModel() { Name = p.ProcessName });
        }
    }
}
