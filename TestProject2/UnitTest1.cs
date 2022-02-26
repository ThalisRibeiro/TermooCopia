using Microsoft.VisualStudio.TestTools.UnitTesting;
using TermooCopiaLibrary;
using TermooCopiaLibrary.Classes;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RepositorioCertas rp = new();
            rp.AdicionaPalavra("carro");
            string retorno = rp.RecebePalavra("carro");
            Assert.AreEqual("Parabens, voce acertou", retorno);

        }
        [TestMethod]
        public void TestMethod2()
        {
            RepositorioCertas rp = new();
            rp.AdicionaPalavra("julio");
            string retorno = rp.RecebePalavra("carro");
            Assert.AreEqual("Tente mais uma vez", retorno);

        }
    }
}