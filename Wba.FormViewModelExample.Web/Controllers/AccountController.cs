using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wba.FormViewModelExample.Web.ViewModels;

namespace Wba.FormViewModelExample.Web.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            //shows the form
            //make a form viewModel
            AccountLoginViewModel accountLoginViewModel = new AccountLoginViewModel();
            //set remember me
            accountLoginViewModel.RememberMe = true;
            return View(accountLoginViewModel);
        }

        [HttpPost]
        public IActionResult Login(AccountLoginViewModel accountLoginViewModel)
        {
            //gets the form data
            // check the modelstate (voor je errormessages)
            if (!ModelState.IsValid)
            {
                // send viewmodel back to view
                return View(accountLoginViewModel);
            }
            string email = accountLoginViewModel?.Email;
            // check login
            if (email.Equals("vanderhispaillie.timo@gmail.com"))
                return Content(email);
            else
            {
                ModelState.AddModelError("", "Gegevens komen niet overeen!");
                // send back to view
                return View(accountLoginViewModel);
            }
                
            
        }
    }
}
