using ControleInternet.BLL;
using ControleInternet.Models;
using Newtonsoft.Json;
using System.Web.Mvc;

namespace ControleInternet.Controllers
{
    public class AlunoController : Controller
    {
        BLL_Aluno bllAluno = new BLL_Aluno();
        BLL_ListarAluno bllListarAluno = new BLL_ListarAluno();
        BLL_CadastroAluno bllCadastrarAluno = new BLL_CadastroAluno();

        // GET: Aluno
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CadastroAluno()
        {
            return View();
        }
        public ActionResult ListarAluno()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CadastrarAluno(Aluno user)
        {
            var ret = bllCadastrarAluno.CadastrarAluno(user);

            return Json(new
            {
                retorno = ret
            });
        }

        [HttpPost]
        public ActionResult GetLista()
        {
            var ret = bllListarAluno.ListarAluno();
            return Json(new
            {
                retorno = ret
            });

        }
    }
}
