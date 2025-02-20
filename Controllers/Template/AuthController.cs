using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HigertechDrone.Models;

namespace HigertechDrone.Controllers.Template;

public class AuthController : Controller
{
  public IActionResult ForgotPasswordBasic() => View();
  public IActionResult LoginBasic() => View();
  public IActionResult RegisterBasic() => View();
}
