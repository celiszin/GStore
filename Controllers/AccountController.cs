using System.Net.Mail;
using System.Security.Claims;
using GStore.Data;
using GStore.Helpers;
using GStore.Models;
using GStore.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GStore.Controllers;
public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;
    private readonly SignInManager<Usuario> _signInManager;
    private readonly UserManager<Usuario> _userManager;
    private readonly IWebHostEnvironment _host;
    private readonly AppDbContext _db;

    public AccountController(
        ILogger<AccountController> logger,
        SignInManager<Usuario> signInManager,
        UserManager<Usuario> userManager,
        IWebHostEnvironment host,
        AppDbContext db
    )
    {
        _logger = logger;
        _signInManager = signInManager;
        _userManager = userManager;
        _host = host;
    }
    

    [HttpsGet]
    public IActionResult Login(string returnUrl)
    {
        LoginVM login = new()
        {
            UrlRetorno = returnUrl ?? Url.Content("~/")
        };
    return View(login);
    }

    }