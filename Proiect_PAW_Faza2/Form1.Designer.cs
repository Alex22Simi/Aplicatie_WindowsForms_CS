namespace ProiectPAW_Faza1
{
    partial class FormularMagazin
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
            this.tbNume = new System.Windows.Forms.TextBox();
            this.lbNume = new System.Windows.Forms.Label();
            this.lbNrA = new System.Windows.Forms.Label();
            this.tbNrA = new System.Windows.Forms.TextBox();
            this.lbNrR = new System.Windows.Forms.Label();
            this.tbNrR = new System.Windows.Forms.TextBox();
            this.lbD = new System.Windows.Forms.Label();
            this.tbD = new System.Windows.Forms.TextBox();
            this.btAdaugaM = new System.Windows.Forms.Button();
            this.tbMagazine = new System.Windows.Forms.TextBox();
            this.btnAfiseazaMagazine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNumeLI = new System.Windows.Forms.TextBox();
            this.tbParola = new System.Windows.Forms.TextBox();
            this.btAutentificare = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.afisareDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(417, 356);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(166, 22);
            this.tbNume.TabIndex = 0;
            this.tbNume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNume_KeyPress);
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.Location = new System.Drawing.Point(209, 362);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(100, 16);
            this.lbNume.TabIndex = 1;
            this.lbNume.Text = "Nume magazin:";
            // 
            // lbNrA
            // 
            this.lbNrA.AutoSize = true;
            this.lbNrA.Location = new System.Drawing.Point(209, 399);
            this.lbNrA.Name = "lbNrA";
            this.lbNrA.Size = new System.Drawing.Size(101, 16);
            this.lbNrA.TabIndex = 2;
            this.lbNrA.Text = "Număr angajați:";
            // 
            // tbNrA
            // 
            this.tbNrA.Location = new System.Drawing.Point(417, 393);
            this.tbNrA.Name = "tbNrA";
            this.tbNrA.Size = new System.Drawing.Size(166, 22);
            this.tbNrA.TabIndex = 3;
            this.tbNrA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNrA_KeyDown);
            this.tbNrA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNrA_KeyPress);
            // 
            // lbNrR
            // 
            this.lbNrR.AutoSize = true;
            this.lbNrR.Location = new System.Drawing.Point(209, 434);
            this.lbNrR.Name = "lbNrR";
            this.lbNrR.Size = new System.Drawing.Size(118, 16);
            this.lbNrR.TabIndex = 4;
            this.lbNrR.Text = "Număr de raioane:";
            // 
            // tbNrR
            // 
            this.tbNrR.Location = new System.Drawing.Point(417, 434);
            this.tbNrR.Name = "tbNrR";
            this.tbNrR.Size = new System.Drawing.Size(166, 22);
            this.tbNrR.TabIndex = 5;
            this.tbNrR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNrR_KeyDown);
            this.tbNrR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNrR_KeyPress);
            // 
            // lbD
            // 
            this.lbD.AutoSize = true;
            this.lbD.Location = new System.Drawing.Point(209, 472);
            this.lbD.Name = "lbD";
            this.lbD.Size = new System.Drawing.Size(113, 16);
            this.lbD.TabIndex = 6;
            this.lbD.Text = "Nume distribuitori:";
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(417, 469);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(166, 22);
            this.tbD.TabIndex = 7;
            this.tbD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbD_KeyPress);
            // 
            // btAdaugaM
            // 
            this.btAdaugaM.Location = new System.Drawing.Point(225, 541);
            this.btAdaugaM.Name = "btAdaugaM";
            this.btAdaugaM.Size = new System.Drawing.Size(332, 57);
            this.btAdaugaM.TabIndex = 8;
            this.btAdaugaM.Text = "Adaugă magazin";
            this.btAdaugaM.UseVisualStyleBackColor = true;
            this.btAdaugaM.Click += new System.EventHandler(this.btAdaugaM_Click);
            // 
            // tbMagazine
            // 
            this.tbMagazine.Location = new System.Drawing.Point(733, 356);
            this.tbMagazine.Multiline = true;
            this.tbMagazine.Name = "tbMagazine";
            this.tbMagazine.Size = new System.Drawing.Size(393, 135);
            this.tbMagazine.TabIndex = 9;
            // 
            // btnAfiseazaMagazine
            // 
            this.btnAfiseazaMagazine.Location = new System.Drawing.Point(721, 541);
            this.btnAfiseazaMagazine.Name = "btnAfiseazaMagazine";
            this.btnAfiseazaMagazine.Size = new System.Drawing.Size(393, 57);
            this.btnAfiseazaMagazine.TabIndex = 10;
            this.btnAfiseazaMagazine.Text = "Afișează magazine";
            this.btnAfiseazaMagazine.UseVisualStyleBackColor = true;
            this.btnAfiseazaMagazine.Click += new System.EventHandler(this.btnAfiseazaMagazine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(447, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Conectare angajat magazin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nume utilizator:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Parolă:";
            // 
            // tbNumeLI
            // 
            this.tbNumeLI.Location = new System.Drawing.Point(636, 73);
            this.tbNumeLI.Name = "tbNumeLI";
            this.tbNumeLI.Size = new System.Drawing.Size(156, 22);
            this.tbNumeLI.TabIndex = 16;
            this.tbNumeLI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeLI_KeyPress);
            // 
            // tbParola
            // 
            this.tbParola.Location = new System.Drawing.Point(636, 109);
            this.tbParola.Name = "tbParola";
            this.tbParola.Size = new System.Drawing.Size(156, 22);
            this.tbParola.TabIndex = 17;
            // 
            // btAutentificare
            // 
            this.btAutentificare.Location = new System.Drawing.Point(441, 151);
            this.btAutentificare.Name = "btAutentificare";
            this.btAutentificare.Size = new System.Drawing.Size(351, 34);
            this.btAutentificare.TabIndex = 18;
            this.btAutentificare.Text = "Log in";
            this.btAutentificare.UseVisualStyleBackColor = true;
            this.btAutentificare.Click += new System.EventHandler(this.btAutentificare_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.afisareDateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1275, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tXTToolStripMenuItem,
            this.bINToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tXTToolStripMenuItem
            // 
            this.tXTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem,
            this.restaurareToolStripMenuItem});
            this.tXTToolStripMenuItem.Name = "tXTToolStripMenuItem";
            this.tXTToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.tXTToolStripMenuItem.Text = "TXT";
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.salvareToolStripMenuItem.Text = "Salvare";
            this.salvareToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click);
            // 
            // restaurareToolStripMenuItem
            // 
            this.restaurareToolStripMenuItem.Name = "restaurareToolStripMenuItem";
            this.restaurareToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.restaurareToolStripMenuItem.Text = "Restaurare";
            this.restaurareToolStripMenuItem.Click += new System.EventHandler(this.restaurareToolStripMenuItem_Click);
            // 
            // bINToolStripMenuItem
            // 
            this.bINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem1,
            this.restaurareToolStripMenuItem1});
            this.bINToolStripMenuItem.Name = "bINToolStripMenuItem";
            this.bINToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.bINToolStripMenuItem.Text = "BIN";
            // 
            // salvareToolStripMenuItem1
            // 
            this.salvareToolStripMenuItem1.Name = "salvareToolStripMenuItem1";
            this.salvareToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.salvareToolStripMenuItem1.Text = "Salvare";
            this.salvareToolStripMenuItem1.Click += new System.EventHandler(this.salvareToolStripMenuItem1_Click);
            // 
            // restaurareToolStripMenuItem1
            // 
            this.restaurareToolStripMenuItem1.Name = "restaurareToolStripMenuItem1";
            this.restaurareToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.restaurareToolStripMenuItem1.Text = "Restaurare";
            this.restaurareToolStripMenuItem1.Click += new System.EventHandler(this.restaurareToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // afisareDateToolStripMenuItem
            // 
            this.afisareDateToolStripMenuItem.Name = "afisareDateToolStripMenuItem";
            this.afisareDateToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.afisareDateToolStripMenuItem.Text = "Afisare Date";
            this.afisareDateToolStripMenuItem.Click += new System.EventHandler(this.afisareDateToolStripMenuItem_Click);
            // 
            // FormularMagazin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::ProiectPAW_Faza1.Properties.Resources.shopping_2613984_12801;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1275, 610);
            this.Controls.Add(this.btAutentificare);
            this.Controls.Add(this.tbParola);
            this.Controls.Add(this.tbNumeLI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAfiseazaMagazine);
            this.Controls.Add(this.tbMagazine);
            this.Controls.Add(this.btAdaugaM);
            this.Controls.Add(this.tbD);
            this.Controls.Add(this.lbD);
            this.Controls.Add(this.tbNrR);
            this.Controls.Add(this.lbNrR);
            this.Controls.Add(this.tbNrA);
            this.Controls.Add(this.lbNrA);
            this.Controls.Add(this.lbNume);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularMagazin";
            this.Text = "Formular Magazin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label lbNume;
        private System.Windows.Forms.Label lbNrA;
        private System.Windows.Forms.TextBox tbNrA;
        private System.Windows.Forms.Label lbNrR;
        private System.Windows.Forms.TextBox tbNrR;
        private System.Windows.Forms.Label lbD;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.Button btAdaugaM;
        private System.Windows.Forms.TextBox tbMagazine;
        private System.Windows.Forms.Button btnAfiseazaMagazine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNumeLI;
        private System.Windows.Forms.TextBox tbParola;
        private System.Windows.Forms.Button btAutentificare;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restaurareToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem afisareDateToolStripMenuItem;
    }
}

