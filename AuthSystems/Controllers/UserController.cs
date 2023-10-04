using AuthSystems.Data;
using AuthSystems.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;

namespace AuthSystems.Controllers
{
    [Authorize(Roles="Admin")]
    public class UserController : Controller
    {
        private readonly AuthDbContext _context;
        public UserController(AuthDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var ApplicationUsers = _context.ApplicationUsers.ToList();
			List<ApplicationUserViewModel> users = new List<ApplicationUserViewModel>();

			if (ApplicationUsers != null) {
             
                
                foreach (var User in ApplicationUsers)
                {
                    var ApplicationUserViewModel = new ApplicationUserViewModel()
                    {
                        FirstName= User.FirstName,
                        LastName= User.LastName,
                        UserId= User.UserId,
                        Email = User.Email,
                        PhoneNumber = User.PhoneNumber,
                        Gender= User.Gender,
                        MaritalStatus= User.MaritalStatus
                    };
					users.Add(ApplicationUserViewModel);

				}
				return View(users);

			}

            return View(users);
        }
    }
}
