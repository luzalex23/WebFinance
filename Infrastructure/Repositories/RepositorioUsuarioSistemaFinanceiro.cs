using Domain.Interfaces.IUserFinancialSystem;
using Domain.Interfaces.ServiceInterface;
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
    public class RepositorioUsuarioSistemaFinanceiro : RepositoryGenerics<UserFinancialSystem>, IUserFinancial
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;

        public RepositorioUsuarioSistemaFinanceiro()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }

        public async Task<IList<UserFinancialSystem>> ListarUsuariosSistema(int IdSistema)
        {
            using (var banco = new ContextBase(_OptionsBuilder))
            {
                return await
                    banco.UsuarioSistemaFinanceiro
                    .Where(s => s.IdSistema == IdSistema).AsNoTracking()
                    .ToListAsync();
            }
        }

        public async Task<UserFinancialSystem> ObterUsuarioPorEmail(string emailUsuario)
        {
            using (var banco = new ContextBase(_OptionsBuilder))
            {
#pragma warning disable CS8603 // Possible null reference return.
                return await
                    banco.UsuarioSistemaFinanceiro.AsNoTracking().FirstOrDefaultAsync(x => x.EmailUser.Equals(emailUsuario));
#pragma warning restore CS8603 // Possible null reference return.
            }
        }

        public async Task RemoveUsuarios(List<UserFinancialSystem> usuarios)
        {
            using (var banco = new ContextBase(_OptionsBuilder))
            {
                banco.UsuarioSistemaFinanceiro
               .RemoveRange(usuarios);

                await banco.SaveChangesAsync();
            }
        }
    }
}
