using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wba.FormViewModelExample.Web.ViewModels;

namespace Wba.FormViewModelExample.Web.Controllers
{
    public class EstaController : Controller
    {
        [HttpGet]
        public IActionResult Apply()
        {
            EstaApplyViewModel estaApplyViewModel = new EstaApplyViewModel();
            estaApplyViewModel.Date = DateTime.Now;
            return View(estaApplyViewModel);
        }

        [HttpPost]
        public IActionResult Process
            (EstaApplyViewModel estaApplyViewModel)
        {
            //perform validation
            //store user in Db
            //redirect to ...
            return RedirectToAction("RegistrationSuccess");
        }

        [HttpGet]
        [Route("esta/thanks-for-registering")]
        public IActionResult RegistrationSuccess
            ()
        {
            return View();
        }
    }
}
