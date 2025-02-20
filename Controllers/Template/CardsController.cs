using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HigertechDrone.Models;

namespace HigertechDrone.Controllers;

public class CardsController : Controller
{
  public IActionResult Basic() => View();
}
