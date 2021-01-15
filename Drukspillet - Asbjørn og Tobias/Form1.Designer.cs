namespace Drukspillet___Asbjørn_og_Tobias
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.spilletsNavn = new System.Windows.Forms.Label();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.btnMSpiller1 = new System.Windows.Forms.Button();
            this.btnFSpiller1 = new System.Windows.Forms.Button();
            this.btnMSpiller2 = new System.Windows.Forms.Button();
            this.btnFSpiller2 = new System.Windows.Forms.Button();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnBegin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // spilletsNavn
            // 
            this.spilletsNavn.AutoSize = true;
            this.spilletsNavn.Font = new System.Drawing.Font("Agency FB", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spilletsNavn.Location = new System.Drawing.Point(408, 9);
            this.spilletsNavn.Name = "spilletsNavn";
            this.spilletsNavn.Size = new System.Drawing.Size(418, 159);
            this.spilletsNavn.TabIndex = 0;
            this.spilletsNavn.Text = "BALKAN";
            this.spilletsNavn.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer1.ForeColor = System.Drawing.Color.DimGray;
            this.txtPlayer1.Location = new System.Drawing.Point(463, 171);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(300, 31);
            this.txtPlayer1.TabIndex = 1;
            this.txtPlayer1.Text = "Spiller 1...";
            this.txtPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPlayer1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.BackColor = System.Drawing.SystemColors.Window;
            this.txtPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer2.ForeColor = System.Drawing.Color.DimGray;
            this.txtPlayer2.Location = new System.Drawing.Point(463, 218);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(300, 31);
            this.txtPlayer2.TabIndex = 1;
            this.txtPlayer2.Text = "Spiller 2...";
            this.txtPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPlayer2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnMSpiller1
            // 
            this.btnMSpiller1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMSpiller1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMSpiller1.BackgroundImage")));
            this.btnMSpiller1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMSpiller1.FlatAppearance.BorderSize = 0;
            this.btnMSpiller1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnMSpiller1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMSpiller1.Location = new System.Drawing.Point(779, 165);
            this.btnMSpiller1.Name = "btnMSpiller1";
            this.btnMSpiller1.Size = new System.Drawing.Size(40, 40);
            this.btnMSpiller1.TabIndex = 2;
            this.btnMSpiller1.UseVisualStyleBackColor = false;
            // 
            // btnFSpiller1
            // 
            this.btnFSpiller1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFSpiller1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFSpiller1.BackgroundImage")));
            this.btnFSpiller1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFSpiller1.FlatAppearance.BorderSize = 0;
            this.btnFSpiller1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnFSpiller1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFSpiller1.Location = new System.Drawing.Point(841, 165);
            this.btnFSpiller1.Name = "btnFSpiller1";
            this.btnFSpiller1.Size = new System.Drawing.Size(40, 40);
            this.btnFSpiller1.TabIndex = 2;
            this.btnFSpiller1.UseVisualStyleBackColor = false;
            // 
            // btnMSpiller2
            // 
            this.btnMSpiller2.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMSpiller2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMSpiller2.BackgroundImage")));
            this.btnMSpiller2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMSpiller2.FlatAppearance.BorderSize = 0;
            this.btnMSpiller2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnMSpiller2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMSpiller2.Location = new System.Drawing.Point(779, 212);
            this.btnMSpiller2.Name = "btnMSpiller2";
            this.btnMSpiller2.Size = new System.Drawing.Size(40, 40);
            this.btnMSpiller2.TabIndex = 2;
            this.btnMSpiller2.UseVisualStyleBackColor = false;
            // 
            // btnFSpiller2
            // 
            this.btnFSpiller2.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFSpiller2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFSpiller2.BackgroundImage")));
            this.btnFSpiller2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFSpiller2.FlatAppearance.BorderSize = 0;
            this.btnFSpiller2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnFSpiller2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFSpiller2.Location = new System.Drawing.Point(841, 212);
            this.btnFSpiller2.Name = "btnFSpiller2";
            this.btnFSpiller2.Size = new System.Drawing.Size(40, 40);
            this.btnFSpiller2.TabIndex = 2;
            this.btnFSpiller2.UseVisualStyleBackColor = false;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.FlatAppearance.BorderSize = 2;
            this.btnAddPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnAddPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlayer.Location = new System.Drawing.Point(585, 267);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(50, 51);
            this.btnAddPlayer.TabIndex = 3;
            this.btnAddPlayer.Text = "+";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // btnBegin
            // 
            this.btnBegin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBegin.BackgroundImage")));
            this.btnBegin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBegin.FlatAppearance.BorderSize = 0;
            this.btnBegin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnBegin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBegin.Location = new System.Drawing.Point(551, 578);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(110, 110);
            this.btnBegin.TabIndex = 4;
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 371);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(907, 371);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(373, 350);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1244, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(1202, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 35);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.btnFSpiller2);
            this.Controls.Add(this.btnMSpiller2);
            this.Controls.Add(this.btnFSpiller1);
            this.Controls.Add(this.btnMSpiller1);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.spilletsNavn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label spilletsNavn;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.Button btnMSpiller1;
        private System.Windows.Forms.Button btnFSpiller1;
        private System.Windows.Forms.Button btnMSpiller2;
        private System.Windows.Forms.Button btnFSpiller2;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
    }
}

