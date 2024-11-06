﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWeightUnitConverter.Model {
    public class GramUnit : WeightUnit {
        private static List<GramUnit> units = new List<GramUnit> {
            new GramUnit{Name ="mm" ,Coefficient = 1},
            new GramUnit{Name ="cm" ,Coefficient = 10},
        };
        public static ICollection<GramUnit> Units { get { return units; } }

        /// <summary>
        /// ポンド単位からグラム単位に変換します
        /// </summary>
        /// <param name="unit">ポンド単位</param>
        /// <param name="value">値</param>
        /// <returns></returns>

        public double FromPoundUnit(PoundUnit unit, double value) {
            return (value * unit.Coefficient) * 25.4 / this.Coefficient;
        }
    }
}
