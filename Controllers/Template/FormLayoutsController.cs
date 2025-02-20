using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HigertechDrone.Models;

namespace HigertechDrone.Controllers;

public class FormLayoutsController : Controller
{
public IActionResult Horizontal() => View();
public IActionResult Vertical() => View();
}
