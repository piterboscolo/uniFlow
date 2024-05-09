using ControleInternet.DLL;
using ControleInternet.Models;
using System;
using System.Threading.Tasks;

namespace ControleInternet.BLL
{
    public class BLL_CadastroUsuario
    {
        DAL_CadastroUsuario dalUsuario = new DAL_CadastroUsuario();

        public string CadastrarUsuario(Usuario user)
        {
            var retorno = dalUsuario.CadastrarUsuario(user);

            return retorno;
        }

        public string EditarUsuario(Usuario user)
        {
            var retorno = dalUsuario.EditarUsuario(user);

            return retorno;
        }
    }
}