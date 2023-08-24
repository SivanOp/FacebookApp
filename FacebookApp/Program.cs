using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWinFormApp.Singelton;

// $G$ RUL-999 (-20) The program is not exception proof.
// $G$ THE-001 (-7) grade 93 on patterns selection / accuracy in implementation / description / document / diagrams (50%) (see comments in document)

namespace FacebookWinFormApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(SingletonT<SingeltonForm>.Instance);
        }
    }
}
