using System;
using System.Windows.Forms;
using RecepcaoControle;
using RecepcaoDados;

namespace RecepcaoApresentacao {
    public partial class TelaPrincipal : Form {
        public TelaPrincipal() {
            InitializeComponent();
            AcceptButton = BtnPesquisar;
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

    }
}
