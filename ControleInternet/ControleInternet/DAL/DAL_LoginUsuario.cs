using ControleInternet.Models;
using MongoDB.Driver;
using System.Configuration;
using System;
using ControleInternet.ConexaoBD;

namespace ControleInternet.DAL
{
    public class DAL_LoginUsuario
    {
        public Usuario LoginUsuario(Usuario user)
        {
            try
            {
                var colecao = ConectaBanco.GetAcessoUsuario();

                var filtro = Builders<Usuario>.Filter.Where(bancoDeDados => 
                    bancoDeDados.Email == user.Email && bancoDeDados.Senha == user.Senha);

                var query = colecao.Find(filtro).FirstOrDefault();

                if (query != null)
                {
                    return query;
                }
                else
                {
                    return null;
                };
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}