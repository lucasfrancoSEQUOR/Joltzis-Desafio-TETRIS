namespace Tetris {
    partial class Inicio {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnRank = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.Frame = new System.Windows.Forms.Timer(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJogar
            // 
            this.btnJogar.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJogar.Image = global::Tetris.Properties.Resources.play_button_icon2;
            this.btnJogar.Location = new System.Drawing.Point(223, 383);
            this.btnJogar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(54, 46);
            this.btnJogar.TabIndex = 0;
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnRank
            // 
            this.btnRank.BackgroundImage = global::Tetris.Properties.Resources.ranking_icon2;
            this.btnRank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRank.Cursor = System.Windows.Forms.Cursors.No;
            this.btnRank.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRank.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnRank.Location = new System.Drawing.Point(305, 383);
            this.btnRank.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(54, 46);
            this.btnRank.TabIndex = 1;
            this.btnRank.UseVisualStyleBackColor = true;
            // 
            // btnConfig
            // 
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.No;
            this.btnConfig.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfig.Image = global::Tetris.Properties.Resources.config_icon;
            this.btnConfig.Location = new System.Drawing.Point(388, 383);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(54, 46);
            this.btnConfig.TabIndex = 1;
            this.btnConfig.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 517);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do jogador:";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(127, 517);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(182, 23);
            this.txtNomeJogador.TabIndex = 3;
            // 
            // Frame
            // 
            this.Frame.Tick += new System.EventHandler(this.Frame_Tick_1);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Tetris.Properties.Resources.logo_joltzisM;
            this.picLogo.InitialImage = global::Tetris.Properties.Resources.logo_joltzis;
            this.picLogo.Location = new System.Drawing.Point(125, 89);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(420, 145);
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCreatedBy.Location = new System.Drawing.Point(197, 59);
            this.lbCreatedBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(252, 32);
            this.lbCreatedBy.TabIndex = 5;
            this.lbCreatedBy.Text = "Joltzis © - Created by Lucas Franco\r\nat Sequor";
            this.lbCreatedBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(671, 447);
            this.Controls.Add(this.lbCreatedBy);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnRank);
            this.Controls.Add(this.btnJogar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joltzis ©";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnJogar;
        private Button btnRank;
        private Button btnConfig;
        private Label label1;
        private TextBox txtNomeJogador;
        private System.Windows.Forms.Timer Frame;
        private FileSystemWatcher fileSystemWatcher1;
        private PictureBox picLogo;
        private Label lbCreatedBy;
    }
}