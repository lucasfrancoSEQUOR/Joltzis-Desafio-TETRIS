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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            btnJogar = new Button();
            btnRank = new Button();
            btnConfig = new Button();
            label1 = new Label();
            txtNomeJogador = new TextBox();
            SuspendLayout();
            // 
            // btnJogar
            // 
            btnJogar.Font = new Font("Cascadia Code", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnJogar.Image = Properties.Resources.play_button_icon2;
            btnJogar.Location = new Point(160, 622);
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
            btnRank.Location = new Point(277, 622);
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
            btnConfig.Location = new Point(396, 622);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(77, 77);
            btnConfig.TabIndex = 1;
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 749);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 2;
            label1.Text = "Nome do jogador:";
            label1.Click += label1_Click;
            // 
            // txtNomeJogador
            // 
            txtNomeJogador.Location = new Point(277, 749);
            txtNomeJogador.Name = "txtNomeJogador";
            txtNomeJogador.Size = new Size(258, 31);
            txtNomeJogador.TabIndex = 3;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 837);
            Controls.Add(txtNomeJogador);
            Controls.Add(label1);
            Controls.Add(btnConfig);
            Controls.Add(btnRank);
            Controls.Add(btnJogar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Joltzis ©";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnJogar;
        private Button btnRank;
        private Button btnConfig;
        private Label label1;
        private TextBox txtNomeJogador;
    }
}