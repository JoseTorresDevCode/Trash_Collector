using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using Trash_Colllector.Data;
using Trash_Colllector.Models;

namespace Trash_Colllector.Controllers

{
    
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        

        

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            var userId = this.User.FindFirstValue(System.Security.Claims.ClaimTypes.NameIdentifier);
            var employee = _context.Employees.Where(p => p.IdentityUserId == userId).SingleOrDefault();

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        public IActionResult Index()
        {
            var userId = this.User.FindFirstValue(System.Security.Claims.ClaimTypes.NameIdentifier);
            var employeeLoggedIn = _context.Employees.Where(c => c.IdentityUserId == userId).SingleOrDefault();

            if (employeeLoggedIn == null)
            {
                return RedirectToAction("Create");
            }
           
            else
            {
                var customers = _context.Customers.Where(e => e.IdentityUserId == userId).SingleOrDefault();
                var customersInZipCode = _context.Customers.Where(c => c.ZipCode == employeeLoggedIn.ZipCode).ToList();
                var today = DateTime.Now.DayOfWeek;
                var customersInZipAndToday = customersInZipCode.Where(c => c.PickUpDay == today).ToList();

                return View(customersInZipAndToday);
            }



        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                employee.IdentityUserId = userId;
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeId,FirstName,LastName,ZipCode,IdentityUserId")] Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.EmployeeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .Include(e => e.IdentityUser)
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> CustomerOverview(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
            return View(customer);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CustomerOverview(int id, [Bind("CustomerId,FirstName,LastName,Address,City,State,ZipCode,PickUpDay,Balance,OneTimePickuUp,isConfirmed,IdentityUserId,Lat,Long")] Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.CustomerId))
                    {
                        return NotFound();
                    }
                    if (customer.isConfirmed == true)
                    {
                        customer.Balance = 50;
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
            return View(customer);
        }
        public IActionResult CustomerList(string searchString)
        {
            var userId = this.User.FindFirstValue(System.Security.Claims.ClaimTypes.NameIdentifier);
            var employeeLoggedIn = _context.Employees.Where(c => c.IdentityUserId == userId).SingleOrDefault();

            if (employeeLoggedIn == null)
            {
                return RedirectToAction("Create");
            }
            else
            {
                var customers = _context.Customers.Where(e => e.IdentityUserId == userId).SingleOrDefault();
                var customersInZipCode = _context.Customers.Where(c => c.ZipCode == employeeLoggedIn.ZipCode).ToList();
                
                var customer = from s in _context.Customers
                             select s;

                if (!string.IsNullOrEmpty(searchString))
                {
                    customer = customer.Where(c => c.PickUpDay.Equals(searchString));

                }

                return View(customersInZipCode);
            }



        }
        public IActionResult CustomerDetails(int? id)
        {
            {
                var getCustomer = _context.Customers.Where(c => c.CustomerId == id).SingleOrDefault();
                return View(getCustomer);
            }
        }
        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeId == id);
        }
        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.CustomerId == id);
        }
    }
}
