namespace BallApp {
    public partial class Form1 : Form {
        private double posX;  //x���W
        private double posY;  //y���W
        private double moveX; //�ړ���(x����)
        private double moveY; //�ړ���(y����)


        public Form1() {
            InitializeComponent();

            moveX = moveY = 5;
        }

        //�t�H�[�����ŏ��Ƀ��[�h����Ƃ���x�������s�����
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
