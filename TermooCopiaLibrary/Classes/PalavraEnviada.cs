using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermooCopiaLibrary.Classes
{
    public class PalavraEnviada : Palavra
    {
        public PalavraEnviada(string palavra)
        {
            Letra disposableLetra = new();
            var palavraArray = palavra.ToCharArray();
            for (int i = 0; i < palavraArray.Length; i++)
            {
                disposableLetra.caracterie = palavraArray[i];
                disposableLetra.index = i;
            }
            letras.Add(disposableLetra);
        }
    }
}
