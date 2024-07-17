using Lab03.Models;
using Microsoft.AspNetCore.Mvc;
using ReadDB.Data;
using ReadDB.Models;
using System.Collections.Generic;

namespace Lab03.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataAccess _dataAccess;

        public HomeController(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public IActionResult Index()
        {
            List<YourModel> data = _dataAccess.GetData();
            return View(data);
        }
    }
}
