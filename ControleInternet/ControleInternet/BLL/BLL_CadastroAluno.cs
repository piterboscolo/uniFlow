using ControleInternet.DLL;
using ControleInternet.Models;
using System.Threading.Tasks;

namespace ControleInternet.BLL
{
    public class BLL_CadastroAluno
    {
        DAL_CadastroAluno dalAluno = new DAL_CadastroAluno();

        public string CadastrarAluno(Aluno user)
        {
            var retorno = dalAluno.CadastrarAluno(user);

            return retorno;
        }
    }
}