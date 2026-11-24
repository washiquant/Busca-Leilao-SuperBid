using BuscaItem.Application;
using BuscaItem.Domain;
using BuscaItem.Domain.Models;


namespace BuscaItem.Tests
{

        // bdd - Given_When_Then - Given valid numbers when sun then should success
        //GivenValidNumbers_WhenSum_ThenShoudSyccess()

    public class UnitTest1
    {


        [Fact(DisplayName = "Given valid numbers when sun then should success")]
        public void GivenValidNumbers_WhenSum_ThenShouldSucess()
        {
            //Arrange - Variaveis
            const string nomeNotebook = "Dell Teste Unitario";
            const decimal lanceAtual = 100;
            const decimal valorDeMercado = 500;
            const decimal taxaLeiloeiro = 2;
            const decimal resultExpected = 400;

            Notebook notebookTeste1 = new Notebook(nomeNotebook, lanceAtual, valorDeMercado);
            //Act - Metodo que sera testado
            var resultadoPratico = notebookTeste1.LucroPotencial();
            //assert - resultado esperado
            Assert.Equal(resultExpected, resultadoPratico);
        }
    }
}

//cálculo exato de lucro positivo,
//cálculo de lucro zero ou negativo e
//disparo de exceção ao tentar instanciar um notebook com valores inválidos.