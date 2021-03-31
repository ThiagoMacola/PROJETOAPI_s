namespace PROJETO_API_REPORT.Dto
{
    public class ProdutoDto
    {
        
        #region Propriedades 
     
            public string Id { get; set; }
            public string Descricao { get; set; }
            public decimal Preco { get; set; }

            public Fornecedor Fornecedor { get; set; }

        #endregion

        







    }
}