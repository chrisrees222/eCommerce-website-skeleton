using eCommerce_website_skeleton.Data;
using eCommerce_website_skeleton.Data.Services;
using eCommerce_website_skeleton.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eCommerce_website_skeleton.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersServices _services;

        public ProducersController(IProducersServices services)
        {
            _services = services;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _services.GetAllAsync();
            return View(allProducers);
        }

        //Get: Producers/details/1
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _services.GetByIdAsync(id);
            if(producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        //Get: producers/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Bio")] Producer producer)
        {
            ModelState.Remove("Movies");
            if (!ModelState.IsValid) return View(producer);

            await _services.AddAsync(producer);
            return RedirectToAction(nameof(Index));                        
        }

        //Get: producers/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var producersDetails = await _services.GetByIdAsync(id);
            if (producersDetails == null) return View("NotFound");
            return View(producersDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProfilePictureURL,FullName,Bio")] Producer producer)
        {
            ModelState.Remove("Movies");
            if (!ModelState.IsValid) return View(producer);

            if(id == producer.Id)
            {
                await _services.UpdateAsync(id, producer);
                return RedirectToAction(nameof(Index));
            }

            return View(producer);
        }

        //Get: producers/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var producersDetails = await _services.GetByIdAsync(id);
            if (producersDetails == null) return View("NotFound");
            return View(producersDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producersDetails = await _services.GetByIdAsync(id);
            if (producersDetails == null) return View("NotFound");

            await _services.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
