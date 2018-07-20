using System;
using System.Collections.Generic;
using System.Linq;

namespace RecepcaoDados {
    class VisitanteDataAccess {

        //Insere visitante na tabela Visitante
        public bool Criar(Visitante visitante) {

            try {
                RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
                Db.Visitante.InsertOnSubmit(visitante);
                Db.SubmitChanges();
                Db.Dispose();

                return true;
            } catch (Exception) {
                return false;
            }
        }

        //Insere uma lista de visitantes na tabela Visitante
        public bool Criar(List<Visitante> visitantes) {

            try {
                RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
                Db.Visitante.InsertAllOnSubmit(visitantes);
                Db.SubmitChanges();
                Db.Dispose();

                return true;
            } catch (Exception) {
                return false;
            }
        }

        //Deleta visitante na tabela Visitante
        public bool Deleta(Visitante visitante) {

            try {
                RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
                Db.Visitante.DeleteOnSubmit(visitante);
                Db.SubmitChanges();
                Db.Dispose();

                return true;
            } catch (Exception) {
                return false;
            }
        }

        //Deleta uma lista de visitantes na tabela Visitante
        public bool Deleta(List<Visitante> visitantes) {

            try {
                RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
                Db.Visitante.DeleteAllOnSubmit(visitantes);
                Db.SubmitChanges();
                Db.Dispose();

                return true;
            } catch (Exception) {
                return false;
            }
        }

        //Deleta visitante utilizando id, na tabela Visitante
        public bool Deleta(int idvisitante) {

            try {
                RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
                Visitante ivisitante = (from selecao in Db.Visitante where selecao.IdVisitante == idvisitante select selecao).SingleOrDefault();

                Db.Visitante.DeleteOnSubmit(ivisitante);
                Db.SubmitChanges();
                Db.Dispose();

                return true;
            } catch (Exception) {
                return false;
            }
        }

        //Consulta visitante na tabela Visitante
        public Visitante ConsultaVisitante(int idVisitante) {

            RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
            Visitante iVisitante  = (from selecao in Db.Visitante where selecao.IdVisitante == idVisitante select selecao).SingleOrDefault();
            return iVisitante;
        }

        //Consulta lista de visitantes na tabela Visitante
        public List<Visitante> ConsultaVisitante() {

            RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
            List<Visitante> iVisitante = (from selecao in Db.Visitante orderby selecao.Nome select selecao).ToList();
            return iVisitante;
        }

        //Atualizar visitante utilizando id, na tabela Visitante
        public bool Atualiza(Visitante idVisitante) {

            try {
                RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
                Visitante iVisitante = (from selecao in Db.Visitante where selecao.IdVisitante == idVisitante.IdVisitante select selecao).SingleOrDefault();

                iVisitante.CPF = idVisitante.CPF;
                iVisitante.RG = idVisitante.RG;
                iVisitante.RNE = idVisitante.RNE;
                iVisitante.Nome = idVisitante.Nome;
                iVisitante.Idade = idVisitante.Idade;
                iVisitante.Estrangeiro = idVisitante.Estrangeiro;
                iVisitante.Logradouro = idVisitante.Logradouro;
                iVisitante.Bairro = idVisitante.Bairro;
                iVisitante.Cidade = idVisitante.Cidade;
                iVisitante.UF = idVisitante.UF;
                iVisitante.Pais = idVisitante.Pais;
                iVisitante.Foto = idVisitante.Foto;
                Db.SubmitChanges();
                Db.Dispose();

                return true;
            } catch (Exception) {
                return false;
            }
        }

    }
}
