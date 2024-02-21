using Microsoft.EntityFrameworkCore;
using Parcial1_Ap1_VladimirGuzman.DAL;
using Parcial1_Ap1_VladimirGuzman.Models;
using System.Linq.Expressions;

namespace Parcial1_Ap1_VladimirGuzman.Services
{
    public class MetasService

    {
        protected readonly Contexto _contexto;

        public MetasService(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> Guardar(Metas metas)
        {
            if (!await Existe(metas.MetaId))
                return await Insertar(metas);
            else
                return await Modificar(metas);
        }

        public async Task<bool> Modificar(Metas metas)
        {
            _contexto.Update(metas);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> Insertar(Metas metas)
        {
            await _contexto.AddAsync(metas);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> Existe(int metaId)
        {
            return await _contexto.Metas!
                .AnyAsync(a => a.MetaId == metaId);
        }

        public async Task<Metas?> Buscar(int metaId)
        {
            return await _contexto.Metas!
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.MetaId == metaId);
        }

        public async Task<bool> Eliminat(Metas aporte)
        {
            return await _contexto.Metas!
                .Where(a => a.MetaId == aporte.MetaId)
                .ExecuteDeleteAsync() > 0;
        }

        public async Task<List<Metas>> Listar(Expression<Func<Metas, bool>> criterio)
        {
            return await _contexto.Metas!
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }
    }
}
