using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KnowledgeBase
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Console.WriteLine("Yolo message when calling values controller because this is a yolo super app for cool kids.");
            return new string[] { "Pepsi", "Cat", "Random", "Value", "Another value for testing purpose (and because yolo)"};
        }
    }
}
