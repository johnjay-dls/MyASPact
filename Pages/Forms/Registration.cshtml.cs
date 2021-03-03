using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFirstProject.Models;

namespace MyFirstProject.Pages.Forms
{
    public class RegistrationModel : PageModel
    {
        [BindProperty]
       public PersonModel Person { get; set; }



        //GET handlers
        public void OnGet(string Name, string Lastname, string Age, string Email, string Contactnumber, string Password, string Confirmpassword)
        {
            //HttpResponseWritingExtensions.WriteAsync(this.Response, "Hi!" + name + ". Your lastname is " + lastname + "");
        }

        //POST handler

        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return Redirect("/Index");


            //string name = Request.Form["txtname"];
            //string lastname = Request.Form["textlastname"];
            //string email = Request.Form["textemail"];
            //string age = Request.Form["textage"];
            //string contactno = Request.Form["textcontactno"];
            //string password = Request.Form["textpassword"];
            //string confirmpassword = Request.Form["textconfirmpassword"];
            //HttpResponseWritingExtensions.WriteAsync(this.Response,"Hi!" + Person.Name+". Your lastname is "+ Person.Lastname+"");

        }
    }
}
