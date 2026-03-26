using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_TREINO_POO
{
    public class CredenciaisUsuario
    {
        public string usuario { get; set; }

        public string matricula { get; set; }

        public string senha { get; set; }

        public CredenciaisUsuario(string NomeUsuario, string MatriculaUsuario, string SenhaUsuario)
        {
            usuario = NomeUsuario;

            matricula = MatriculaUsuario;

            senha = SenhaUsuario;
        }

        public bool verificaCredenciais()
        {
            return usuario == "Eva" && matricula == "12345678" && senha == "123";
        }

    }
}
