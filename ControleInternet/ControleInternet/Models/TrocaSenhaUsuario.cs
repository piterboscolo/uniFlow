using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleInternet.Models
{
    public class TrocaSenhaUsuario
    {
        public string Email { get; set; }
        public string SenhaAtual { get; set; }
        public string NovaSenha { get; set; }
    }
}