using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Controllers
{
    [Authorize(AuthenticationSchemes = "Identity.Application", Policy = "IsAdmin")]
    public class AdminController : Controller
    {
        private readonly WebApplication2Context _context;
        private readonly UserManager<WebApplication2User> _userManager;

        public AdminController(WebApplication2Context context, UserManager<WebApplication2User> userManager)
        {
            _context = context;
            _userManager = userManager;

        }


        // GET: Admin
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.Select(user => 
                new AdminViewModel
                {
                    Email = user.Email,
                    IsAdmin = user.IsAdmin,
                    RecipeAntRole = user.RecipeAntRole,

                }).ToListAsync());
        }

        // GET: Admin/Details/5
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await _context.Users
                    .FirstOrDefaultAsync(m => m.Email == id);
            if (user == null) 
            {
                return NotFound();
            }
            return View(new AdminViewModel
            {
                Email = user.Email,
                IsAdmin = user.IsAdmin,
                RecipeAntRole = user.RecipeAntRole
            });
        }

        // GET: Admin/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }            

        // POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Email, IsAdmin, RecipeAntRole")] AdminViewModel adminViewModel)
        {
            if (ModelState.IsValid)
            {
                await _userManager.CreateAsync(new WebApplication2User
                {
                    Email = adminViewModel.Email,
                    IsAdmin = adminViewModel.IsAdmin,
                    RecipeAntRole = adminViewModel.RecipeAntRole,
                    UserName = adminViewModel.Email
                });
                return RedirectToAction(nameof(Index));
            }
            return View(adminViewModel);

        }

        // GET: Admin/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await _userManager.FindByEmailAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(new AdminViewModel
            {
                Email = user.Email,
                IsAdmin = user.IsAdmin,
                RecipeAntRole = user.RecipeAntRole
            });
        }

        // POST: Admin/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Email,IsAdmin,RecipeAntRole")] AdminViewModel adminViewModel)
        {
            // Have to figure out why the id is same as the Email for admin or maybe even for all users
            if (id != adminViewModel.Email)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var user = await _userManager.FindByEmailAsync(id);
                    user.IsAdmin = adminViewModel.IsAdmin;
                    user.RecipeAntRole = adminViewModel.RecipeAntRole;
                    await _userManager.UpdateAsync(user);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdminViewModelExists(adminViewModel.Email))
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
            return View(adminViewModel);

        }

        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await _userManager.FindByEmailAsync(id);

            if (user == null)
            {
                return NotFound();
            }
            return View(new AdminViewModel
            {
                Email = user.Email,
                IsAdmin = user.IsAdmin,
                RecipeAntRole = user.RecipeAntRole
            });
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await _userManager.FindByEmailAsync(id);
            await _userManager.DeleteAsync(user);
            return RedirectToAction(nameof(Index));
        }
        private bool AdminViewModelExists(string id)
        {
            return _context.Users.Any(e => e.Email == id);
        }
    }
}