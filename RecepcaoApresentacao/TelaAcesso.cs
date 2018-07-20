using RecepcaoDados;
using RecepcaoControle;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RecepcaoApresentacao {
    public partial class TelaAcesso : Form {
        public TelaAcesso() {
            InitializeComponent();
            AcceptButton = BtnEntrar;
        }

        private void TelaAcesso_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void BtnEntrar_Click(object sender, EventArgs e) {
            string senhaDecripto;
            senhaDecripto = FuncionarioController.AcertaSenha(TxtLogin.Text, TxtSenha.Text);

            try {
                List<Funcionario> lista = FuncionarioDataAccess.ObterLogin(TxtLogin.Text, senhaDecripto);
                if (lista.Count != 0) {
                    MessageBox.Show("Bem vindo ao Sistema Recepção", "Prefeitura de Jacareí", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (lista.Count == 0) {
                    MessageBox.Show("Usuário ou senha incorretos", "Prefeitura de Jacareí", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtLogin.Text = "";
                    TxtSenha.Text = "";
                    TxtLogin.Focus();
                }
            } catch (Exception) {
                throw;
            }

        }

        private void TxtSenha_TextChanged(object sender, EventArgs e) {

        }

        private void TxtLogin_TextChanged(object sender, EventArgs e) {

        }

        private void BtnPrimeiroAcesso_Click(object sender, EventArgs e) {
            TelaCadastroFuncionario funcionario = new TelaCadastroFuncionario();
            funcionario.ShowDialog();
        }
    }
}
