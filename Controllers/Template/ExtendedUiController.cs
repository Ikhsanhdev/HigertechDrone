using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HigertechDrone.Models;

namespace HigertechDrone.Controllers;

public class ExtendedUiController : Controller
{
  public IActionResult PerfectScrollbar() => View();
  public IActionResult TextDivider() => View();
}
