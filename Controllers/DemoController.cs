using Microsoft.AspNetCore.Mvc;

namespace MvcProducto.Controllers;

public class DemoController :
Controller

{

public IActionResult Index()

{

ViewBag.Mesage = "Hola controller";

return View();

}

}