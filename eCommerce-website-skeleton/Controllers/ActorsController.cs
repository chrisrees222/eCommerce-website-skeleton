using eCommerce_website_skeleton.Data;
using eCommerce_website_skeleton.Data.Services;
using eCommerce_website_skeleton.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace eCommerce_website_skeleton.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();

            return View(data);
        }

        //Get: Actors/create.
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Actors actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        //Get Actors/Details/id=1
        public async Task<IActionResult> Details(int id)
        {
            var actordetails = await _service.GetByIdAsync(id);

            if(actordetails == null) return View("NotFound");
            return View(actordetails);
        }

        //Get: Actors/Edit.
        public async Task<IActionResult> Edit(int id)
        {
            var actordetails = await _service.GetByIdAsync(id);

            if (actordetails == null) return View("NotFound");
            return View(actordetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, FullName,ProfilePictureURL,Bio")] Actors actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }

        //Get: Actors/Delete.
        public async Task<IActionResult> Delete(int id)
        {
            var actordetails = await _service.GetByIdAsync(id);

            if (actordetails == null) return View("NotFound");
            return View(actordetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actordetails = await _service.GetByIdAsync(id);
            if (actordetails == null) return View("NotFound");
            await _service.DeleteAsync(id);
            
            return RedirectToAction(nameof(Index));
        }

    }
}
