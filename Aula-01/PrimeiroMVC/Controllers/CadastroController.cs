using Microsoft.AspNetCore.Mvc;

namespace MVC_2026;

//Controlador Padrão do MVC
public class CadastroController : Controller
{
    public IActionResult Aluno()
    {
        return View();
    }
}
