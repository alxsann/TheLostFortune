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
    public partial class ConfirmCharacterName : Form
    {
        CharacterCreation characterCreationForm;

        public ConfirmCharacterName(CharacterCreation characterCreationForm)
        {
            InitializeComponent();
            this.characterCreationForm = characterCreationForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MainForm game = new MainForm();
            game.Show();
            characterCreationForm.Hide();
            this.Close();
        }
    }
}
