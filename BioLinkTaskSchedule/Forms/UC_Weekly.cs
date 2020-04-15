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
    public partial class UC_Weekly : UserControl
    {
        public static UC_Weekly _instance;
        public static UC_Weekly instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_Weekly();
                }
                return _instance;
            }
        }
        public UC_Weekly()
        {
            InitializeComponent();
        }
    }
}
