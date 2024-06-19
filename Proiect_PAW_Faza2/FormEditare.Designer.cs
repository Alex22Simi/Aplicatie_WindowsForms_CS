namespace ProiectPAW_Faza1
{
    partial class FormEditare
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
            this.tbNume2 = new System.Windows.Forms.TextBox();
            this.tbNrA2 = new System.Windows.Forms.TextBox();
            this.tbNrR2 = new System.Windows.Forms.TextBox();
            this.tbD2 = new System.Windows.Forms.TextBox();
            this.Nume = new System.Windows.Forms.Label();
            this.lbNrA2 = new System.Windows.Forms.Label();
            this.lbNrR2 = new System.Windows.Forms.Label();
            this.lbD2 = new System.Windows.Forms.Label();
            this.btAdauga2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNume2
            // 
            this.tbNume2.Location = new System.Drawing.Point(396, 134);
            this.tbNume2.Name = "tbNume2";
            this.tbNume2.Size = new System.Drawing.Size(150, 22);
            this.tbNume2.TabIndex = 0;
            this.tbNume2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNume_KeyPress);
            // 
            // tbNrA2
            // 
            this.tbNrA2.Location = new System.Drawing.Point(396, 171);
            this.tbNrA2.Name = "tbNrA2";
            this.tbNrA2.Size = new System.Drawing.Size(150, 22);
            this.tbNrA2.TabIndex = 1;
            this.tbNrA2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNrA_KeyDown);
            this.tbNrA2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNrA_KeyPress);
            // 
            // tbNrR2
            // 
            this.tbNrR2.Location = new System.Drawing.Point(396, 205);
            this.tbNrR2.Name = "tbNrR2";
            this.tbNrR2.Size = new System.Drawing.Size(150, 22);
            this.tbNrR2.TabIndex = 2;
            this.tbNrR2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNrR_KeyDown);
            this.tbNrR2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNrR_KeyPress);
            // 
            // tbD2
            // 
            this.tbD2.Location = new System.Drawing.Point(396, 237);
            this.tbD2.Name = "tbD2";
            this.tbD2.Size = new System.Drawing.Size(150, 22);
            this.tbD2.TabIndex = 3;
            this.tbD2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbD_KeyPress);
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.Location = new System.Drawing.Point(227, 140);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(100, 16);
            this.Nume.TabIndex = 4;
            this.Nume.Text = "Nume magazin:";
            this.Nume.Click += new System.EventHandler(this.Nume_Click);
            // 
            // lbNrA2
            // 
            this.lbNrA2.AutoSize = true;
            this.lbNrA2.Location = new System.Drawing.Point(226, 177);
            this.lbNrA2.Name = "lbNrA2";
            this.lbNrA2.Size = new System.Drawing.Size(101, 16);
            this.lbNrA2.TabIndex = 5;
            this.lbNrA2.Text = "Număr angajați:";
            // 
            // lbNrR2
            // 
            this.lbNrR2.AutoSize = true;
            this.lbNrR2.Location = new System.Drawing.Point(227, 208);
            this.lbNrR2.Name = "lbNrR2";
            this.lbNrR2.Size = new System.Drawing.Size(118, 16);
            this.lbNrR2.TabIndex = 6;
            this.lbNrR2.Text = "Număr de raioane:";
            // 
            // lbD2
            // 
            this.lbD2.AutoSize = true;
            this.lbD2.Location = new System.Drawing.Point(227, 237);
            this.lbD2.Name = "lbD2";
            this.lbD2.Size = new System.Drawing.Size(113, 16);
            this.lbD2.TabIndex = 7;
            this.lbD2.Text = "Nume distribuitori:";
            // 
            // btAdauga2
            // 
            this.btAdauga2.Location = new System.Drawing.Point(229, 287);
            this.btAdauga2.Name = "btAdauga2";
            this.btAdauga2.Size = new System.Drawing.Size(317, 51);
            this.btAdauga2.TabIndex = 8;
            this.btAdauga2.Text = "Adaugă magazin";
            this.btAdauga2.UseVisualStyleBackColor = true;
            this.btAdauga2.Click += new System.EventHandler(this.btAdauga2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Incepe editarea";
            // 
            // FormEditare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAdauga2);
            this.Controls.Add(this.lbD2);
            this.Controls.Add(this.lbNrR2);
            this.Controls.Add(this.lbNrA2);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.tbD2);
            this.Controls.Add(this.tbNrR2);
            this.Controls.Add(this.tbNrA2);
            this.Controls.Add(this.tbNume2);
            this.Name = "FormEditare";
            this.Text = "FormEditare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume2;
        private System.Windows.Forms.TextBox tbNrA2;
        private System.Windows.Forms.TextBox tbNrR2;
        private System.Windows.Forms.TextBox tbD2;
        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.Label lbNrA2;
        private System.Windows.Forms.Label lbNrR2;
        private System.Windows.Forms.Label lbD2;
        private System.Windows.Forms.Button btAdauga2;
        private System.Windows.Forms.Label label1;
    }
}