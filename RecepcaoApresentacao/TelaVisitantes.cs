using RecepcaoControle;
using RecepcaoDados;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RecepcaoApresentacao {
    public partial class TelaVisitantes : Form {

        public TelaVisitantes() {
            InitializeComponent();
            ttMensagem.SetToolTip(TxtNome, "Insira o nome completo da visita!");
            ttMensagem.SetToolTip(TxtCPF, "Insira o CPF, somente números!");
            ttMensagem.SetToolTip(TxtRG, "Insira o RG, somente números!");
            ttMensagem.SetToolTip(TxtRNE, "Insira o RNE, documento de estrangeiros residentes no Brasil!");
            ttMensagem.SetToolTip(TxtIdade, "Insira a idade!");
            ttMensagem.SetToolTip(TxtLogradouro, "Insira o endereço com o número separado por vírgula!");
            ttMensagem.SetToolTip(BtnPesquisar, "Insira Nome, CPF, RG ou RNE para realizar a pesquisa!\nApenas um dos campos é necessário para a busca!");
            ttMensagem.SetToolTip(ChbEstrangeiro, "Marque este campo caso o visitante seja estrangeiro!");
            AcceptButton = BtnPesquisar;
            HabilitarLoad();
        }

        private int idVisitante = 0;

        private void BtnPesquisar_Click(object sender, EventArgs e) {
            //Visitante visitantes = new Visitante();
            List<Visitante> visitantes = new List<Visitante>();

           // if (VisitanteController.ValidarCampoBusca(TxtNome, TxtCPF, TxtRG, TxtRNE, errorProvider)) {
            if ((!String.IsNullOrWhiteSpace(TxtNome.Text)) || (!String.IsNullOrWhiteSpace(TxtCPF.Text)) || (!String.IsNullOrWhiteSpace(TxtRG.Text)) || (!String.IsNullOrWhiteSpace(TxtRNE.Text))) {
                if (!String.IsNullOrWhiteSpace(TxtNome.Text)) {
                    visitantes = VisitanteController.ConsultaVisitanteNome(TxtNome.Text);
                } else if (!String.IsNullOrWhiteSpace(TxtCPF.Text)) {
                    visitantes = VisitanteController.ConsultaVisitanteCPFList(TxtCPF.Text);
                } else if (!String.IsNullOrWhiteSpace(TxtRG.Text)) {
                    visitantes = VisitanteController.ConsultaVisitanteRGList(TxtRG.Text);
                } else if (!String.IsNullOrEmpty(TxtRNE.Text)) {
                    visitantes = VisitanteController.ConsultaVisitanteRNEList(TxtRNE.Text);
                }
                if (visitantes.Count != 0) {

                    DgvVisitantes.DataSource = visitantes;
                    //TravaCampos();
                    BtnCancelar.Enabled = true;
                } else {
                    var r = MessageBox.Show("Visitante não cadastrato\nDeseja cadastrar novo visitante?", "Sistema Recepção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes) {
                        btnSalvar.Enabled = true;
                        BtnPesquisar.Enabled = false;
                    }
                }
            } else {
                MessageBox.Show("Digite um valor para os campos de busca\nNome, CPF, RG ou RNE\nApenas um campo é necessário.", "Sistema Recepção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // }
        }

        private void BtnSalvar_Click(object sender, EventArgs e) {

            Visitante oNovoVisitante = new Visitante();
            oNovoVisitante.Nome = TxtNome.Text;
            oNovoVisitante.CPF = TxtCPF.Text;
            oNovoVisitante.RG = TxtRG.Text;
            oNovoVisitante.RNE = TxtRNE.Text;
            oNovoVisitante.Idade = Convert.ToByte(TxtIdade.Text);
            oNovoVisitante.Logradouro = TxtLogradouro.Text;
            oNovoVisitante.Bairro = TxtBairro.Text;
            oNovoVisitante.Cidade = TxtCidade.Text;
            oNovoVisitante.UF = TxtUF.Text;
            oNovoVisitante.Pais = TxtPais.Text;
            //NovaVisitante.Foto = TxtFoto.Text;
            if (ChbEstrangeiro.Checked)
                oNovoVisitante.Estrangeiro = true;
            else
                oNovoVisitante.Estrangeiro = false;

            try {
                List<Visitante> visitantes = new List<Visitante>();
                visitantes = VisitanteController.ConsultaVisitanteCPFList(TxtCPF.Text);

                if (visitantes.Count == 0) {
                    VisitanteController.CadastrarVisitante(oNovoVisitante);
                    MessageBox.Show("Cadastro efetuado com sucesso!", "Sistema Recepção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnCancelar.Enabled = true;
                    LimpaDados();
                    DgvVisitantes.DataSource = visitantes;
                } else {
                    idVisitante = visitantes[0].IdVisitante;
                    var r = MessageBox.Show("Tem certeza que deseja efetuar alteração no cadastro?", "Sistema Recepção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes) {
                        oNovoVisitante.IdVisitante = idVisitante;
                        VisitanteController.Atualiza(oNovoVisitante);
                        MessageBox.Show("Cadastro atualizado com sucesso!", "Sistema Recepção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpaDados();
                    } else {
                        MessageBox.Show("Sem alterações de cadastro", "Sistema Recepção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            } catch (Exception) {
                MessageBox.Show("Falha no cadastro!", "Sistema Recepção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e) {
            AbreCampos();
            btnSalvar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnNovaVisita.Enabled = false;
            AcceptButton = BtnCancelar;
            CheckBoxGrid();

        }

        private void BtnExcluir_Click(object sender, EventArgs e) {
            int index = DgvVisitantes.CurrentRow.Index;
            Visitante visitante = new Visitante();
            visitante = VisitanteController.ConsultaVisitante(int.Parse(DgvVisitantes.Rows[index].Cells[0].Value.ToString()));
            if (MessageBox.Show("Deseja Realmente Excluir o Visitante?", "Excluir Usuário",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                if (VisitanteController.Deleta(visitante.IdVisitante)) {
                    MessageBox.Show("Usuário removido com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaDados();
                    DgvVisitantes.DataSource = null;
                    BtnPesquisar.Enabled = true;
                    BtnExcluir.Enabled = false;
                    BtnEditar.Enabled = false;
                    AbreCampos();
                } else {
                    MessageBox.Show("Falha ao tentar excluir usuário no banco de dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e) {
            LimpaDados();
            AbreCampos();
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnPesquisar.Enabled = true;
            btnSalvar.Enabled = false;
        }

        private void ChbEstrangeiro_Click(object sender, EventArgs e) {
            if (ChbEstrangeiro.Checked == true) {
                TxtCPF.Enabled = false;
                TxtRG.Enabled = false;
                TxtRNE.Enabled = true;
            } else {
                TxtCPF.Enabled = true;
                TxtRG.Enabled = true;
                TxtRNE.Enabled = false;
            }
        }

        private void DgvVisitantes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int index = DgvVisitantes.CurrentRow.Index;
            CheckBoxGrid();
            TxtCPF.Text = DgvVisitantes.Rows[index].Cells[1].Value.ToString();
            TxtRG.Text = DgvVisitantes.Rows[index].Cells[2].Value.ToString();
            TxtRNE.Text = DgvVisitantes.Rows[index].Cells[3].Value.ToString();
            TxtNome.Text = DgvVisitantes.Rows[index].Cells[4].Value.ToString();
            TxtIdade.Text = DgvVisitantes.Rows[index].Cells[6].Value.ToString();
            TxtLogradouro.Text = DgvVisitantes.Rows[index].Cells[7].Value.ToString();
            TxtBairro.Text = DgvVisitantes.Rows[index].Cells[8].Value.ToString();
            TxtCidade.Text = DgvVisitantes.Rows[index].Cells[9].Value.ToString();
            TxtUF.Text = DgvVisitantes.Rows[index].Cells[10].Value.ToString();
            TxtPais.Text = DgvVisitantes.Rows[index].Cells[11].Value.ToString();
            TravaCampos();
            BtnEditar.Enabled = true;
            BtnExcluir.Enabled = true;
            BtnPesquisar.Enabled = false;
        }

        private void LimpaDados() {
            TxtNome.Text = String.Empty;
            ChbEstrangeiro.Checked = false;
            TxtCPF.Text = String.Empty;
            TxtRG.Text = String.Empty;
            TxtRNE.Text = String.Empty;
            TxtRNE.Enabled = false;
            TxtIdade.Text = String.Empty;
            TxtLogradouro.Text = String.Empty;
            TxtBairro.Text = String.Empty;
            TxtCidade.Text = String.Empty;
            TxtUF.Text = String.Empty;
            TxtPais.Text = String.Empty;
            BtnPesquisar.Enabled = true;
            btnSalvar.Enabled = false;
            BtnExcluir.Enabled = false;
            DgvVisitantes.DataSource = null;

        }

        private void HabilitarLoad() {
            TxtRNE.Enabled = false;
            btnSalvar.Enabled = false;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnCancelar.Enabled = false;
        }     

        private void CheckBoxGrid() {
            if (bool.Parse(DgvVisitantes.CurrentRow.Cells[5].FormattedValue.ToString()) == true) {
                ChbEstrangeiro.Checked = true;
                TxtCPF.Enabled = false;
                TxtCPF.Text = String.Empty;
                TxtRG.Enabled = false;
                TxtRG.Text = String.Empty;
                TxtRNE.Enabled = true;

            } else {
                ChbEstrangeiro.Checked = false;
                TxtCPF.Enabled = true;
                TxtRG.Enabled = true;
                TxtRNE.Enabled = false;
                TxtRNE.Text = String.Empty;
            }
        }   

        private void TravaCampos() {
            TxtNome.Enabled = false;
            TxtCPF.Enabled = false;
            TxtRG.Enabled = false;
            TxtRNE.Enabled = false;
            TxtIdade.Enabled = false;
            TxtLogradouro.Enabled = false;
            TxtBairro.Enabled = false;
            TxtCidade.Enabled = false;
            TxtUF.Enabled = false;
            TxtPais.Enabled = false;
            //TxtFotoEnabled = false;
            ChbEstrangeiro.Enabled = false;
        }

        private void AbreCampos() {
            TxtNome.Enabled = true;
            TxtCPF.Enabled = true;
            TxtRG.Enabled = true;
            TxtRNE.Enabled = true;
            TxtIdade.Enabled = true;
            TxtLogradouro.Enabled = true;
            TxtBairro.Enabled = true;
            TxtCidade.Enabled = true;
            TxtUF.Enabled = true;
            TxtPais.Enabled = true;
            ChbEstrangeiro.Enabled = true;
            //TxtFotoEnabled = true;
        }     
    }
}

