using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    internal class Bar : Obj {

        public Bar(double xp, double yp)
            : base(xp - 15, yp - 15, @"Picture\bar.png") {

            MoveX = 10;
            MoveY = 0;

        }
        public override bool Move(PictureBox pbBar, PictureBox pbBall) {
           return true;
        }

        public override bool Move(Keys direction) {
            if(direction == Keys.Right　&& this.PosX < 630) {
                PosX += MoveX;
            }else if(direction == Keys.Left && this.PosX > 0) {
                PosX -= MoveX;
            }
            return true;
        }
    }
}
