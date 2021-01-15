namespace Drukspillet___Asbjørn_og_Tobias
{
    partial class SpilSide
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpilSide));
            this.playersTurn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDrik = new System.Windows.Forms.Button();
            this.Scoreboard = new System.Windows.Forms.Label();
            this.btnKonsekvens = new System.Windows.Forms.Button();
            this.spørgsmål = new System.Windows.Forms.Label();
            this.Player1Scoreboard = new System.Windows.Forms.Label();
            this.Player2Scoreboard = new System.Windows.Forms.Label();
            this.beerIcon = new System.Windows.Forms.PictureBox();
            this.beerIcon2 = new System.Windows.Forms.PictureBox();
            this.panelØl = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beerIcon2)).BeginInit();
            this.SuspendLayout();
            // 
            // playersTurn
            // 
            this.playersTurn.AutoSize = true;
            this.playersTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersTurn.Location = new System.Drawing.Point(287, 15);
            this.playersTurn.Name = "playersTurn";
            this.playersTurn.Size = new System.Drawing.Size(170, 37);
            this.playersTurn.TabIndex = 0;
            this.playersTurn.Text = "\"En spiller\"";
            this.playersTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playersTurn.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.spørgsmål);
            this.panel1.Controls.Add(this.playersTurn);
            this.panel1.Location = new System.Drawing.Point(42, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 517);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(200)))));
            this.panel2.Controls.Add(this.beerIcon);
            this.panel2.Controls.Add(this.panelØl);
            this.panel2.Controls.Add(this.beerIcon2);
            this.panel2.Controls.Add(this.Player2Scoreboard);
            this.panel2.Controls.Add(this.Player1Scoreboard);
            this.panel2.Controls.Add(this.Scoreboard);
            this.panel2.Location = new System.Drawing.Point(889, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 517);
            this.panel2.TabIndex = 1;
            // 
            // btnDrik
            // 
            this.btnDrik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(255)))));
            this.btnDrik.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrik.Location = new System.Drawing.Point(81, 596);
            this.btnDrik.Name = "btnDrik";
            this.btnDrik.Size = new System.Drawing.Size(345, 78);
            this.btnDrik.TabIndex = 2;
            this.btnDrik.Text = "DRIK!";
            this.btnDrik.UseVisualStyleBackColor = false;
            // 
            // Scoreboard
            // 
            this.Scoreboard.AutoSize = true;
            this.Scoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scoreboard.Location = new System.Drawing.Point(83, 15);
            this.Scoreboard.Name = "Scoreboard";
            this.Scoreboard.Size = new System.Drawing.Size(183, 37);
            this.Scoreboard.TabIndex = 0;
            this.Scoreboard.Text = "Scoreboard";
            this.Scoreboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Scoreboard.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnKonsekvens
            // 
            this.btnKonsekvens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(255)))));
            this.btnKonsekvens.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKonsekvens.Location = new System.Drawing.Point(457, 596);
            this.btnKonsekvens.Name = "btnKonsekvens";
            this.btnKonsekvens.Size = new System.Drawing.Size(345, 78);
            this.btnKonsekvens.TabIndex = 2;
            this.btnKonsekvens.Text = "KONSEKVENS!";
            this.btnKonsekvens.UseVisualStyleBackColor = false;
            this.btnKonsekvens.Click += new System.EventHandler(this.button2_Click);
            // 
            // spørgsmål
            // 
            this.spørgsmål.AutoSize = true;
            this.spørgsmål.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spørgsmål.Location = new System.Drawing.Point(221, 192);
            this.spørgsmål.Name = "spørgsmål";
            this.spørgsmål.Size = new System.Drawing.Size(305, 87);
            this.spørgsmål.TabIndex = 1;
            this.spørgsmål.Text = "Drik vand fra toilettet\r\n...\r\nEller drik 10 tåre";
            this.spørgsmål.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player1Scoreboard
            // 
            this.Player1Scoreboard.AutoSize = true;
            this.Player1Scoreboard.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Scoreboard.Location = new System.Drawing.Point(24, 84);
            this.Player1Scoreboard.Name = "Player1Scoreboard";
            this.Player1Scoreboard.Size = new System.Drawing.Size(74, 18);
            this.Player1Scoreboard.TabIndex = 1;
            this.Player1Scoreboard.Text = "spiller 1";
            // 
            // Player2Scoreboard
            // 
            this.Player2Scoreboard.AutoSize = true;
            this.Player2Scoreboard.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Scoreboard.Location = new System.Drawing.Point(24, 169);
            this.Player2Scoreboard.Name = "Player2Scoreboard";
            this.Player2Scoreboard.Size = new System.Drawing.Size(74, 18);
            this.Player2Scoreboard.TabIndex = 1;
            this.Player2Scoreboard.Text = "spiller 2";
            // 
            // beerIcon
            // 
            this.beerIcon.BackColor = System.Drawing.Color.Transparent;
            this.beerIcon.Image = ((System.Drawing.Image)(resources.GetObject("beerIcon.Image")));
            this.beerIcon.Location = new System.Drawing.Point(267, 41);
            this.beerIcon.Name = "beerIcon";
            this.beerIcon.Size = new System.Drawing.Size(79, 75);
            this.beerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.beerIcon.TabIndex = 2;
            this.beerIcon.TabStop = false;
            this.beerIcon.Click += new System.EventHandler(this.beerIcon_Click);
            // 
            // beerIcon2
            // 
            this.beerIcon2.Image = ((System.Drawing.Image)(resources.GetObject("beerIcon2.Image")));
            this.beerIcon2.Location = new System.Drawing.Point(264, 136);
            this.beerIcon2.Name = "beerIcon2";
            this.beerIcon2.Size = new System.Drawing.Size(79, 75);
            this.beerIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.beerIcon2.TabIndex = 2;
            this.beerIcon2.TabStop = false;
            // 
            // panelØl
            // 
            this.panelØl.BackColor = System.Drawing.Color.Gold;
            this.panelØl.Location = new System.Drawing.Point(277, 84);
            this.panelØl.Name = "panelØl";
            this.panelØl.Size = new System.Drawing.Size(34, 35);
            this.panelØl.TabIndex = 3;
            // 
            // SpilSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.btnKonsekvens);
            this.Controls.Add(this.btnDrik);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SpilSide";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.SpilSide_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beerIcon2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label playersTurn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDrik;
        private System.Windows.Forms.Label Scoreboard;
        private System.Windows.Forms.Button btnKonsekvens;
        private System.Windows.Forms.Label spørgsmål;
        private System.Windows.Forms.PictureBox beerIcon2;
        private System.Windows.Forms.PictureBox beerIcon;
        private System.Windows.Forms.Label Player2Scoreboard;
        private System.Windows.Forms.Label Player1Scoreboard;
        private System.Windows.Forms.Panel panelØl;
    }
}
