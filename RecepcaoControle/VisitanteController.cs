using RecepcaoDados;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RecepcaoControle {
    public class VisitanteController {

        // #Create
        public static bool CadastrarVisitante(Visitante NovoVisitante) {

            if (ConsultaVisitante(NovoVisitante.IdVisitante) != null) {
                return false;
            } else {
                VisitanteDataAccess.Criar(NovoVisitante);
                return true;
            }
        }

        // #Read
        public static Visitante ConsultaVisitante(int id) {

            Visitante oVisitante = new Visitante();
            oVisitante = VisitanteDataAccess.ConsultaVisitante(id);

            if (oVisitante != null)
                return oVisitante;
            else
                return null;
        }

        public static Visitante ConsultaVisitante(string nome) {

            Visitante user = new Visitante();

            user = VisitanteDataAccess.ConsultaVisitante(nome);

            if (user != null) {
                return user;
            } else {
                return null;
            }

        }

        public static Visitante ConsultaVisitanteCPF(string cpf) {

            Visitante user = new Visitante();

            user = VisitanteDataAccess.ConsultaVisitanteCPF(cpf);

            if (user != null) {
                return user;
            } else {
                return null;
            }

        }

        public static Visitante ConsultaVisitanteRG(string rg) {

            Visitante user = new Visitante();

            user = VisitanteDataAccess.ConsultaVisitanteRG(rg);

            if (user != null) {
                return user;
            } else {
                return null;
            }

        }

        public static Visitante ConsultaVisitanteRNE(string rne) {

            Visitante user = new Visitante();

            user = VisitanteDataAccess.ConsultaVisitanteRNE(rne);

            if (user != null) {
                return user;
            } else {
                return null;
            }

        }

        public static List<Visitante> ConsultaVisitanteNome(string nome) {
            List<Visitante> lista = new List<Visitante>();
            lista = VisitanteDataAccess.ConsultaVisitanteNome(nome);

            if (lista != null) {
                return lista;
            } else {
                return null;
            }
        }

        public static List<Visitante> ConsultaVisitanteCPFList(string cpf) {

            List<Visitante> user = new List<Visitante>();

            user = VisitanteDataAccess.ConsultaVisitanteCPFList(cpf);

            if (user != null) {
                return user;
            } else {
                return null;
            }

        }

        public static List<Visitante> ConsultaVisitanteRGList(string rg) {

            List<Visitante> user = new List<Visitante>();

            user = VisitanteDataAccess.ConsultaVisitanteRGList(rg);

            if (user != null) {
                return user;
            } else {
                return null;
            }

        }

        public static List<Visitante> ConsultaVisitanteRNEList(string rne) {

            List<Visitante> lista = new List<Visitante>();

            lista = VisitanteDataAccess.ConsultaVisitanteRNEList(rne);

            if (lista != null) {
                return lista;
            } else {
                return null;
            }

        }

        public static bool ValidarCampoBusca(TextBox nome, MaskedTextBox cpf, TextBox rg, TextBox rne, ErrorProvider errorProvider) {

            if ((String.IsNullOrEmpty(nome.Text)) && (String.IsNullOrWhiteSpace(cpf.Text)) && (!String.IsNullOrWhiteSpace(rg.Text))) {
                errorProvider.SetError(nome, "Preencher nome para pesquisar!");
                errorProvider.SetError(cpf, "Preencher CPF para pesquisar!");
                errorProvider.SetError(rg, "Preencher RG para pesquisar!");
                return false;

            } else if (!String.IsNullOrEmpty(nome.Text)) {
                errorProvider.SetError(nome, "Preencher Nome para pesquisar!");
                return true;
            } else if (String.IsNullOrEmpty(rne.Text)) {
                errorProvider.SetError(rne, "Preencher RNE para pesquisar!");
                return true;
            } else if (!String.IsNullOrEmpty(cpf.Text)) {
                return true;
            } else {
                errorProvider.SetError(nome, "");
                errorProvider.SetError(cpf, "");
                errorProvider.SetError(rg, "");
                errorProvider.SetError(rne, "");
                return true;
            }

        }

        //Update
        public static bool Atualiza(Visitante pvisitante) {
            if (ConsultaVisitante(pvisitante.IdVisitante) != null) {
                if (!VisitanteDataAccess.Atualiza(pvisitante)) {
                    return false;
                } else {
                    //VisitanteDataAccess.Atualiza(NovoVisitante);
                    return true;
                }
            } else {
                return false;
            }
        }            
        
        public static List<Visitante> AtualizaList(int id) {
            List<Visitante> visitantes = new List<Visitante>();
            visitantes = VisitanteDataAccess.AtualizaList(id);
            if (visitantes != null) {
                return visitantes;
            } else
                return null;
        }

        //Delete
        public static bool Deleta(int id) {
            if (!VisitanteDataAccess.Deleta(id))
                return false;
            else
                return true;
        }

        public static bool Deleta(Visitante visitante) {
            if (!VisitanteDataAccess.Deleta(visitante))
                return false;
            else
                return true;
        }
    }
}
