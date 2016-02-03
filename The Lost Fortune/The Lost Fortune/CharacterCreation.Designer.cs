namespace The_Lost_Fortune
{
    partial class CharacterCreation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterCreation));
            this.btnMage = new System.Windows.Forms.Button();
            this.btnWarrior = new System.Windows.Forms.Button();
            this.btnHunter = new System.Windows.Forms.Button();
            this.lblChooseC = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblExcellent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMage
            // 
            this.btnMage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMage.BackgroundImage")));
            this.btnMage.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnMage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMage.Location = new System.Drawing.Point(129, 154);
            this.btnMage.Name = "btnMage";
            this.btnMage.Size = new System.Drawing.Size(279, 285);
            this.btnMage.TabIndex = 0;
            this.btnMage.Text = "Mage";
            this.btnMage.UseVisualStyleBackColor = true;
            this.btnMage.Click += new System.EventHandler(this.btnMage_Click);
            // 
            // btnWarrior
            // 
            this.btnWarrior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWarrior.BackgroundImage")));
            this.btnWarrior.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnWarrior.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnWarrior.Location = new System.Drawing.Point(414, 154);
            this.btnWarrior.Name = "btnWarrior";
            this.btnWarrior.Size = new System.Drawing.Size(259, 285);
            this.btnWarrior.TabIndex = 1;
            this.btnWarrior.Text = "Warrior";
            this.btnWarrior.UseVisualStyleBackColor = true;
            this.btnWarrior.Click += new System.EventHandler(this.btnWarrior_Click);
            // 
            // btnHunter
            // 
            this.btnHunter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHunter.BackgroundImage")));
            this.btnHunter.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHunter.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnHunter.Location = new System.Drawing.Point(679, 154);
            this.btnHunter.Name = "btnHunter";
            this.btnHunter.Size = new System.Drawing.Size(259, 285);
            this.btnHunter.TabIndex = 2;
            this.btnHunter.Text = "Hunter";
            this.btnHunter.UseVisualStyleBackColor = true;
            this.btnHunter.Click += new System.EventHandler(this.btnHunter_Click);
            // 
            // lblChooseC
            // 
            this.lblChooseC.AutoSize = true;
            this.lblChooseC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseC.Location = new System.Drawing.Point(359, 9);
            this.lblChooseC.Name = "lblChooseC";
            this.lblChooseC.Size = new System.Drawing.Size(334, 31);
            this.lblChooseC.TabIndex = 5;
            this.lblChooseC.Text = "Choose your unique class!";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(189, 84);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(735, 25);
            this.lblDesc.TabIndex = 6;
            this.lblDesc.Text = "Each class has a numerous of different abilities, which will help you as you prog" +
    "ress.";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(536, 523);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(455, 523);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblExcellent
            // 
            this.lblExcellent.AutoSize = true;
            this.lblExcellent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcellent.Location = new System.Drawing.Point(408, 28);
            this.lblExcellent.Name = "lblExcellent";
            this.lblExcellent.Size = new System.Drawing.Size(235, 31);
            this.lblExcellent.TabIndex = 9;
            this.lblExcellent.Text = "Excellent choice!";
            this.lblExcellent.Visible = false;
            // 
            // CharacterCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1074, 569);
            this.Controls.Add(this.lblExcellent);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblChooseC);
            this.Controls.Add(this.btnHunter);
            this.Controls.Add(this.btnWarrior);
            this.Controls.Add(this.btnMage);
            this.Name = "CharacterCreation";
            this.Text = "Character Creation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMage;
        private System.Windows.Forms.Button btnWarrior;
        private System.Windows.Forms.Button btnHunter;
        private System.Windows.Forms.Label lblChooseC;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblExcellent;
    }
}

