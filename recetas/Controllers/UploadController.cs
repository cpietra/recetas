using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LinqToExcel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using recetas.Models;

namespace recetas.Controllers
{
    public class UploadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Import()
        {
            //get the selected radio value
            string worksheet = "worksheet 1";

            //initialize list
            IEnumerable list = new ArrayList();
            //Get Server Path of Excel file
            string fileSrc = Path.GetTempFileName(); //Server.MapPath("~/Content/Files/ExcelFile.xlsx");
                                                     //Build Result
                                                     //call the second Method
            list = Method2(fileSrc, worksheet);


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

            return Ok(new { count = files.Count, size, filePath });
        }

        public IEnumerable Method2(string fileSrc, string worksheet)
        {   //Reading excel data using LinqToExcel
            var excelData = new ExcelQueryFactory(fileSrc);
            //Get data from specified worksheet
            var query = excelData.Worksheet(worksheet);
            int cp = 0;
            //intialize the result list
            var list = new ArrayList();
            foreach (var line in query)
            {
                try
                {
                    Padron Padron1 = new Padron
                    {
                        Id_Padron = Convert.ToInt32(line[0].ToString()),//surname
                        Plan = line[1].ToString(),//name
                        Categoria = line[2].ToString()//date
                    };
                    list.Add(Padron1);
                }
                catch (Exception exception)
                {

                }
            }
            return list;
        }
    }
}