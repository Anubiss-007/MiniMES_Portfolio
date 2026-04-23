using Microsoft.AspNetCore.Mvc;
using MiniMES_Portfolio.Data;
using MiniMES_Portfolio.Models;
using System.Linq;

namespace MiniMES_Portfolio.Controllers
{
    public class ProductionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Action: ดึงข้อมูลมาโชว์ที่ Dashboard + คำนวณสถิติ
        public IActionResult Index()
        {
            var data = _context.ProductionDatas.OrderByDescending(p => p.ProductionDate).ToList();

            int totalTarget = data.Sum(s => s.TargetQty);
            int totalActual = data.Sum(s => s.ActualQty);
            int totalDefect = data.Sum(s => s.DefectQty);
            
            double yieldRate = totalActual > 0 
                ? ((double)(totalActual - totalDefect) / totalActual) * 100 
                : 0;

            ViewBag.TotalTarget = totalTarget;
            ViewBag.TotalActual = totalActual;
            ViewBag.TotalDefect = totalDefect;
            ViewBag.YieldRate = yieldRate.ToString("F2");

            return View(data);
        }

        // Action: แสดงหน้าฟอร์มกรอกข้อมูล (ตัวนี้แหละที่หายไปจนติด 404)
        public IActionResult Create()
        {
            return View();
        }

        // Action: รับข้อมูลจากฟอร์มมาบันทึกลง Database
        [HttpPost]
        public IActionResult Create(ProductionData model)
        {
            if (ModelState.IsValid)
            {
                _context.ProductionDatas.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}