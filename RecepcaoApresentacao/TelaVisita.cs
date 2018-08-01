using RecepcaoControle;
using RecepcaoDados;
using System;
using System.Windows.Forms;

namespace RecepcaoApresentacao {
    public partial class TelaVisita : Form {

        public TelaVisita(string nome, string cpf, string rg, string rne) {
            InitializeComponent();
            TxtNome.Text = nome;
            TxtCPF.Text = cpf;
            TxtRG.Text = rg;
            TxtRNE.Text = rne;
            AcceptButton = BtnPesquisar;
            SecretariaCbBox();
            TravaCampos();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e) {
            Visitante visitante = new Visitante();

            try {
                // if (VisitanteController.ValidarCampoBusca(TxtNome, TxtCPF, TxtRG, TxtRNE, errorProvider1)) {
                if (!String.IsNullOrEmpty(TxtCPF.Text))
                    visitante = VisitanteController.ConsultaVisitanteCPF(TxtCPF.Text);
                else if (!String.IsNullOrEmpty(TxtNome.Text))
                    visitante = VisitanteController.ConsultaVisitante(TxtNome.Text);

                if (visitante != null) {

                    TxtNome.Text = visitante.Nome.Trim();
                    TxtCPF.Text = visitante.CPF.ToString();
                    TxtRG.Text = visitante.RG.ToString();
                    TxtRNE.Text = visitante.RNE.ToString();
                }
                // }
            } catch (Exception) {

            }
        }

        private void SecretariaCbBox() {
            CbxSecretaria.Items.Add("Administração e RH");
            CbxSecretaria.Items.Add("Assistência Social");
            CbxSecretaria.Items.Add("Desenvolvimento Econômico");
            CbxSecretaria.Items.Add("Educação");
            CbxSecretaria.Items.Add("Esportes e Recreação");
            CbxSecretaria.Items.Add("Finanças");
            CbxSecretaria.Items.Add("Gabinete do Prefeito");
            CbxSecretaria.Items.Add("Governo");
            CbxSecretaria.Items.Add("Infreaestrutura");
            CbxSecretaria.Items.Add("Meio Ambiente");
            CbxSecretaria.Items.Add("Mobilidade Urbana");
            CbxSecretaria.Items.Add("Planejamento");
            CbxSecretaria.Items.Add("Procuradoria Geral");
            CbxSecretaria.Items.Add("Saúde");
            CbxSecretaria.Items.Add("Segurança e Defesa do Cidadão");
            CbxSecretaria.Items.Add("Fundação Cultural de Jacareí");
            CbxSecretaria.Items.Add("Fundação ProLar");
            CbxSecretaria.Items.Add("IPMJ");
            CbxSecretaria.Items.Add("SAAE");
            CbxSecretaria.Items.Add("SRJ");
        }

        private void TravaCampos() {
            TxtNome.Enabled = false;
            TxtCPF.Enabled = false;
            TxtRG.Enabled = false;
            TxtRNE.Enabled = false;
        }

    }
}
