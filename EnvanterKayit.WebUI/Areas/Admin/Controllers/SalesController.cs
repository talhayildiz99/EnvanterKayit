using EnvanterKayit.Entities;
using EnvanterKayit.Service.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EnvanterKayit.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SalesController : Controller
    {
        private readonly IService<Satis> _service;
        private readonly IService<Cihaz> _serviceCihaz;
        public SalesController(IService<Satis> service, IService<Cihaz> serviceCihaz)
        {
            _service = service;
            _serviceCihaz = serviceCihaz;
        }

        // GET: SalesController
        public async Task<ActionResult> IndexAsync()
        {
            ViewBag.CihazId = new SelectList(await _serviceCihaz.GetAllAsync(), "Id", "Modeli");
            var model = await _service.GetAllAsync();
            return View(model);
        }

        // GET: SalesController/Details/5
        public async Task<ActionResult> DetailsAsync(int id)
        {
            var model = await _service.GetAllAsync();
            return View(model);
        }

        // GET: SalesController/Create
        public async Task<ActionResult> CreateAsync()
        {
            ViewBag.CihazId = new SelectList(await _serviceCihaz.GetAllAsync(), "Id", "Modeli");
            return View();
        }

        // POST: SalesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(Satis satis)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _service.AddAsync(satis);
                    await _service.SaveAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }
            ViewBag.CihazId = new SelectList(await _serviceCihaz.GetAllAsync(), "Id", "Modeli");
            return View(satis);
        }

        // GET: SalesController/Edit/5
        public async Task<ActionResult> EditAsync(int id)
        {
            ViewBag.CihazId = new SelectList(await _serviceCihaz.GetAllAsync(), "Id", "Modeli");
            var model = await _service.FindAsync(id);
            return View(model);
        }

        // POST: SalesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(int id, Satis satis)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _service.Update(satis);
                    await _service.SaveAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }
            ViewBag.CihazId = new SelectList(await _serviceCihaz.GetAllAsync(), "Id", "Modeli");
            return View(satis);
        }

        // GET: SalesController/Delete/5
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var model = await _service.FindAsync(id);
            return View(model);
        }

        // POST: SalesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Satis satis)
        {
            try
            {
                _service.Delete(satis);
                _service.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
