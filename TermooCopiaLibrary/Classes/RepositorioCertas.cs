using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermooCopiaLibrary.Classes
{
    public class RepositorioCertas
    {
        public static List<PalavraCerta> palavras = new();

        public void AdicionaPalavra(string palavraRecebida)
        {
            if (palavraRecebida.Count()==5)
            {
                PalavraCerta palavra= new(palavraRecebida);
                
                palavras.Add(palavra);
            }
        }



    }
}
