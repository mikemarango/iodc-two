using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WEB.Models;
using WEB.Services;

namespace WEB.Controllers
{
    public class PhotosController : Controller
    {
        private readonly ILogger<PhotosController> _logger;

        public PhotoService Service { get; }

        public PhotosController(ILogger<PhotosController> logger, PhotoService service)
        {
            _logger = logger;
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var photos = await Service.GetPhotosAsync();
            var photoViewModel = new PhotoViewModel()
            {
                Photos = photos
            };
            return View(photoViewModel);
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
    }
}