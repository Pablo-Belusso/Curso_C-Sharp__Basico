using Microsoft.EntityFrameworkCore;

namespace WebCrudMVCSQL.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        { 

        }
    }
}
