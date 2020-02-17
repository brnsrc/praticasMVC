using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace praticasMVC.Models
{
    public interface IRepository
    {
        IEnumerable<Movie> GetAllMovies();
        Movie GetMovieById(int id);
    }
}
