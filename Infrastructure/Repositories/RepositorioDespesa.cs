using Domain.Interfaces.IExpense;
using Entities.Entities;
using Infrastructure.Configuration;
using Infrastructure.Repositories.Generics;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class RepositorioDespesa : RepositoryGenerics<Expense>, IExpense
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;

        public RepositorioDespesa()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }

        public async Task<IList<Expense>> ListarDespesasUsuario(string emailUsuario)
        {
            using (var banco = new ContextBase(_OptionsBuilder))
            {
                return await
                   (from s in banco.SistemaFinanceiro
                    join c in banco.Categoria on s.Id equals c.SytemId
                    join us in banco.UsuarioSistemaFinanceiro on s.Id equals us.IdSistema
                    join d in banco.Despesa on c.Id equals d.IdCategoria
                    where us.EmailUser.Equals(emailUsuario) && s.Year == d.Moth && s.Year == d.Year
                    select d).AsNoTracking().ToListAsync();
            }
        }

        public async Task<IList<Expense>> ListarDespesasUsuarioNaoPagasMesesAnterior(string emailUsuario)
        {
            using (var banco = new ContextBase(_OptionsBuilder))
            {
                return await
                   (from s in banco.SistemaFinanceiro
                    join c in banco.Categoria on s.Id equals c.SytemId
                    join us in banco.UsuarioSistemaFinanceiro on s.Id equals us.IdSistema
                    join d in banco.Despesa on c.Id equals d.IdCategoria
                    where us.EmailUser.Equals(emailUsuario) && d.Moth < DateTime.Now.Month && !d.PaidOut
                    select d).AsNoTracking().ToListAsync();
            }
        }
    }
}
