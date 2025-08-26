using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentApp.Web.Models;

namespace StudentApp.Web.Controllers;

public class AuthController : Controller{
    public IActionResult Auth(){
        return View();
    }

    public IActionResult Register(){
        return View();
    }
}