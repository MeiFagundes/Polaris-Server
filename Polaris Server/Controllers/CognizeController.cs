using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Polaris_Server.Controllers
{
    [Route("Cognize")]
public class CognizeController : Controller {
        // GET: Cognize/
        [HttpGet]
        public string Get() {
            return "Query empty.";
        }

        // GET Cognize/Do this
        [HttpGet("{query}")]
        public async Task<string> Get(String query) {

            String filename = Path.Combine(Environment.CurrentDirectory + @"\PolarisBinaries\", "POLARIS.exe");
            Process process = new Process();
            
            process.StartInfo.FileName = filename;
            process.StartInfo.Arguments = query;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();

            string output = await process.StandardOutput.ReadToEndAsync();
            process.WaitForExit();
            return output;
        }

        // POST Cognize
        [HttpPost]
        public void Post([FromBody]string query) {
            
        }
    }
}
