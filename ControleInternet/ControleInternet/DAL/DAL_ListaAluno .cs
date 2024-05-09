using ControleInternet.BLL.UseCase;
using ControleInternet.ConexaoBD;
using ControleInternet.Models;
using ControleInternet.Validacao;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Web.Mvc;

namespace ControleInternet.DLL
{
    public class DAL_ListaAluno
    {
        public List<Aluno> ListarAluno()
        {
            try
            {
                var colecao = ConectaBanco.GetAcessoAluno();

                var filter = Builders<Aluno>.Filter.Empty;

                var retorno = colecao.Find(filter).ToList();
                string a = retorno[0]._id.ToString();
                return (retorno);

            }
            catch (Exception e)
            {
                throw new Exception($"Erro {e.Message}");
            }
        }
    }
}