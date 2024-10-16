using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TextFileProcessor;
using TextNumberSizeChange.Framework;

namespace TextNumberSizeChange {
    class ToHankakuProcessor : ITextFileService {

        Dictionary<char, char> numbers = new Dictionary<char, char>(){
            {'０', '0'}, {'１', '1'}, {'２', '2'}, {'３', '3'},
            {'４', '4'}, {'５', '5'}, {'６', '6'}, {'７', '7'},
            {'８', '8'}, {'９', '9'}
        };

        private int _count;

        public  void Initialize(string fname) {
            _count = 0;
        }

        public  void Execute(string line) {
            string numberLower = new string(line.Select(x => (numbers.ContainsKey(x) ? numbers[x] : x)).ToArray());
            Console.WriteLine(numberLower);
            _count++;
        }

        public  void Terminate() {
            Console.WriteLine("{0}行", _count);
        }
    }
}
