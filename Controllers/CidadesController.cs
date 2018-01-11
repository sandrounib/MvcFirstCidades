using Microsoft.AspNetCore.Mvc;
using ProjetoCidades.Models;
using ProjetoCidades.Models.Repositorio;

namespace ProjetoCidades.Controllers
{
    public class CidadesController:Controller
    {
        Cidade cidade = new Cidade();

        //LISTAGEM VIA BD
        CidadeRep objCidadeRep = new CidadeRep();

        //lista pegando os dados do banco de dados
        //é mostrado no menu Home
        public IActionResult Index(){
            var lista= objCidadeRep.Listar();
            return View(lista);
        }        
        
        /*
        Lista os dados da Pasta Repositorio CLASSE CIDADE.cs
        nessa classe tem um método List<Cidade> ListarCidades(){
        na qual os dados estão digitados aqui mesmo no VSCODE
        
        public IActionResult Index(){
            var Lista = cidade.ListarCidades();
            return View(Lista);
        }
         */
        public IActionResult CidadesEstados(){
            var Lista = cidade.ListarCidades();
            return View(Lista);
        }
        public IActionResult TodosOsDados(){
            var Lista = cidade.ListarCidades();
            return View(Lista);
        }

        public IActionResult Cadastrar(){
            
            return View();
        }
    }
}