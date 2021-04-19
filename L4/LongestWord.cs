using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4
{
    class LongestWord
    {
        public string Word {get;set;}
        public int Repeat { get; set;}

        public LongestWord(string word,int repeat)
        {
            Word = word;
            Repeat = repeat;
        }
    }
}
