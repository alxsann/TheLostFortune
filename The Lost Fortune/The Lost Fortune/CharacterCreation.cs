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
    
    public partial class CharacterCreation : Form

    {
        // Den valgte class får forskellige attributter
        private int ClassID;
        
        public CharacterCreation()
        {
            InitializeComponent();
                 
        }

        private void btnMage_Click(object sender, EventArgs e)
        {
            ClassID = 2;
            ButtonToggleVisibility();
            lblDesc.Text = "Excellent choice";
            lblDesc.Text = "The Mage is a ranged spell caster, who excells at dealing damage with magic powers \r\n "
                + "\r\n The mage starts with the following base stats: \r\n 100 Health \r\n 120 Mana \r\n 5 Magic Damage"
                + "\r\n \r\n  The Mage has 3 different abilities:" 
                + "\r\n - Frostbolt is a ranged frozen bolt, that is fired at the opponent, dealing x Damage"
                + "\r\n - Fireball is a ranged fiery bolt, that is fired at the opponent dealing x Damage"
                + " \r\n - Iceblock - A protective icebubble is cast, making the caster invurnable to the opponent next attack"
                + " \r\n Iceblock also deals x dmg when being attacked, while iceblocked. Iceblock lasts 2 rounds";
                
            
        }

        private void btnWarrior_Click(object sender, EventArgs e)
        {
            ClassID = 1;
            ButtonToggleVisibility();
            lblDesc.Text = "The warrior is a trendmenous fighter, who is capable of wielding even the heaviest weapons found on the battlefield. He does not hestiate in battle and will fight to the end, even if death seems near   \r\n"
                + "\r\n The Warrior starts with the following base stats: \r\n 120 Health \r\n 100 Mana \r\n 5 Physical Damage"
                + "\r\n \r\n The Warrior has 3 different abilities:"
                + "\r\n - Mortal strike, a fierce strike, that strikes an enemy and makes the target unable to cast immune spells for 1 round"
                + "\r\n - Rend is a ranged fiery bolt, that is fired at the opponent dealing x Damage"
                + "\r\n - Charge, a attack so quick that the opponent cannot block";
        }

        private void btnHunter_Click(object sender, EventArgs e)
        {
            ClassID = 3;
            ButtonToggleVisibility();
            lblDesc.Text = "The hunter is a fierceful agile killer, who can wield ranged weapons and shoot them with great accuracy and overwhelming speed. His agility makes him able to dodge incoming attacks. \r\n"
                + "\r\n The Hunter starts with the following base stats: \r\n 100 Health \r\n 120 Mana \r\n 5 Physical Damage"
                + "\r\n \r\n The Hunter has 3 different abilities:"
                + "\r\n Quickshot, fires of 3 quick successive arrows dealing 50% attack damage per hit"
                + "\r\n Arcane bolt, enhances the arrow with arcana dealing bonus damage"
                + "\r\n Concussiveshot, makes your opponent unable to attack in his next turn";  
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ButtonToggleVisibility();
            lblDesc.Text = "Each class has a numerous of different abilities and talents, which will help you as you progress.";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ConfirmCharacterName cForm = new ConfirmCharacterName(this, ClassID );
            cForm.Show();
        }

        private void ButtonToggleVisibility()
        {
            btnHunter.Visible = !btnHunter.Visible;
            btnWarrior.Visible = !btnWarrior.Visible;
            btnMage.Visible = !btnMage.Visible;
            btnBack.Visible = !btnBack.Visible;
            btnConfirm.Visible = !btnConfirm.Visible;
            lblChooseC.Visible = !lblChooseC.Visible;
            lblExcellent.Visible = !lblExcellent.Visible;
        }
    }
}
