using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace praticasMVC.Models
{
    public class MockMovieRepository : IRepository
    {
        private List<Movie> movies;
        public MockMovieRepository()
        {
            if (movies == null)
            {
                InitializeMockRepository();
            }
        }

        private void InitializeMockRepository()
        {
            movies = new List<Movie>
            {
                new Movie
                {
                    IdFilme = 1,
                    Nome = "Robocop",
                    Descricao = "Filme do Robocop monstrão",
                    DataLancamento = DateTime.Now
                },
                new Movie
                {
                    IdFilme = 2,
                    Nome = "John Wick",
                    Descricao = "Filme do próprio monstrão",
                    DataLancamento = DateTime.Now
                },
                new Movie
                {
                    IdFilme = 3,
                    Nome = "Peppa",
                    Descricao = "Se a Duda falou que é bom, então é bom"
                }
             };
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return movies;
        }

        public Movie GetMovieById(int id)
        {
            return movies.FirstOrDefault(x => x.IdFilme == id);
        }
    }
}
