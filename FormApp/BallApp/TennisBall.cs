﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BallApp {
    internal class TennisBall : Obj {
        public static int Count { get; set; }  
        public TennisBall(double xp, double yp)
        : base(xp -15, yp -15, @"Picture\tennis_ball.png"){

            MoveX = 10;//移動量設定
            MoveY = 10;
            Count++;
        }

    public override bool Move() {
        if (PosX > 750 || PosX < 0) {
            MoveX = -MoveX;
        }

        if (PosY > 540 || PosY < 0) {
            MoveY = -MoveY;
        }


        PosX += MoveX;
        PosY += MoveY;

       

        return true;
    }
}
}
