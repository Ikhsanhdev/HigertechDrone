using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HigertechDrone.Models;

namespace HigertechDrone.Controllers;

public class TablesController : Controller
{
  public IActionResult Basic() => View();
}
