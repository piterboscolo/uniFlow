using ControleInternet.BLL.UseCase;
using ControleInternet.ConexaoBD;
using ControleInternet.Models;
using ControleInternet.Validacao;
using MongoDB.Driver;
using System;

namespace ControleInternet.DLL
{
    public class DAL_CadastroAluno
    {
        public string CadastrarAluno (Aluno user)
        {
            try
            {
                var colecao = ConectaBanco.GetAcessoAluno();

                var verificaEmail = UtilitariosRegex.IsValidEmail(user.Email);

                if (verificaEmail)
                {
                    if (VerificaEmailJaCadastrado(user.Email))
                        return $"Email {user.Email} já cadastrado!";

                    user.Flag = "1";
                    colecao.InsertOne(user);
                    return "Cadastro realizado com sucesso!";
                }

                return "Digite um e-mail válido";
            }
            catch (Exception e)
            {
                return "Erro " + e.Message;
            }
        }
        
        private bool VerificaEmailJaCadastrado(string email)
        {
            var colecao = ConectaBanco.GetAcessoAluno();

            var filtro = Builders<Aluno>.Filter.Where(bancoDeDados =>
                bancoDeDados.Email == email);

            var emailCadastrado = colecao.Find(filtro).FirstOrDefault();

            if (emailCadastrado != null)
            {
                return true;
            }

            return false;
        }
    }

    //Login usuario não utilizado devido a criação de DAL específica para login
    //Verificar DalLoginUsuario
    #region LoginUsuarioNaoUtilizado
    //public string LoginUsuario(Usuario user)
    //{
    //    try
    //    {
    //        #region ConexaoBancoNaoUtilizada
    //        //string conexaoMongoDB = ConfigurationManager.ConnectionStrings["conexaoMongoDB"].ConnectionString;
    //        //var client = new MongoClient(conexaoMongoDB);
    //        //var db = client.GetDatabase("CONTROLEINTERNET");
    //        //IMongoCollection<Usuario> colecao = db.GetCollection<Usuario>("usuario");
    //        #endregion

    //        var colecao = ConectaBanco.GetAcessoUsuario();

    //        var filtro = Builders<Usuario>.Filter.Where(bancoDeDados => bancoDeDados.Email == user.Email && bancoDeDados.Senha == user.Senha);

    //        var query = colecao.Find(filtro).FirstOrDefault();

    //        if (query != null)
    //        {
    //            return "Login efetuado com sucesso";
    //        } else 
    //        {
    //            return "Usuário ou senha incorretos!";
    //        };
    //    }
    //    catch (Exception e)
    //    {
    //        return "Erro " + e.Message;
    //    }
    //}
    #endregion
}