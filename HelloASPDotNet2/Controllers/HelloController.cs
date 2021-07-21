using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASPDotNET2.Controllers
{
    //[Route("/helloworld")]
    public class HelloController : Controller
    {
        [HttpGet("/helloworld")]
        public IActionResult Index()
        {
            string html =
              @"<form method='post' action='/helloworld/test'>
                <label for='name'>Please enter you name: </label>
                <input type='text' name='name'/>
                
                <label for='language'>Select a language: </label>
                <select name='language' id='language'>
                    <option value='Hello'>English</option>
                    <option value='Hallo'>German</option>
                    <option value='Ciao'>Italian</option>
                    <option value='Bonjour'>French</option>
                    <option value='Hola'>Spanish</option>
                    
                </select>
​
                <input type='submit' value='Greet Me!'/>
                </form>";

            return Content(html, "text/html");
        }

        [HttpPost("/helloworld/test")]
        //[Route("/test")]
        public IActionResult Test(string name, string language = "hello")
        {
            return Content("<h1>Name: " + name + " Language: " + language + "</h1>", "text/html");
        }

        //[HttpGet("welcome/{name?}")]
        [HttpPost]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }

        public static string CreateMessage(string language)
        {
            return language;
        }
    }
}