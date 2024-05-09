using ControleInternet.Requisicoes;
using ControleInternet.Respostas;
using System.Threading.Tasks;

namespace ControleInternet.BLL.UseCase
{
    public interface IRegistrarUsuarioUseCase
    {
        Task<string> Executar(RequisicaoRegistrarUsuarioJson requisicao);
    }
}