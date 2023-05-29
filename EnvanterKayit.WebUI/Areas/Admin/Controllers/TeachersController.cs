using EnvanterKayit.Entities;
using EnvanterKayit.Service.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EnvanterKayit.WebUI.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize]
    public class TeachersController : Controller
    {
        private readonly IService<Ogretmen> _service;
        private readonly IService<Cihaz> _serviceCihaz;


        public TeachersController(IService<Ogretmen> service, IService<Cihaz> serviceCihaz)
        {
            _service = service;
            _serviceCihaz = serviceCihaz;
        }

        // GET: TeachersController
        public async Task<ActionResult> IndexAsync()
        {
            ViewBag.CihazId = new SelectList(await _serviceCihaz.GetAllAsync(), "Id", "Modeli");
            var model = await _service.GetAllAsync();
            return View(model);
        }

        // GET: TeachersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TeachersController/Create
        public async Task<ActionResult> CreateAsync()
        {
            ViewBag.CihazId = new SelectList(await _serviceCihaz.GetAllAsync(), "Id", "Modeli");
            return View();
        }

        // POST: TeachersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(Ogretmen ogretmen)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _service.AddAsync(ogretmen);
                    await _service.SaveAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }
            ViewBag.CihazId = new SelectList(await _serviceCihaz.GetAllAsync(), "Id", "Modeli");
            return View(ogretmen);
        }

        // GET: TeachersController/Edit/5
        public async Task<ActionResult> EditAsync(int id)
        {
            ViewBag.CihazId = new SelectList(await _serviceCihaz.GetAllAsync(), "Id", "Modeli");
            var model = await _service.FindAsync(id);
            return View(model);
        }

        // POST: TeachersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(Ogretmen ogretmen)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _service.Update(ogretmen);
                    await _service.SaveAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }
            ViewBag.CihazId = new SelectList(await _serviceCihaz.GetAllAsync(), "Id", "Modeli");
            return View(ogretmen);
        }

        // GET: TeachersController/Delete/5
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var model = await _service.FindAsync(id);
            return View(model);
        }

        // POST: TeachersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Ogretmen ogretmen)
        {
            try
            {
                _service.Delete(ogretmen);
                _service.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
