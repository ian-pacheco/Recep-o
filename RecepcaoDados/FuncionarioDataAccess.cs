using System;
using System.Collections.Generic;
using System.Linq;

namespace RecepcaoDados {
    public class FuncionarioDataAccess : Funcionario {

        //Insere funcionario na tabela Funcionario
        public static bool Criar(Funcionario NovoFuncionario) {

            try {
                RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
                Db.Funcionario.InsertOnSubmit(NovoFuncionario);
                Db.SubmitChanges();
                Db.Dispose();

                return true;
            } catch (Exception) {
                return false;
            }
        }

        //Insere uma lista de funcionarios na tabela Funcionario
        public static bool Criar(List<Funcionario> funcionario) {

            try {
                RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
                Db.Funcionario.InsertAllOnSubmit(funcionario);
                Db.SubmitChanges();
                Db.Dispose();

                return true;
            } catch (Exception) {
                return false;
            }
        }

        //Deleta funcionario na tabela Funcionario
        public static bool Deleta(Funcionario funcionario) {

            try {
                RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
                Db.Funcionario.DeleteOnSubmit(funcionario);
                Db.SubmitChanges();
                Db.Dispose();

                return true;
            } catch (Exception) {
                return false;
            }
        }

        //Deleta uma lista de funcionarios na tabela Funcionario
        public static bool Deleta(List<Funcionario> funcionario) {

            try {
                RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
                Db.Funcionario.DeleteAllOnSubmit(funcionario);
                Db.SubmitChanges();
                Db.Dispose();

                return true;
            } catch (Exception) {
                return false;
            }
        }

        //Deleta funcionario utilizando id, na tabela Funcionario
        public static bool Deleta(int idfuncionario) {

            try {
                RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
                Funcionario ifuncionario = (from selecao in Db.Funcionario where selecao.IdFuncionario == idfuncionario select selecao).SingleOrDefault();

                Db.Funcionario.DeleteOnSubmit(ifuncionario);
                Db.SubmitChanges();
                Db.Dispose();

                return true;
            } catch (Exception) {
                return false;
            }
        }

        //Consulta funcionario na tabela Funcionario
        public static Funcionario ConsultaFuncionario(int idfuncionario) {

            RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
            Funcionario ifuncionario = (from selecao in Db.Funcionario where selecao.IdFuncionario == idfuncionario select selecao).SingleOrDefault();
            return ifuncionario;
        }

        //Consulta lista de funcionarios na tabela Funcionario
        public static List<Funcionario> ConsultaFuncionario() {

            RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
            List<Funcionario> ifuncionario = (from selecao in Db.Funcionario
                                              orderby selecao.Nome
                                              select selecao).ToList();
            return ifuncionario;
        }

        //Atualizar funcionario utilizando id, na tabela Funcionario
        public static bool Atualiza(Funcionario funcionario) {

            try {
                RecepcaoDataClassesDataContext Db = new RecepcaoDataClassesDataContext();
                Funcionario ifuncionario = (from selecao in Db.Funcionario
                                            where selecao.IdFuncionario == funcionario.IdFuncionario
                                            select selecao).SingleOrDefault();

                ifuncionario.Nome = funcionario.Nome;
                Db.SubmitChanges();
                Db.Dispose();

                return true;
            } catch (Exception) {
                return false;
            }
        }

        //Retorna usuario
        public static List<Funcionario> ObterLogin(string pLogin, string pSenha) {
            RecepcaoDataClassesDataContext DB = new RecepcaoDataClassesDataContext();
            List<Funcionario> oUS = (from Selecao in DB.Funcionario
                                     where Selecao.Login == pLogin && Selecao.Senha == pSenha
                                     select Selecao).ToList();
            return oUS;
        }

        //Verifica se login ja é cadastrado
        public static List<Funcionario> ConsultaLogin(string pLogin) {
            RecepcaoDataClassesDataContext DB = new RecepcaoDataClassesDataContext();
            List<Funcionario> oFuncionarios = (from Selecao in DB.Funcionario
                                               where Selecao.Login == pLogin
                                               select Selecao).ToList();
            return oFuncionarios;
        }

        /*[Required]
        [EmailAddress]
        [Display(Name = "Confirmar Email")]

        [Required]
        [StringLength]()
        [Display(Name = "Confirmar Email")]*/


    }
}
