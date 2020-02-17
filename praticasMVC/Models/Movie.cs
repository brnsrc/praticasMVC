using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace praticasMVC.Models
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        public int IdFilme { get; set; }
        
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataLancamento { get; set; }


    }
}
