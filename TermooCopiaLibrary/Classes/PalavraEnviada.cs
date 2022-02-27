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
            List<Letra> disposableLetraList = new();

            var palavraArray = palavra.ToCharArray();
            for (int i = 0; i < palavraArray.Length; i++)
            {
                disposableLetra.caracterie = palavraArray[i];
                disposableLetra.index = i;
                disposableLetra.cor = Cores.White;
                disposableLetraList.Add(disposableLetra);
            }
            letras = disposableLetraList;
        }

        public void AtualizaPalavra(List<Letra> letrasRecebidas)
        {
            this.letras = letrasRecebidas;
        }
        public bool VerificaVitoria(List<Letra> letrasRecebidas)
        {
            this.AtualizaPalavra(letrasRecebidas);
            var vitoria = true;
            for (int i = 0; i < letras.Count; i++)
            {
                if (letras[i].cor != Cores.Green)
                {
                    vitoria = false;
                    return vitoria;
                }
            }
            return vitoria;
        }

        public List<Letra> EnviaPalavra()
        {
            return this.letras;
        }
    }
}
