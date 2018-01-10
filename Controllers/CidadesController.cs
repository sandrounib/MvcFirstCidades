using Microsoft.AspNetCore.Mvc;
using ProjetoCidades.Models;

namespace ProjetoCidades.Controllers
{
    public class CidadesController:Controller
    {
        Cidade cidade = new Cidade();
        
        public IActionResult Index(){
            var Lista = cidade.ListarCidades();
            return View(Lista);
        }
        public IActionResult CidadesEstados(){
            var Lista = cidade.ListarCidades();
            return View(Lista);
        }
        public IActionResult TodosOsDados(){
            var Lista = cidade.ListarCidades();
            return View(Lista);
        }
    }
}