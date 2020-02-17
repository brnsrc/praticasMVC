using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace praticasMVC.Models
{
    public static class DBInitializerMovie
    {
        public static void Seed(DatabaseContext dbContext)
        {
            if (!dbContext.Movies.Any())
            {
                dbContext.AddRange(
                    new Movie
                    {
                        Nome = "O Gênio e o Louco",
                        Descricao = "A história real de dois homens ambiciosos que tentam concluir um dos maiores projetos do mundo: a criação do Dicionário Oxford.",
                        DataLancamento = DateTime.Parse("2019-04-18")
                    },
                    new Movie
                    {
                        Nome = "O Poderoso Chefão",
                        Descricao = "Don Vito Corleone (Marlon Brando) é o chefe de uma família de Nova York que " +
                        "está feliz, pois Connie (Talia Shire), sua filha, se casou com Carlo (Gianni Russo). " +
                        "Porém, durante a festa, Bonasera (Salvatore Corsitto) é visto no escritório de Don Corleone " +
                        "pedindo justiça, vingança na verdade contra membros de uma quadrilha, " +
                        "que espancaram barbaramente sua filha por ela ter se recusado a fazer sexo " +
                        "para preservar a honra.",
                        DataLancamento = DateTime.Parse("1972-02-24")
                    },
                    new Movie
                    {
                        Nome = "Os Bons Companheiros",
                        Descricao = "Henry Hill (Ray Liotta) conta a sua história de garoto do Brooklyn, " +
                        "Nova York, que sempre sonhou ser gângster, começando sua carreira aos 11 anos e " +
                        "se tornando protegido de James Jimmy Conway (Robert De Niro), um mafioso em ascensão.",
                        DataLancamento = DateTime.Parse("1990-06-20")
                    });
            }
            dbContext.SaveChanges();
        }
    }
}
