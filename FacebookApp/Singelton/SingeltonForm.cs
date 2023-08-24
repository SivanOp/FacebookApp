using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using FacebookWinFormApp.Singelton;

namespace FacebookWinFormApp.Singelton
{
    public sealed class SingeltonForm : MainForm
    {
        private SingeltonForm()
        {
        }
    }
}
