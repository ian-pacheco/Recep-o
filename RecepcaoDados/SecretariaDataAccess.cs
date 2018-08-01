using System;
using System.Collections.Generic;
using System.Linq;

namespace RecepcaoDados {
    public class SecretariaDataAccess {

        public static bool Insere(Secretaria pSecretariar) {
            try {
                RecepcaoDataClassesDataContext oDB = new RecepcaoDataClassesDataContext();
                oDB.Secretaria.InsertOnSubmit(pSecretariar);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            } catch (Exception) {
                return false;
            }
        }

        public static bool Insere(List<Secretaria> pSecretaria) {
            try {
                RecepcaoDataClassesDataContext oDB = new RecepcaoDataClassesDataContext();
                oDB.Secretaria.InsertAllOnSubmit(pSecretaria);
                oDB.SubmitChanges();
                oDB.Dispose();

                return true;
            } catch (Exception) {
                return false;
            }
        }

        public static bool Exclui(Secretaria pSecretaria) {
            try {
                RecepcaoDataClassesDataContext oDB = new RecepcaoDataClassesDataContext();
                oDB.Secretaria.DeleteOnSubmit(pSecretaria);
                oDB.SubmitChanges();
                oDB.Dispose();

                return true;
            } catch (Exception) {
                return false;
            }
        }

        public static bool Exclui(List<Secretaria> pSecretaria) {
            try {
                RecepcaoDataClassesDataContext oDB = new RecepcaoDataClassesDataContext();
                oDB.Secretaria.DeleteAllOnSubmit(pSecretaria);
                oDB.SubmitChanges();
                oDB.Dispose();

                return true;
            } catch (Exception) {
                return false;
            }
        }

        public static bool Exclui(int pIdSecretaria) {
            try {
                RecepcaoDataClassesDataContext oDB = new RecepcaoDataClassesDataContext();
                Secretaria oSecretaria = (from selecao in oDB.Secretaria
                                     where selecao.IdSecretaria == pIdSecretaria
                                     select selecao).SingleOrDefault();
                oDB.Secretaria.DeleteOnSubmit(oSecretaria);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            } catch (Exception) {
                return false;
            }
        }

        public static Secretaria ObterSecretaria(int pIdSecretaria) {
            RecepcaoDataClassesDataContext oDB = new RecepcaoDataClassesDataContext();
            Secretaria oSecretaria = (from selecao in oDB.Secretaria
                                 where selecao.IdSecretaria == pIdSecretaria
                                 select selecao).SingleOrDefault();
            return oSecretaria;
        }
       
        public static List<Secretaria> ObterSecretarias() {
            RecepcaoDataClassesDataContext oDB = new RecepcaoDataClassesDataContext();
            List<Secretaria> oSecretarias = (from selecao in oDB.Secretaria
                                        select selecao).ToList();
            return oSecretarias;
        }

        public static List<Secretaria> ObterSecretarias(int idSecretarias) {
            RecepcaoDataClassesDataContext oDB = new RecepcaoDataClassesDataContext();
            List<Secretaria> oSecretarias = (from selecao in oDB.Secretaria
                                        where selecao.IdSecretaria == idSecretarias
                                        select selecao).ToList<Secretaria>();

            return oSecretarias;

        }

        public static bool Atualiza(Secretaria pSecretariar) {
            try {
                RecepcaoDataClassesDataContext oDB = new RecepcaoDataClassesDataContext();
                Secretaria oSecretaria = (from selecao in oDB.Secretaria
                                     where selecao.IdSecretaria == pSecretariar.IdSecretaria
                                select selecao).SingleOrDefault();
                oSecretaria.IdSecretaria = pSecretariar.IdSecretaria;

                oDB.SubmitChanges();
                oDB.Dispose();

                return true;
            } catch (Exception) {
                return false;
            }
        }
    }
}
