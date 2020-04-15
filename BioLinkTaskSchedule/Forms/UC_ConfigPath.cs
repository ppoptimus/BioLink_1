using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioLinkTaskSchedule.Forms
{
    public partial class UC_ConfigPath : UserControl
    {
        private static UC_ConfigPath _instance;
        public static UC_ConfigPath Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_ConfigPath();
                return _instance;
            }
        }
        public UC_ConfigPath()
        {
            InitializeComponent();
        }
    }
}
