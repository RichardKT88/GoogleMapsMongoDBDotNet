using MongoDB.Driver;


namespace Alura.GoogleMaps.Web.Models
{
    public class conectandoMongoDBGeo
    {
        public const string STRING_DE_CONEXAO = "mongodb://localhost:27017";
        public const string NOME_DA_BASE = "geo";
        public const string NOME_DA_COLECAO = "airports";

        private static readonly IMongoClient _client;
        private static readonly IMongoDatabase _database;

        static conectandoMongoDBGeo()
        {
            _client = new MongoClient(STRING_DE_CONEXAO);
            _database = _client.GetDatabase(NOME_DA_BASE);
        }

        public IMongoClient Cliente
        {
            get { return _client; }
        }

        public IMongoCollection<Aeroporto> Airports
        {
            get { return _database.GetCollection<Aeroporto>(NOME_DA_COLECAO); }
        }


    }
}