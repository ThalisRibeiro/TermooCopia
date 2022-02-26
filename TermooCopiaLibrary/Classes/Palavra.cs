using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermooCopiaLibrary.Classes
{
    public abstract class Palavra
    {
        protected List<Letra> letras=new();
        protected struct Letra
        {
            public char caracterie;
            public Cores cor;
            public int index;
        }
    }
}
