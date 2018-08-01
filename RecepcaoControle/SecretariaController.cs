using System.Collections.Generic;
using System.Linq;
using RecepcaoDados;

namespace RecepcaoControle {
    public class SecretariaController {
        public static List<Secretaria> BuscaSecretarias() {

            List<Secretaria> listaSecretaria = new List<Secretaria>();

            listaSecretaria = SecretariaDataAccess.ObterSecretarias();

            return listaSecretaria;

        }

        public static bool SalvarSecretaria(Secretaria secretaria) {
            if (BuscarSecretaria(secretaria.IdSecretaria) != null) {
                return false;
            } else if (!SecretariaDataAccess.Insere(secretaria)) {
                return false;
            } else {
                return true;
            }
        }

        public static Secretaria BuscarSecretaria(int idSecretaria) {

            Secretaria secr = new Secretaria();
            secr = SecretariaDataAccess.ObterSecretaria(idSecretaria);

            if (secr != null) {
                return secr;
            } else {
                return null;
            }
        }

        public static bool AtualizaSecretaria(Secretaria secretaria) {

            if (!SecretariaDataAccess.Atualiza(secretaria)) {
                return false;
            } else {
                return true;
            }
        }

        public static bool ExcluirSecretaria(int idSecretaria) {

            if (!SecretariaDataAccess.Exclui(idSecretaria)) {
                return false;
            } else {
                return true;
            }
        }
    }
}
