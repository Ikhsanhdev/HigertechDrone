using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HigertechDrone.Models;

namespace HigertechDrone.Controllers;

public class DashboardsController : Controller
{
  public IActionResult Index() => View();
}
