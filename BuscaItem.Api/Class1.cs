namespace BuscaItem.Api
{
    public class Notebook
    {
        string NomeNotebook{get;set;}
        decimal LanceAtual { get;set;}
        decimal ValordeMercado {  get;set;}
        decimal TaxaLeiloeiro {  get;set;}


        public Notebook(string nomeNotebook,decimal lanceAtual, decimal valordeMercado)
        {
            nomeNotebook = NomeNotebook;
            lanceAtual = LanceAtual;
            valordeMercado = ValordeMercado;
            
        }
        public decimal LucroPotencial ()
        {
            return ValordeMercado - LanceAtual

        }



    }
}
