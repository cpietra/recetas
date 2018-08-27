using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using recetas.Clases;

namespace recetas.Controllers
{
    public class UploadController : Controller
    {
        private static string path_file;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Import()
        {

            //initialize list
            IEnumerable list = new ArrayList();
            ImportarPadron ClsPadron = new ImportarPadron();
            list = ClsPadron.List_Padron(path_file);


            //return list as Enumerable to our model
            return View(list);

            //return View();
        }

        [HttpPost("Upload")]
        public async Task<IActionResult> Post(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            // full path to file in temp location
            var filePath = Path.GetTempFileName();

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.
            path_file = filePath;
            ImportarPadron ClsPadron = new ImportarPadron();
            int importados = ClsPadron.Import_Padron(path_file);
            return Ok(new { count = importados});
        }        
    }
}