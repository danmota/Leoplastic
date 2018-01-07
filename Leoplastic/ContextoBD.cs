namespace Leoplastic
{
    public class ContextoBD
    {
        public LeoplasticDataContext ConexaoBancoDados()
        {
            //var conexaoDB = new LeoplasticDataContext("Data Source=.\\sqlexpress;Initial Catalog=leoplastic;Integrated Security=True");
            var conexaoDB = new LeoplasticDataContext("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Daniel Mota\\Documents\\GitHub\\Leoplastic\\Leoplastic.mdb;Persist Security Info=True");
            return conexaoDB;
        }
    }
}
