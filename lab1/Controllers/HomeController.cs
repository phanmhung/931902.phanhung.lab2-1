using lab1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
namespace lab1.Controllers;

public class HomeController : Controller
{
    private readonly Random rand = new Random();
    public readonly int a;
    public readonly int b;
    public readonly string add;
    public readonly string sub;
    public readonly string mul;
    public readonly string div;

    public HomeController()
    {
        a = rand.Next(11);
        b = rand.Next(11);
        add = $"{a} + {b} = {a + b}";
        sub = $"{a} - {b} = {a - b}";
        mul = $"{a} * {b} = {a * b}";
        if(b == 0) { div = "Division by zero!"; }
        else
        {
            div = $"{a} / {b} = {a / b}";
        }
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult PassUsingModel()
    {
        var calcModel = new CalcModel(a, b, add, sub, mul, div);
        return View(calcModel);
    }

    public IActionResult PassUsingViewData()
    {
        ViewData["a"] = a;
        ViewData["b"] = b;
        ViewData["add"] = add;
        ViewData["sub"] = sub;
        ViewData["mul"] = mul;
        ViewData["div"] = div;
        return View();
    }

    public IActionResult PassUsingViewBag()
    {
        ViewBag.a = a;
        ViewBag.b = b;
        ViewBag.add = add;
        ViewBag.sub = sub;
        ViewBag.mul = mul;
        ViewBag.div = div;
        return View();
    }

    public IActionResult AccessServiceDirectly()
    {
        return View(this);
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

