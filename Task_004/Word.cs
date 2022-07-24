using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_004
{
    internal class Word
    {
        private string _ukr, _eng, _rus;
        public Word(string ukr, string eng, string rus)
        {
            _ukr = ukr;
            _eng = eng;
            _rus = rus;
        }
        public string Ukr { get => _ukr; }
        public string Eng { get => _eng; }
        public string Rus { get => _rus; }
    }
}
