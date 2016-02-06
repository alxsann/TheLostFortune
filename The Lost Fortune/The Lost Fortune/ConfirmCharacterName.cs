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

        private int classID;
        public ConfirmCharacterName(CharacterCreation characterCreationForm, int classID)
        {
            InitializeComponent();
            this.characterCreationForm = characterCreationForm;
            this.classID = classID;
        }

        private void btnCreateCharacter_click(object sender, EventArgs ee)
        {
         
            if (txtCharacterNameField.Text != "")
            {
                
                List<object> Character = new List<object>();
                Character.Add(txtCharacterNameField.Text);
                Character.Add(100); // Gold
                Character.Add(1); // Level
                if (classID == 1)
                {
                    Character.Add(ClassStats.Warrior[0]);
                    Character.Add(ClassStats.Warrior[1]);
                    Character.Add(ClassStats.Warrior[2]);
                    Character.Add(ClassStats.Warrior[3]);
                    Character.Add(ClassStats.Warrior[4]);
                    Character.Add(ClassStats.Warrior[5]);

                    
                }
                else if (classID == 2) {
                    Character.Add(ClassStats.Mage[0]);
                    Character.Add(ClassStats.Mage[1]);
                    Character.Add(ClassStats.Mage[2]);
                    Character.Add(ClassStats.Mage[3]);
                    Character.Add(ClassStats.Mage[4]);
                    Character.Add(ClassStats.Mage[5]);
                }
                else if (classID == 3) {
                    Character.Add(ClassStats.Hunter[0]);
                    Character.Add(ClassStats.Hunter[1]);
                    Character.Add(ClassStats.Hunter[2]);
                    Character.Add(ClassStats.Hunter[3]);
                    Character.Add(ClassStats.Hunter[4]);
                    Character.Add(ClassStats.Hunter[5]);
                }
                Iostreamer.SaveToFile(Character);
                MainForm game = new MainForm();
                game.Show();
                characterCreationForm.Hide();
                this.Close();
            }

        }

    }
}
