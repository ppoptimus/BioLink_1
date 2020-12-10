using BioLinkTaskSchedule.Models;

namespace BioLinkTaskSchedule.Commands
{
    public class BindTextHelper
    {
        BindTextModel bindTextModel = new BindTextModel();

        public BindTextHelper() { }
        public BindTextHelper(string ipServer, string port, string ftpPath, string userName, string passWord)
        {
            bindTextModel.ipServer = ipServer;
            bindTextModel.port = port;
            bindTextModel.ftpPath = ftpPath;
            bindTextModel.userName = userName;
            bindTextModel.passWord = passWord;
        }
    }
}
