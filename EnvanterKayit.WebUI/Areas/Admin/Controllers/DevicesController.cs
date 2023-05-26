using EnvanterKayit.Entities;
using EnvanterKayit.Service.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EnvanterKayit.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DevicesController : Controller
    {
        private readonly IService<Cihaz> _service;
        private readonly IService<Marka> _serviceMarka;
        private readonly IService<Tur> _serviceTur;

        public DevicesController(IService<Cihaz> service, IService<Marka> serviceMarka, IService<Tur> serviceTur)
        {
            _service = service;
            _serviceMarka = serviceMarka;
            _serviceTur = serviceTur;
        }

        // GET: DevicesController
        public async Task<ActionResult> IndexAsync()
        {
            var model = await _service.GetAllAsync();
            return View(model);
        }

        // GET: DevicesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DevicesController/Create
        public async Task<ActionResult> CreateAsync()
        {
            ViewBag.MarkaId = new SelectList(await _serviceMarka.GetAllAsync(), "Id", "Adi");
            ViewBag.TurId = new SelectList(await _serviceTur.GetAllAsync(), "Id", "Adi");
            return View();
        }

        // POST: DevicesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(Cihaz cihaz)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _service.AddAsync(cihaz);
                    await _service.SaveAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }
            ViewBag.MarkaId = new SelectList(await _serviceMarka.GetAllAsync(), "Id", "Adi");
            ViewBag.TurId = new SelectList(await _serviceTur.GetAllAsync(), "Id", "Adi");
            return View();
        }

        // GET: DevicesController/Edit/5
        public async Task<ActionResult> EditAsync(int id)
        {
            ViewBag.MarkaId = new SelectList(await _serviceMarka.GetAllAsync(), "Id", "Adi");
            ViewBag.TurId = new SelectList(await _serviceTur.GetAllAsync(), "Id", "Adi");
            var model = await _service.FindAsync(id);
            return View(model);
        }

        // POST: DevicesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(int id, Cihaz cihaz)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _service.Update(cihaz);
                    await _service.SaveAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }
            ViewBag.MarkaId = new SelectList(await _serviceMarka.GetAllAsync(), "Id", "Adi");
            ViewBag.TurId = new SelectList(await _serviceTur.GetAllAsync(), "Id", "Adi");
            return View();
        }

        // GET: DevicesController/Delete/5
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var model = await _service.FindAsync(id);
            return View(model);
        }

        // POST: DevicesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteAsync(int id, Cihaz cihaz)
        {
            try
            {
                _service.Delete(cihaz);
                await _service.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
