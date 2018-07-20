using RecepcaoDados;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace RecepcaoControle {
    public class FuncionarioController {

        // #C
        public static bool CadastrarFuncionario(Funcionario NovoFuncionario) {

            if (BuscarFuncionario(NovoFuncionario.IdFuncionario) != null) {
                return false;
            } else {
                FuncionarioDataAccess.Criar(NovoFuncionario);
                return true;
            }
        }

        // #R
        public static Funcionario BuscarFuncionario(int id) {

            Funcionario oFuncionario = new Funcionario();
            oFuncionario = FuncionarioDataAccess.ConsultaFuncionario(id);

            if (oFuncionario != null)
                return oFuncionario;
            else
                return null;
        }

        public static List<Funcionario> ConsultaLogin(string plogin) {

            List<Funcionario> oFuncionario = new List<Funcionario>();
            oFuncionario = FuncionarioDataAccess.ConsultaLogin(plogin);

            if (oFuncionario != null)
                return oFuncionario;
            else
                return null;
        }

        //Criptografar senha
        public static string AcertaSenha(string _login, string _senha) {
            StringBuilder senha = new StringBuilder();
            MD5 md5 = MD5.Create();
            byte[] entrada = Encoding.ASCII.GetBytes(_login + "//" + _senha);
            byte[] hash = md5.ComputeHash(entrada);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++) {
                senha.Append(hash[i].ToString("X2"));
            }
            return senha.ToString();
        }

    }
}
