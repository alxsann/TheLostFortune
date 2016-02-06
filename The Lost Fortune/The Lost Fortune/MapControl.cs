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
            switch(mapId)
            {
                case 1:
                    BackgroundImage = Properties.Resources.TheDesertsMap;
                    lblMap.Text = "The Deserts";
                    break;
                case 2:
                    lblMap.Text = "The Forgotten Forest";
                    break;
                case 3:
                    lblMap.Text = "The Casves";
                    break;
                case 4:
                    lblMap.Text = "Necropolis";
                    break;
                case 5:
                    lblMap.Text = "Eternal Depths";
                    break;
                case 6:
                    lblMap.Text = "The Frozen Hills";
                    break;
                case 7:
                    lblMap.Text = "World of the Void";
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
