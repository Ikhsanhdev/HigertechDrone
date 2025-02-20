using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HigertechDrone.Models;

namespace HigertechDrone.Controllers;

public class IconsController : Controller
{
  public IActionResult Boxicons() => View();
}
