using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Students_List.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Students_List.Controllers
{
    public class HomeController : Controller

    {
        StudentRepository repository = new StudentRepository();
        List<Student> model;
        public int idd;
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            model = repository.select();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {

            repository.insert(student);
            return RedirectToAction("Index");
        }


        public IActionResult Delete(Student student)
        {

            repository.delete(student);
            return RedirectToAction("Index");
        }

        public IActionResult Update(Student student)
        {
            return View(student);
           
        }

        public IActionResult Update2(Student student)
        {

            repository.update(student);

            return RedirectToAction("Index");
        }
    }
}
