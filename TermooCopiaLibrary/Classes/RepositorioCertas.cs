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
        private int i;
        public void AdicionaPalavra(string palavraRecebida)
        {
            if (palavraRecebida.Length == 5)
            {
                PalavraCerta palavra= new(palavraRecebida);
                
                palavras.Add(palavra);
            }
        }

        private void EscolhePalavra()
        {
            bool usada;
            i = 0; do
            {
                usada = palavras[i].usada;
                if (usada== true)
                {
                    i += 1;
                }
            } while (usada == true);
            
        }

        string VerificaPalavra(PalavraEnviada enviada)
        {
            var vitoria = enviada.VerificaVitoria(palavras[i].VerificaAcerto(enviada.EnviaPalavra()));
            if (vitoria == true)
                return "Parabens, voce acertou";
            else
                return "Tente mais uma vez";
        }
        public string RecebePalavra(string palavraRecebida)
        {
            PalavraEnviada enviada = new(palavraRecebida);
            return VerificaPalavra(enviada);
        }

    }
}
