using System;
using System.Collections.Generic;
using System.Linq;

namespace RecepcaoDados {
    public class VisitaDataAccess {

        //Insere visita na tabela visita
        public static bool Criar(Visita visita)  {

            try {
                RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
                Db.Visita.InsertOnSubmit(visita);
                Db.SubmitChanges();
                Db.Dispose();

                return true;
            } catch (Exception) {
                return false;
            }
        }

        //Insere uma lista de visitas na tabela Visita
        public static bool Criar(List<Visita> visitas) {

            try {
                RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
                Db.Visita.InsertAllOnSubmit(visitas);
                Db.SubmitChanges();
                Db.Dispose();

                return true;
            } catch (Exception) {
                return false;
            }
        }

        //Deleta visita na tabela Visita
        public static bool Deleta(Visita visita) {

            try {
                RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
                Db.Visita.DeleteOnSubmit(visita);
                Db.SubmitChanges();
                Db.Dispose();

                return true;
            } catch (Exception) {
                return false;
            }
        }

        //Deleta uma lista de visita na tabela Visita
        public static bool Deleta(List<Visita> visitas) {

            try {
                RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
                Db.Visita.DeleteAllOnSubmit(visitas);
                Db.SubmitChanges();
                Db.Dispose();

                return true;
            } catch (Exception) {
                return false;
            }
        }

        //Deleta visita utilizando id, na tabela Visita
        public static bool Deleta(int visita) {

            try {
                RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
                Visita ivisita = (from selecao in Db.Visita where selecao.IdVisita == visita select selecao).SingleOrDefault();

                Db.Visita.DeleteOnSubmit(ivisita);
                Db.SubmitChanges();
                Db.Dispose();

                return true;
            } catch (Exception) {
                return false;
            }
        }

        //Consulta visita na tabela Visita
        public static Visita ConsultaVisita(int idVisita) {

            RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
            Visita iVisita = (from selecao in Db.Visita where selecao.IdVisita == idVisita select selecao).SingleOrDefault();
            return iVisita;
        }

        //Consulta lista de visita na tabela Visita
        public static List<Visita> ConsultaVisita() {

            RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
            List<Visita> iVisita = (from selecao in Db.Visita
                                    orderby selecao.Data 
                                    descending select selecao).ToList();
            return iVisita;
        }

        //Atualizar visita utilizando id, na tabela Visita
        public static bool Atualiza(Visita idVisita) {

            try {
                RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
                Visita iVisita = (from selecao in Db.Visita where selecao.IdVisita == idVisita.IdVisita select selecao).SingleOrDefault();

                iVisita.Setor = idVisita.Setor;
                iVisita.Secretaria = idVisita.Secretaria;
                iVisita.Liberacao = idVisita.Liberacao;
                iVisita.ContatoInterno = idVisita.ContatoInterno;
                Db.SubmitChanges();
                Db.Dispose();

                return true;
            } catch (Exception) {
                return false;
            }
        }

    }
}
