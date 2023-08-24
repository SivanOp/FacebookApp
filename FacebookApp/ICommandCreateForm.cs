using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormApp
{
    public interface ICommandCreateForm
    {
        void Execute(Panel i_Panel, User i_CurrentUser, Builder i_Builder);
    }
}
