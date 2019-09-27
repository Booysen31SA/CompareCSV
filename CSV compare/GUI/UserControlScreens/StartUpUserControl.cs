using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV_compare.GUI.UserControlScreens
{
    public partial class StartUpUserControl : UserControl
    {
        private static StartUpUserControl _instance;
        public StartUpUserControl()
        {
            InitializeComponent();
        }

        public static StartUpUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StartUpUserControl();
                }
                return _instance;
            }
        }

        private void StartUpUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
