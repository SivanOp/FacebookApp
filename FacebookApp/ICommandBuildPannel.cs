using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormApp
{
    public interface ICommandBuildPanel
    {
        void Execute(Panel i_Panel, List<object> i_UserInfo, User i_CurrentUser, Builder i_Builder);
    }
}
