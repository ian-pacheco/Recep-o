using System;
using System.Collections.Generic;
using System.Linq;

namespace RecepcaoDados {
    public class VisitanteDataAccess {

        //Create

        //Insere visitante na tabela Visitante
        public static bool Criar(Visitante visitante) {

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
        public static bool Criar(List<Visitante> visitantes) {

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

        //Read

        //Consulta visitante pelo id na tabela Visitante
        public static Visitante ConsultaVisitante(int idVisitante) {

            RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
            Visitante iVisitante = (from selecao in Db.Visitante
                                    where selecao.IdVisitante == idVisitante
                                    select selecao).SingleOrDefault();
            return iVisitante;
        }

        //Consulta visitante pelo nome na tabela Visitante
        public static Visitante ConsultaVisitante(string nome) {

            RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
            Visitante iVisitante = (from selecao in Db.Visitante
                                    where selecao.Nome.Contains(nome)
                                    select selecao).SingleOrDefault();
            return iVisitante;
        }

        //Consulta visitante pelo CPF na tabela Visitante
        public static Visitante ConsultaVisitanteCPF(string cpf) {

            RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
            Visitante iVisitante = (from selecao in Db.Visitante
                                    where selecao.CPF == (cpf)
                                    select selecao).SingleOrDefault();
            return iVisitante;
        }

        //Consulta visitante pelo RG na tabela Visitante
        public static Visitante ConsultaVisitanteRG(string rg) {

            RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
            Visitante iVisitante = (from selecao in Db.Visitante
                                    where selecao.RG.Contains(rg)
                                    select selecao).SingleOrDefault();
            return iVisitante;
        }

        //Consulta visitante pelo RNE na tabela Visitante
        public static Visitante ConsultaVisitanteRNE(string rne) {

            RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
            Visitante iVisitante = (from selecao in Db.Visitante
                                    where selecao.RNE.Contains(rne)
                                    select selecao).SingleOrDefault();
            return iVisitante;
        }

        //Consulta lista de visitantes na tabela Visitante
        public static List<Visitante> ConsultaVisitanteNome(string nome) {

            RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
            List<Visitante> iVisitante = (from selecao in Db.Visitante
                                          where selecao.Nome.Contains(nome)
                                          select selecao).ToList();
            return iVisitante;
        }

        //Consulta visitante pelo CPF na tabela Visitante po lista
        public static List<Visitante> ConsultaVisitanteCPFList(string cpf) {

            RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
            List<Visitante> iVisitante = (from selecao in Db.Visitante
                                          where selecao.CPF.Contains(cpf)
                                          select selecao).ToList();
            return iVisitante;
        }

        //Consulta visitante pelo CPF na tabela Visitante po lista
        public static List<Visitante> ConsultaVisitanteRGList(string rg) {

            RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
            List<Visitante> iVisitante = (from selecao in Db.Visitante
                                          where selecao.RG.Contains(rg)
                                          select selecao).ToList();
            return iVisitante;
        }

        //Consulta visitante pelo CPF na tabela Visitante po lista
        public static List<Visitante> ConsultaVisitanteRNEList(string rne) {

            RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
            List<Visitante> iVisitante = (from selecao in Db.Visitante
                                          where selecao.RNE == (rne)
                                          select selecao).ToList();
            return iVisitante;
        }

        //Update

        public static List<Visitante> AtualizaList(int idVisitante) {
            RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
            List<Visitante> iVisitante = (from selecao in Db.Visitante
                                    where selecao.IdVisitante == idVisitante
                                    select selecao).ToList();
            return iVisitante;
        }

        //Atualizar visitante utilizando id, na tabela Visitante
        public static bool Atualiza(Visitante pVisitante) {

            try {
                RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
                Visitante oVisitante = (from selecao in Db.Visitante
                                        where selecao.IdVisitante == pVisitante.IdVisitante
                                        select selecao).SingleOrDefault();

                oVisitante.IdVisitante = pVisitante.IdVisitante;
                oVisitante.CPF = pVisitante.CPF;
                oVisitante.RG = pVisitante.RG;
                oVisitante.RNE = pVisitante.RNE;
                oVisitante.Nome = pVisitante.Nome;
                oVisitante.Idade = pVisitante.Idade;
                oVisitante.Estrangeiro = pVisitante.Estrangeiro;
                oVisitante.Logradouro = pVisitante.Logradouro;
                oVisitante.Bairro = pVisitante.Bairro;
                oVisitante.Cidade = pVisitante.Cidade;
                oVisitante.UF = pVisitante.UF;
                oVisitante.Pais = pVisitante.Pais;
                oVisitante.Foto = pVisitante.Foto;
                Db.SubmitChanges();
                Db.Dispose();

                return true;
            } catch (Exception) {
                return false;
            }
        }

        //Delete

        //Deleta uma lista de visitantes na tabela Visitante
        public static bool Deleta(List<Visitante> visitantes) {

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

        //Deleta visitante na tabela Visitante
        public static bool Deleta(Visitante visitante) {

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

        //Deleta visitante utilizando id, na tabela Visitante
        public static bool Deleta(int idvisitante) {

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
    }
}
