using Dapper;
using Proyecto_final.Models;
using System.Data.SqlClient;

namespace Proyecto_final.Rules
{
    public class PublicacionRule
    {
        private readonly IConfiguration _configuration;

        public PublicacionRule(IConfiguration configuration) 
        {
            _configuration = configuration;
        }
        public Publicacion GetOnePostRandom()
        {

            var connectionString = _configuration.GetConnectionString("BlogDataBase");

            using var connection = new SqlConnection(connectionString);
            {
                connection.Open();
                var post = connection.Query<Publicacion>("SELECT TOP 1 * FROM Publicacion ORDER BY NEWID()");

                return post.First();
            }
            
        }

        public List<Publicacion> GetPostHome()
        {

            var connectionString = _configuration.GetConnectionString("BlogDataBase");

            using var connection = new SqlConnection(connectionString);
            {
                connection.Open();
                var post = connection.Query<Publicacion>("SELECT TOP 4 * FROM Publicacion ORDER BY Creacion DESC");

                return post.ToList();
            }

        }
    
        public Publicacion GetPostById(int id)
        {
            var connectionString = _configuration.GetConnectionString("BlogDataBase");

            using var connection = new SqlConnection(connectionString);
            {
                connection.Open();
                var query = "SELECT * FROM Publicacion WHERE Id = @id";
                var post = connection.QueryFirstOrDefault<Publicacion>(query, new { id });

                return post;
            }
        }
    
    }
}
