using FluentValidation;
using ControleInternet.Requisicoes;

namespace ControleInternet.Validacao
{
    public class ValidarDadosRegistroUsuario : AbstractValidator<RequisicaoRegistrarUsuarioJson>
    {

        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
    }

}
