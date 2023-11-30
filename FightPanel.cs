using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InlämningTreÄventyret
{
    public partial class FightPanel : UserControl
    {
        public FightPanel()
        {
            InitializeComponent();
        }

        private void EndButton2_Click(object sender, EventArgs e)
        {
                Application.Exit();
            
        }
    }
}
