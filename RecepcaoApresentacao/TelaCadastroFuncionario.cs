using System;
using System.Windows.Forms;
using RecepcaoDados;
using RecepcaoControle;
using System.Collections.Generic;

namespace RecepcaoApresentacao {
    public partial class TelaCadastroFuncionario : Form {

        List<Funcionario> ListaFuncionarios = new List<Funcionario>();

        public TelaCadastroFuncionario() {
            InitializeComponent();
            AcceptButton = BtnConfirmar;

        }

        //Botão Confirma
        private void BtnConfirmar_Click(object sender, EventArgs e) {


            //Chama método para criptografar senha
            string senhaCripto;
            senhaCripto = FuncionarioController.AcertaSenha(TxtLogin.Text, TxtConfirmarSenha.Text);

            if ((!String.IsNullOrWhiteSpace(TxtNome.Text)) && (!String.IsNullOrWhiteSpace(TxtLogin.Text)) && (!String.IsNullOrWhiteSpace(TxtSenha.Text)) && (!String.IsNullOrWhiteSpace(TxtConfirmarSenha.Text))) {
                Funcionario NovoFuncionario = new Funcionario();
                NovoFuncionario.Nome = TxtNome.Text;
                NovoFuncionario.Login = TxtLogin.Text;
                NovoFuncionario.Senha = senhaCripto;
                NovoFuncionario.Perfil = CbbPerfil.Text;

                try {
                    FuncionarioController.CadastrarFuncionario(NovoFuncionario);
                    MessageBox.Show("Cadastro efetuado com sucesso!", "Sistema Recepção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //dgvLogin.DataSource = PessoaDataAccess.PessoaDataAccess.ObterPessoas();
                    Close();
                } catch (Exception) {
                    MessageBox.Show("Falha no cadastro!", "Sistema Recepção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    throw;
                }
            } else {
                MessageBox.Show("Preencher todos os campos!", "Sistema Recepção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e) {
            Close();
        }

        private void TelaCadastroFuncionario_Load(object sender, EventArgs e) {

        }

        private void CbbPerfil_SelectedIndexChanged(object sender, EventArgs e) {
            CbbPerfil.DisplayMember = "Funcionário";
            CbbPerfil.ValueMember = "Funcionario";
        }

        //Validar email
        /*private void ValidarEmail(TextBox textBox, ErrorProvider errorProvider) {
            string email = textBox.Text;
            string modelo = "@''[\w\.-]+(\+[\w-]*)?@([\w-]+\.)+[\w-]+";

            if (System.Text.RegularExpressions.Regex.IsMatch(email, modelo)) 
                errorProvider.SetError(textBox, "");
            else
                errorProvider.SetError(textBox, "Email inválido");
        }*/

        //Verifica se login ja existe
        private void TxtLogin_Leave(object sender, EventArgs e) {
            List<Funcionario> ListaLogin = FuncionarioController.ConsultaLogin(TxtLogin.Text);

            if (ListaLogin.Count != 0) {
                MessageBox.Show("Login já existente!", "Sistema Recepção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtLogin.Text = "";
                TxtLogin.Select();
            }
        }

        //Verifica se as senhas são iguais
        private void TxtConfirmarSenha_Leave(object sender, EventArgs e) {
            if (!TxtSenha.Text.Equals(TxtConfirmarSenha.Text)) {
                MessageBox.Show("As senhas não conferem!", "Sistema Recepção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtSenha.Text = ("");
                TxtConfirmarSenha.Text = ("");
            }
        }
    }
}
