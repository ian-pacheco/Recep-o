﻿using RecepcaoApresentacao;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Recepcao
{
    static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new TelaAcesso());
            //Application.Run(new TelaCadastroFuncionario());
            Application.Run(new TelaVisitantes());
            //Application.Run(new TelaVisita());
        }
    }
}
