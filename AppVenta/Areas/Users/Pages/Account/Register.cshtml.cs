using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppVenta.Areas.Users.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppVenta.Areas.Users.Pages.Account
{
    public class RegisterModel : PageModel
    {
        public void OnGet()
        {
        }
        // clase inputmodel
        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel : InputModelRegister
        {
            public IFormFile AvatarImage { get; set; }
        }
    }
}












