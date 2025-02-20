using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HigertechDrone.Models;

namespace HigertechDrone.Controllers;

public class FormsController : Controller
{
  public IActionResult BasicInputs() => View();
  public IActionResult InputGroups() => View();
}
