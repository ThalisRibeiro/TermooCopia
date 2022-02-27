using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermooCopiaLibrary.Classes
{
    public class PalavraCerta : Palavra
    {
        public bool usada;
        public  PalavraCerta(string palavra)
        {
            Letra disposableLetra = new();
            List<Letra> disposableLetraList = new();

            var palavraArray = palavra.ToCharArray();
            for (int i = 0; i < palavraArray.Length; i++)
            {
                disposableLetra.caracterie = palavraArray[i];
                disposableLetra.index=i;
                disposableLetraList.Add(disposableLetra);
            }
            usada = false;
            letras = disposableLetraList;
        }



        private Cores Recursivo(int indexRecebido ,List<int> listaIndex, int i =0, bool hasYellow = false)
        {
            Cores cor;

            if (this.letras[listaIndex[i]].cor == Cores.Yellow || this.letras[listaIndex[i]].cor == Cores.Green)
            {
                hasYellow = true;
            }

            if (indexRecebido == listaIndex[i] && this.letras[listaIndex[i]].cor !=Cores.Green)
            {
                Letra disposableLetra = this.letras[listaIndex[i]];
                cor = Cores.Green;
                disposableLetra.cor = cor;
                this.letras[listaIndex[i]] = disposableLetra;
            }
            else if (listaIndex.Count-1 == i && hasYellow==false)
            {
                Letra disposableLetra = this.letras[listaIndex[i]];
                cor = Cores.Yellow;
                disposableLetra.cor = cor;
                this.letras[listaIndex[i]] = disposableLetra;
            }
            else if (listaIndex.Count - 1 == i)
            {
                cor = Cores.Red;
                bool sai = false;
                do
                {
                    if (this.letras[listaIndex[i]].cor != Cores.Yellow && this.letras[listaIndex[i]].cor != Cores.Green)
                    {
                        Letra disposableLetra = this.letras[listaIndex[i]];
                        cor = Cores.Yellow;
                        disposableLetra.cor = Cores.Yellow;
                        this.letras[listaIndex[i]] = disposableLetra;
                        sai = true;
                    }
                    else i -= 1;
                } while (sai == false&&i>-1);
            }

            else
            {
                cor = Recursivo(indexRecebido, listaIndex, i + 1,hasYellow);
            }

            return cor;
        }

        public List<Letra> VerificaAcerto(List<Letra> letrasRecebida)
        {
            this.PadronizaBranco();
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
                        disposableLetra2.cor = Cores.Red;
                        letrasRecebida[i] = disposableLetra2;
                        break;
                }
            }
            return letrasRecebida;
        }
    }
}
