using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermooCopiaLibrary.Classes
{
    public abstract class Palavra
    {
        //protected List<Letra> letras=new();
        protected List<Letra> letras = new();
        public struct Letra
        {
            public char caracterie;
            public Cores cor ;
            public int index;
        }
        protected bool ContemLetras(char letraRecebida)
        {
            var retorno = false;
            for (int i = 0; i < letras.Count; i++)
            {
                bool baba = (letraRecebida == letras[i].caracterie);
                switch (baba)
                {
                    case true: retorno = true;
                        return retorno;
                    
                    default:
                        break;
                }
            }

            return retorno;
        }

        protected List<int> BuscaIguais(char letraRecebida)
        {
            List<int> listaIndex = new List<int>();
            for (int i = 0; i < letras.Count; i++)
            {
                if (letraRecebida == letras[i].caracterie)
                {
                    listaIndex.Add(i);
                }
            }
            return listaIndex;
        }

        protected void PadronizaBranco()
        {
            for (int i = 0; i < this.letras.Count; i++)
            {
                var disposableLetras = this.letras[i];
                disposableLetras.cor = Cores.White;
                this.letras[i]=disposableLetras;
            }
        }
    }
}
