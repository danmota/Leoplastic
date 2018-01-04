namespace Leoplastic
{
    public class ContextoBD
    {
        public LeoplasticDataContext ConexaoBancoDados()
        {
            var conexaoDB = new LeoplasticDataContext("Data Source=.\\sqlexpress;Initial Catalog=leoplastic;Integrated Security=True");
            return conexaoDB;
        }
    }
}
