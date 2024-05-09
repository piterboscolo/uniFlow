using ControleInternet.DLL;
using ControleInternet.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleInternet.BLL
{
    public class BLL_ListarUsuario
    {
        DAL_ListaUsuario dalUsuario = new DAL_ListaUsuario();

        
        public List<Usuario> ListarUsuario()
        {
            return dalUsuario.ListarUsuario();
        }
    }
}