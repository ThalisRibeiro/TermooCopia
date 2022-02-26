using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermooCopiaLibrary.Classes
{
    public class PalavraCerta : Palavra
    {
        
        public  PalavraCerta(string palavra)
        {
            Letra disposableLetra = new();
            var palavraArray = palavra.ToCharArray();
            for (int i = 0; i < palavraArray.Length; i++)
            {
                disposableLetra.caracterie = palavraArray[i];
                disposableLetra.index=i;
            }
            letras.Add(disposableLetra);
        }



        private Cores Recursivo(int indexRecebido ,List<int> listaIndex, int i =0)
        {
            Cores cor;
            if (indexRecebido == listaIndex[i])
            {
                Letra disposableLetra = this.letras[indexRecebido];
                cor = Cores.Green;
                disposableLetra.cor = cor;
                this.letras[indexRecebido] = disposableLetra;
            }
            else if (listaIndex.Count==i-1)
            {
                Letra disposableLetra = this.letras[indexRecebido];
                cor = Cores.Yellow;
                disposableLetra.cor = Cores.Yellow;
                this.letras[indexRecebido] = disposableLetra;
            }
            else
            {
                cor = Recursivo(indexRecebido, listaIndex, i + 1);
            }
            return cor;
        }

        public List<Letra> VerificaAcerto(List<Letra> letrasRecebida)
        {
            
            
            for (int i = 0; i < 5; i++)
            {
                switch (ContemLetras(letrasRecebida[i].caracterie))
                {
                    case true:

                        Letra disposableLetra = letrasRecebida[i];
                        disposableLetra.cor = Recursivo(i,BuscaIguais(letrasRecebida[i].caracterie));
                        letrasRecebida[i] = disposableLetra;
                        break;
                    default:

                        Letra disposableLetra2 = letrasRecebida[i];
                        disposableLetra.cor = Cores.Red;
                        letrasRecebida[i] = disposableLetra2;
                        break;
                }
            }
            return letrasRecebida;
        }
    }
}
