using BuscaItem.Application;
using BuscaItem.Domain;
using BuscaItem.Domain.Models;


namespace BuscaItem.Tests
{

    // bdd - Given_When_Then - Given valid numbers when sun then should success
    //GivenValidNumbers_WhenSum_ThenShoudSyccess()

    public class UnitTest1
    {


        [Fact(DisplayName = "Calculo de lucro positivo")]
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
            Assert.Equal(resultExpected, resultadoPratico); ////cálculo exato de lucro positivo,
        }

        [Fact(DisplayName = "cálculo de lucro zero")]
        public void GivenValidNumbers_WhenSum_ThenShouldBeZero()
        {
            //Arrange - Variaveis
            const string nomeNotebook1 = "Dell Teste Unitario1";
            const decimal lanceAtual1 = 100;
            const decimal valorDeMercado1 = 100;
            const decimal resultExpected1 = 0;

            Notebook notebookTeste2 = new Notebook(nomeNotebook1, lanceAtual1, valorDeMercado1);
            //Act - Metodo que sera testado
            var resultActual1 = notebookTeste2.LucroPotencial();
            //Assert - resultado esperado
            Assert.Equal(resultExpected1, resultActual1);
        }
        [Fact(DisplayName = "cálculo de lucro negativo")]
        public void GivenValidNumbers_WhenSum_ThenShouldBeNegative()
        {
            //Arrange - Variaveis
            const string nomeNotebook2 = "Dell Teste Unitario1";
            const decimal lanceAtual2 = 0;
            const decimal valorDeMercado2 = -300;
            const decimal resultExpected2 = -300;

            Notebook notebookTeste2 = new Notebook(nomeNotebook2, lanceAtual2, valorDeMercado2);
            //Act - Metodo que sera testado
            var resultActual2 = notebookTeste2.LucroPotencial();
            //Assert - resultado esperado
            Assert.Equal(resultExpected2, resultActual2);
        }
        [Fact(DisplayName = "disparo de exceção ao tentar instanciar um notebook com valores inválidos.")]
        public void Construtor_QuandoLancewAtualMenorouIgualaZero_DeveLancarArgumentOutOfRangeException()
        {
            //Arrange - Variaveis
            const string nomeNotebook3 = "Dell Teste Unitario1";
            const decimal lanceAtual3 = -1;
            const decimal valorDeMercado3 = 100;
            //Act & Assert - Executa a criacao esperando a exceção
            Assert.Throws<ArgumentOutOfRangeException>(()=>
                new Notebook(nomeNotebook3,lanceAtual3,valorDeMercado3));

            
        }
    }
}

//cálculo exato de lucro positivo,
//cálculo de lucro zero ou negativo e
//disparo de exceção ao tentar instanciar um notebook com valores inválidos.