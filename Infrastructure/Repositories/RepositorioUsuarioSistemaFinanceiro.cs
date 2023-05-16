using Domain.Interfaces.Generic;
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
    public class RepositorioUsuarioSistemaFinanceiro : RepositoryGenerics<UserFinancialSystem>, IUserFinancialService
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;

        public RepositorioUsuarioSistemaFinanceiro()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }

        public Task Add(FinancialSystem Objeto)
        {
            throw new NotImplementedException();
        }

        public Task CadastrarUsuarioNoSistema(UserFinancialSystem usuarioSistemaFinanceiro)
        {
            throw new NotImplementedException();
        }

        public Task Delete(FinancialSystem Objeto)
        {
            throw new NotImplementedException();
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
                return await
                    banco.UsuarioSistemaFinanceiro.AsNoTracking().FirstOrDefaultAsync(x => x.EmailUser.Equals(emailUsuario));
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

        public Task Update(FinancialSystem Objeto)
        {
            throw new NotImplementedException();
        }

        Task<FinancialSystem> InterfaceGeneric<FinancialSystem>.GetEntityById(int Id)
        {
            throw new NotImplementedException();
        }

        Task<List<FinancialSystem>> InterfaceGeneric<FinancialSystem>.List()
        {
            throw new NotImplementedException();
        }
    }
}
