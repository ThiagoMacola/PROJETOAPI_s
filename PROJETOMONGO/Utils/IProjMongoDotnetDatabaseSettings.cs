namespace PROJETOMONGO.Utils
{
    public interface IProjMongoDotnetDatabaseSettings
    {
         
         string ProdutoCollectionName { get; set; }
         string ConnectionString { get; set; }
         string DatabaseName { get; set; }

    }
}