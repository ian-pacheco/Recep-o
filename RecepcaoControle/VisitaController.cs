using System;
using RecepcaoDados;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepcaoControle {
    public class VisitaController {

        // #C
        public static bool CadastrarVisita(Visita NovaVisita) {

            if (BuscarVisita(NovaVisita.IdVisita) != null) {
                return false;
            } else {
                VisitaDataAccess.Criar(NovaVisita);
                return true;
            }
        }

        // #R
        public static Visita BuscarVisita(int id) {

            Visita oVisita = new Visita();
            oVisita = VisitaDataAccess.ConsultaVisita(id);

            if (oVisita != null)
                return oVisita;
            else
                return null;
        }

        public static bool ValidarBusca(TextBox nome, MaskedTextBox cpf, MaskedTextBox rg, MaskedTextBox rne, ErrorProvider errorProvider) {
            if ((String.IsNullOrEmpty(nome.Text)) && (String.IsNullOrEmpty(cpf.Text))) {
                errorProvider.SetError(nome, "Preencher nome para pesquisar");
                errorProvider.SetError(cpf, "");
                return false;

            } else if (String.IsNullOrEmpty(rg.Text)) {
                errorProvider.SetError(rg, "");
                return true;
            } else if (!String.IsNullOrEmpty(rne.Text)) {
                errorProvider.SetError(rne, "");
                return true;
            } else {
                errorProvider.SetError(nome, "Preencher ao menos um campo válido para pesquisa!");
                return false;
            }
        }
    }
}
