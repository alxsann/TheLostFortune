using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        private void btnCreateCharacter_click(object sender, EventArgs ee)
        {
            if (CharacterNameField.Text != "")
            {
                MainForm game = new MainForm();
                game.Show();
                characterCreationForm.Hide();
                this.Close();
            }
        }
        private void CharacterNameField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
