using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers;

public class AccountController : Controller
{
    private readonly AuthService _auth;

    public AccountController(AuthService auth)
    {
        _auth = auth;
    }

 
    public IActionResult SignUp()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> SignUp(UserSignUpViewModel model)
    {
        if (ModelState.IsValid)
        {
            if (await _auth.SignUpAsync(model))
                return RedirectToAction("SignIn");

            ModelState.AddModelError("", "User with the same email already exists");
        }
        return View(model);
    }



    public IActionResult SignIn()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> SignIn(UserSignInViewModel model)
    {
        if (ModelState.IsValid)
        {
            if (await _auth.SignInAsync(model))
                return RedirectToAction("Index");

            ModelState.AddModelError("", "Incorrect email or password");
        }
        return View(model);
    }

    // Shows page if signed in
    [Authorize]
    public IActionResult Index()
    {
        return View();
    }


    [Authorize]
    public new async Task<IActionResult> SignOut()
    {
        if (await _auth.SignOutAsync(User))
            return LocalRedirect("/");

        return RedirectToAction("Index");

    }


}
