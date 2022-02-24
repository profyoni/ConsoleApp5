using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute("ClassLib.Test2")]

namespace ClassLib
{
    public class Wordle
    {
        internal string target;

        public void TryGuess(string s){}
    }
}
