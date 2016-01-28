namespace The_Lost_Fortune
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxSkill = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnSkill = new System.Windows.Forms.Button();
            this.btnFlee = new System.Windows.Forms.Button();
            this.lblEnemyStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPlayerStatus = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 514);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblPlayerStatus);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.lblEnemyStatus);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(939, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adventure!";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFlee);
            this.groupBox1.Controls.Add(this.btnSkill);
            this.groupBox1.Controls.Add(this.btnBlock);
            this.groupBox1.Controls.Add(this.btnAttack);
            this.groupBox1.Controls.Add(this.cBoxSkill);
            this.groupBox1.Location = new System.Drawing.Point(8, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 105);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Battle options";
            // 
            // cBoxSkill
            // 
            this.cBoxSkill.FormattingEnabled = true;
            this.cBoxSkill.Location = new System.Drawing.Point(88, 35);
            this.cBoxSkill.Name = "cBoxSkill";
            this.cBoxSkill.Size = new System.Drawing.Size(121, 21);
            this.cBoxSkill.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 262);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(922, 83);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(939, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Character";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Find Fight!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(7, 20);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(75, 23);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Basic Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(7, 49);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(75, 23);
            this.btnBlock.TabIndex = 3;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            // 
            // btnSkill
            // 
            this.btnSkill.Location = new System.Drawing.Point(111, 62);
            this.btnSkill.Name = "btnSkill";
            this.btnSkill.Size = new System.Drawing.Size(75, 23);
            this.btnSkill.TabIndex = 4;
            this.btnSkill.Text = "Use skill";
            this.btnSkill.UseVisualStyleBackColor = true;
            // 
            // btnFlee
            // 
            this.btnFlee.Location = new System.Drawing.Point(7, 79);
            this.btnFlee.Name = "btnFlee";
            this.btnFlee.Size = new System.Drawing.Size(75, 23);
            this.btnFlee.TabIndex = 5;
            this.btnFlee.Text = "Flee!";
            this.btnFlee.UseVisualStyleBackColor = true;
            // 
            // lblEnemyStatus
            // 
            this.lblEnemyStatus.AutoSize = true;
            this.lblEnemyStatus.Location = new System.Drawing.Point(776, 6);
            this.lblEnemyStatus.Name = "lblEnemyStatus";
            this.lblEnemyStatus.Size = new System.Drawing.Size(92, 13);
            this.lblEnemyStatus.TabIndex = 5;
            this.lblEnemyStatus.Text = "MobName Status:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(762, 234);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblPlayerStatus
            // 
            this.lblPlayerStatus.AutoSize = true;
            this.lblPlayerStatus.Location = new System.Drawing.Point(89, 356);
            this.lblPlayerStatus.Name = "lblPlayerStatus";
            this.lblPlayerStatus.Size = new System.Drawing.Size(240, 13);
            this.lblPlayerStatus.TabIndex = 7;
            this.lblPlayerStatus.Text = "Health: Mana: Physical Damage: Magic Damage:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 510);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBoxSkill;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFlee;
        private System.Windows.Forms.Button btnSkill;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEnemyStatus;
        private System.Windows.Forms.Label lblPlayerStatus;
    }
}