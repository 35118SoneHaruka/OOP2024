namespace BallApp {
    public partial class Form1 : Form {
        SoccerBall soccerBall;
        TennisBall tennisball;
        PictureBox pb;

        public Form1() {
            InitializeComponent();


        }

        //フォームが最初にロードされとき一度だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
            //this.BackColor = Color.Green;
            
        }


        private void timer1_Tick(object sender, EventArgs e) {
            soccerBall.Move();
            pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) {
             pb = new PictureBox(); //画像を表示するコントロール
            if(e.Button == MouseButtons.Left) {
                 pb.Size = new Size(50, 50);
                soccerBall = new SoccerBall(e.X, e.Y);
                pb.Image = soccerBall.Image;
                pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);
            }
   
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Parent = this;

            timer1.Start();
        }
    }
}
