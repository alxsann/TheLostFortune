using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Lost_Fortune
{
    public partial class MainForm : Form
    {
        private MapControl map;

        public MainForm()
        {
            InitializeComponent();

            map = new MapControl();
            map.Visible = false;
            map.Location = new Point(204, 208);
            tabControl1.TabPages[0].Controls.Add(map);
            map.BringToFront();
        }

        private void btnLand1_Click(object sender, EventArgs e)
        {
            map.GenerateMap(1);
            map.Visible = true;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
