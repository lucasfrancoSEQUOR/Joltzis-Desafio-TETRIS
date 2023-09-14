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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            btnJogar = new Button();
            btnRank = new Button();
            btnConfig = new Button();
            label1 = new Label();
            txtNomeJogador = new TextBox();
            Frame = new System.Windows.Forms.Timer(components);
            fileSystemWatcher1 = new FileSystemWatcher();
            picLogo = new PictureBox();
            lbCreatedBy = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // btnJogar
            // 
            btnJogar.Font = new Font("Cascadia Code", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnJogar.Image = Properties.Resources.play_button_icon2;
            btnJogar.Location = new Point(319, 638);
            btnJogar.Name = "btnJogar";
            btnJogar.Size = new Size(77, 77);
            btnJogar.TabIndex = 0;
            btnJogar.UseVisualStyleBackColor = true;
            btnJogar.Click += iniciarJogo;
            // 
            // btnRank
            // 
            btnRank.BackgroundImage = Properties.Resources.ranking_icon2;
            btnRank.BackgroundImageLayout = ImageLayout.Center;
            btnRank.Cursor = Cursors.No;
            btnRank.Font = new Font("Cascadia Code", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnRank.ImageAlign = ContentAlignment.BottomLeft;
            btnRank.Location = new Point(436, 638);
            btnRank.Name = "btnRank";
            btnRank.Size = new Size(77, 77);
            btnRank.TabIndex = 1;
            btnRank.UseVisualStyleBackColor = true;
            btnRank.Click += button1_Click_1;
            // 
            // btnConfig
            // 
            btnConfig.BackgroundImageLayout = ImageLayout.Center;
            btnConfig.Cursor = Cursors.No;
            btnConfig.Font = new Font("Cascadia Code", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfig.Image = Properties.Resources.config_icon;
            btnConfig.Location = new Point(555, 638);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(77, 77);
            btnConfig.TabIndex = 1;
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 862);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 2;
            label1.Text = "Nome do jogador:";
            label1.Click += label1_Click;
            // 
            // txtNomeJogador
            // 
            txtNomeJogador.Location = new Point(182, 862);
            txtNomeJogador.Name = "txtNomeJogador";
            txtNomeJogador.Size = new Size(258, 31);
            txtNomeJogador.TabIndex = 3;
            // 
            // Frame
            // 
            Frame.Tick += Frame_Tick;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.logo_joltzisM;
            picLogo.InitialImage = Properties.Resources.logo_joltzis;
            picLogo.Location = new Point(179, 149);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(600, 242);
            picLogo.TabIndex = 4;
            picLogo.TabStop = false;
            // 
            // lbCreatedBy
            // 
            lbCreatedBy.AutoSize = true;
            lbCreatedBy.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbCreatedBy.Location = new Point(282, 98);
            lbCreatedBy.Name = "lbCreatedBy";
            lbCreatedBy.Size = new Size(395, 48);
            lbCreatedBy.TabIndex = 5;
            lbCreatedBy.Text = "Joltzis © - Created by Lucas Franco\r\nat Sequor";
            lbCreatedBy.TextAlign = ContentAlignment.MiddleCenter;
            lbCreatedBy.Click += label2_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(959, 905);
            Controls.Add(lbCreatedBy);
            Controls.Add(picLogo);
            Controls.Add(txtNomeJogador);
            Controls.Add(label1);
            Controls.Add(btnConfig);
            Controls.Add(btnRank);
            Controls.Add(btnJogar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Joltzis ©";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
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