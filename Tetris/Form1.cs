namespace Tetris {
    public partial class Inicio : Form {
        public Jogo gameWindow;
        public readonly GameCanvasHandler _gameCanvasHandler = new(24);
        public readonly GameStateHandler _gameStateHandler = new();

        public Inicio() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click_1(object sender, EventArgs e) {
        }

        private void iniciarJogo(object sender, EventArgs e) {
            // Abrir nova janela a partir de um clique
            
            // gameWindow.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void Panel_Paint(object sender, PaintEventArgs e) {

        }

        private void Frame_Tick(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void Frame_Tick_1(object sender, EventArgs e)
        {
            while (gameWindow == null || gameWindow.gameGraphics == null)
                return;

            _gameStateHandler.Update();
            _gameCanvasHandler.Paint(gameWindow.gameGraphics, _gameStateHandler.Scenario,
                _gameStateHandler.CurrentBlock.TilePositions(), _gameStateHandler.CurrentBlock.Id);
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            if (!Frame.Enabled)
                Frame.Start();

            gameWindow = new(_gameStateHandler);
            gameWindow.Show();
        }
    }
}