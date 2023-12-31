﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using projeto_teste.Models;

namespace projeto_teste.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    // alteraçao teste
    public IActionResult Privacy()
    {
        return View();
    }
    // branch develop teste

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
