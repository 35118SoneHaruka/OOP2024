using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    public class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                //フィートからメートルへの対応表を出力
                PrintInchToMeterList(int.Parse(args[1]), int.Parse(args[2]));
            } else {
                //メートルからフィートへの対応表を出力
                PrintMeterToInchList(int.Parse(args[1]), int.Parse(args[2]));
            }

        }

        static void PrintMeterToInchList(int start, int stop) {
            for (int meter = start; meter <= stop; meter++) {
                double inch = InchConverter.FromMeter(meter);
                Console.WriteLine("{0}m = {1:0.0000}in", meter, inch);
            }
        }

        static void PrintInchToMeterList(int start, int stop) {
            for (int inch = start; inch <= stop; inch++) {
                double meter = InchConverter.ToMeter(inch);
                Console.WriteLine("{0}in = {1:0.0000}m", inch, meter);
            }
        }

        static void PrintMeterToYardList(int start, int stop) {
            for (int meter = start; meter <= stop; meter++) {
                double yard = InchConverter.FromMeter(meter);
                Console.WriteLine("{0}m = {1:0.0000}in", meter, yard);
            }
        }

        static void PrintYardToMeterList(int start, int stop) {
            for (int yard = start; yard <= stop; yard++) {
                double meter = InchConverter.ToMeter(yard);
                Console.WriteLine("{0}in = {1:0.0000}m", yard, meter);
            }
        }
    }
}
