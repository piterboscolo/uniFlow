using ControleInternet.DLL;
using ControleInternet.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleInternet.BLL
{
    public class BLL_ListarAluno
    {
        DAL_ListaAluno dalAluno = new DAL_ListaAluno();

        
        public List<Aluno> ListarAluno()
        {
            return dalAluno.ListarAluno();
        }
    }
}