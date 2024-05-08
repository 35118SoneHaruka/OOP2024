namespace BallApp {
    public partial class Form1 : Form {
        private double posX;  //x座標
        private double posY;  //y座標
        private double moveX; //移動量(x方向)
        private double moveY; //移動量(y方向)


        public Form1() {
            InitializeComponent();

            moveX = moveY = 5;
        }

        //フォームが最初にロードされとき一度だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
            //this.BackColor = Color.Green;
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void timer1_Tick(object sender, EventArgs e) {

            if (pbBall.Location.Y > 510) {
                moveY = -moveY;
            }

            if (pbBall.Location.Y < 1) {
                moveY = -moveY;
            }

            if(pbBall.Location.X < 1) {
                moveX = -moveX;
            }

            if (pbBall.Location.X > 733) {
                moveX = -moveX;
            }

            posX += moveX;
            posY += moveY;

            pbBall.Location = new Point((int)posX,(int)posY);
        }
    }
}
