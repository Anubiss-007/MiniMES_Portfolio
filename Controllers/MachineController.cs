using Microsoft.AspNetCore.Mvc;
using MiniMES_Portfolio.Data;
using MiniMES_Portfolio.Models;
using System;
using System.Linq;

namespace MiniMES_Portfolio.Controllers
{
    public class MachineController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MachineController(ApplicationDbContext context)
        {
            _context = context;
        }

        // หน้า Index แสดงสถานะเครื่องจักรทั้งหมด
        public IActionResult Index()
        {
            var machines = _context.MachineStatuses.ToList();

            // ถ้ายังไม่มีเครื่องจักรในระบบ ให้สร้างข้อมูลจำลองขึ้นมา (Seed Data)
            if (!machines.Any())
            {
                _context.MachineStatuses.AddRange(
                    new MachineStatus { MachineName = "SMT Line 1 (เครื่องวางอุปกรณ์)", CurrentStatus = "Running", LastUpdated = DateTime.Now },
                    new MachineStatus { MachineName = "SMT Line 2 (เครื่องวางอุปกรณ์)", CurrentStatus = "Idle", LastUpdated = DateTime.Now },
                    new MachineStatus { MachineName = "Wave Soldering (เครื่องบัดกรี)", CurrentStatus = "Down", LastUpdated = DateTime.Now }
                );
                _context.SaveChanges();
                machines = _context.MachineStatuses.ToList();
            }

            return View(machines);
        }

        // ฟังก์ชันสำหรับกดเปลี่ยนสถานะเครื่องจักร
        [HttpPost]
        public IActionResult UpdateStatus(int id, string newStatus)
        {
            var machine = _context.MachineStatuses.Find(id);
            if (machine != null)
            {
                machine.CurrentStatus = newStatus;
                machine.LastUpdated = DateTime.Now;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}