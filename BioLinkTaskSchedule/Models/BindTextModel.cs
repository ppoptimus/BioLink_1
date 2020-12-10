using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioLinkTaskSchedule.Models
{
    public class BindTextModel
    {
        public string ipServer { get; set; }
        public string port { get; set; }
        public string ftpPath { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; }
    }
}
