using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VBAPproj.Data;
using VBAPproj.Data.Services;
using VBAPproj.Data.Static;
using VBAPproj.Models;

namespace VBAPproj.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class ActorsController : Controller
    {

        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allActors = await _service.GetAllAsync();
            return View(allActors);
        }

        //get: actors/create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,Bio")]Actor actor)
        {
            if(!ModelState.IsValid) 
            {
                return View(actor);    
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        //get: actors/details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if(actorDetails == null) 
            {
                return View("NotFound");
            }
            return View(actorDetails);
        }

        //get: actors/edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null)
            {
                return View("NotFound");
            }
            return View(actorDetails);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }

        //get: actors/delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null)
            {
                return View("NotFound");
            }
            return View(actorDetails);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
