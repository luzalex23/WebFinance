using Domain.Interfaces.IFinancialSystem;
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
    public class RepositorioSistemaFinanceiro : RepositoryGenerics<FinancialSystem>, IFinancialSystem
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;

        public RepositorioSistemaFinanceiro()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }
        public async Task<IList<FinancialSystem>> ListaSistemasUsuario(string emailUsuario)
        {
            using (var banco = new ContextBase(_OptionsBuilder))
            {
                return await
                   (from s in banco.SistemaFinanceiro
                    join us in banco.UsuarioSistemaFinanceiro on s.Id equals us.IdSistema
                    where us.EmailUser.Equals(emailUsuario)
                    select s).AsNoTracking().ToListAsync();
            }
        }
    }
}
