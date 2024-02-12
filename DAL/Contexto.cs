using Microsoft.EntityFrameworkCore;
using Parcial1_Ap1_VladimirGuzman.Models;

namespace Parcial1_Ap1_VladimirGuzman.DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Metas> Metas { get; set; }

        public Contexto(DbContextOptions<Contexto> options): base(options) { }
    }
}
