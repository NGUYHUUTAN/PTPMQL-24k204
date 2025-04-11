using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DemoMvc.Models;
using DemoMVC.Data;

namespace DemoMvc.Controllers
{
    public class PersonController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PersonController(ApplicationDbContext context)
        public async Task<IActionResult> Index()
        Public IActionResult Create()
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Blind("PersonId,Fullname,Address")] Person person)
        public async Task<IActionResult> Edit(string id);
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Blind("PersonId,Fullname,Address")] Person person)
        public async Task<IActionResult> Delete(string id)
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        private bool PersonExists(string id)
    }
}