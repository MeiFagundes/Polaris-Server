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
            return "Query is empty.";
        }

        // GET Cognize/Do this
        [HttpGet("{query}")]
        public async Task<string> Get(String query) {

            // Getting first .exe file from /PolarisCoreBinary/
            DirectoryInfo directoryInfo = new DirectoryInfo(Environment.CurrentDirectory + @"\PolarisCoreBinary\");

            String filename = directoryInfo.ToString() + directoryInfo.GetFiles()
              .Select(t => t.Name)
              .FirstOrDefault(name => name.EndsWith(".exe"));

            // Executing process
            Process process = new Process();
            
            process.StartInfo.FileName = filename;
            process.StartInfo.Arguments = query;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();

            String output = await process.StandardOutput.ReadToEndAsync();
            process.WaitForExit();
            return output;
        }

        // POST Cognize
        [HttpPost]
        public void Post([FromBody]string query) {
            
        }
    }
}
