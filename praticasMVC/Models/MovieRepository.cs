using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace praticasMVC.Models
{
    public class MovieRepository : IRepository
    {
        private readonly DatabaseContext _dbContext;
        public MovieRepository(DatabaseContext databaseContext)
        {
            _dbContext = databaseContext;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return _dbContext.Movies;
        }

        public Movie GetMovieById(int id)
        {
            return _dbContext.Movies.FirstOrDefault(x => x.IdFilme == id);
        }
    }

}
