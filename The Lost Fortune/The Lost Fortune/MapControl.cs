using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Lost_Fortune
{
    public partial class MapControl : UserControl
    {
        public MapControl()
        {
            InitializeComponent();
        }

        public void GenerateMap(int mapId)
        {
            if (mapId == 1)
                BackgroundImage = Properties.Resources.TheDesertsBackground;
            else if (mapId == 2)
                BackgroundImage = Properties.Resources.TheForgottenForestBackground;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
