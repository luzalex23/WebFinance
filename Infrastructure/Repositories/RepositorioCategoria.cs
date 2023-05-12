using Domain.Interfaces.ICategory;
using Entities.Entities;
using Infrastructure.Configuration;
using Infrastructure.Repositories.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class RepositorioCategoria : RepositoryGenerics<Category>, ICategory
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;
        public RepositorioCategoria()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }
        public Task<IList<Category>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Category>> ListarCategoriasUsuario(string emailUsuario)
        {
            using (var banco = new ContextBase(_OptionsBuilder))
            {
                return await
                    (from s in banco.SistemaFinanceiro
                     join c in banco.Categoria on s.Id equals c.SytemId
                     join us in banco.UsuarioSistemaFinanceiro on s.Id equals us.IdSistema
                     where us.EmailUser.Equals(emailUsuario) && us.ActualSystem
                     select c).AsNoTracking().ToListAsync();
            }
        }
    }
}
