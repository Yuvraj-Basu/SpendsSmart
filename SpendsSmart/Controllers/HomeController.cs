using Microsoft.AspNetCore.Mvc;
using SpendsSmart.Models;
using System.Diagnostics;

namespace SpendsSmart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SpendsSmartDbContext _context;

        public HomeController(ILogger<HomeController> logger, SpendsSmartDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Expenses()
        {
            var allexpenses = _context.Expenses.ToList();  
            var totalExpenses = allexpenses.Sum(e => e.Value);
            ViewBag.TotalExpenses = totalExpenses;
            return View(allexpenses);
        }

        public IActionResult CreateEditExpense(int? id)
        {
            if(id == null)
            {
                var expense = _context.Expenses.Find(id);
                return View(expense);
            }
            return View();
        }

        public IActionResult DeleteExpense(int id)
        {
            var expense = _context.Expenses.Find(id);
            if (expense != null)
            {
                _context.Expenses.Remove(expense);
                _context.SaveChanges();
            }
            return RedirectToAction("Expenses");
        }

        public IActionResult CreateEditExpenseForm( Expense model)
        {
            if (model.Id ==0)
            {
                _context.Expenses.Add(model);
                _context.SaveChanges();
            }
           _context.Update(model);
            _context.SaveChanges();
            return RedirectToAction("Expenses");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
