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
        //get esta pedindo os dados  (server para exibir na view)
        //get tras os dados para você ver o que vai se atualizado -- isso será feito no update
        [HttpGet]
        public IActionResult Cadastrar(){
            
            return View();
        }

        //post está mandando os dados para cadastrar 
        [HttpPost]  /// no update depois de vc ver os dados você vai querer salvar então o post salva pra vc
        public IActionResult Cadastrar([Bind] Cidade cidade){
            objCidadeRep.Cadastrar(cidade); //esse cadastrar e do model
            return RedirectToAction("Index"); //(não vai pra view, vai para o iaction da index do controller)
        }

        [HttpGet]
        public IActionResult Atualizar(int id){
            var dados = objCidadeRep.Atualizar(cidade);
            return View(dados);            
    
        }
        [HttpPost]
        public IActionResult Atualizar(Cidade cidade){
            return RedirectToAction("Index");
        }

    }
}