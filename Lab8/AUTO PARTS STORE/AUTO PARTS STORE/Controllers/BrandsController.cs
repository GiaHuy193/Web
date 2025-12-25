using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AUTO_PARTS_STORE.Data;
using AUTO_PARTS_STORE.Models;
using AUTO_PARTS_STORE.Services.Interface;

namespace AUTO_PARTS_STORE.Controllers
{
    public class BrandsController : Controller
    {
        private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        // GET: Brands
        public IActionResult Index()
        {
            var brands = _brandService.GetAllBrands();
            return View(brands);
        }

        // GET: Brands/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Brands/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Brand brand)
        { 
            if (!ModelState.IsValid)
            return View(brand);
            _brandService.CreateBrand(brand);
            return RedirectToAction(nameof(Index));
        }

        // GET: Brands/Edit/5
        public IActionResult Edit(int id)
        {
            var brand = _brandService.GetBrandById(id);
            if(brand == null) return NotFound();
            return View(brand);

        }

        // POST: Brands/Edit/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Brand brand)
        {
            if (!ModelState.IsValid)
            return View(brand);
            _brandService.UpdateBrand(brand);
            return RedirectToAction(nameof(Index));
        }

        // GET: Brands/Delete/5
        public IActionResult Delete(int id)
        {
            _brandService.DeleteBrand(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
