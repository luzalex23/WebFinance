using Domain.Interfaces.Generic;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IExpense
{
    public interface IExpense : InterfaceGeneric<Expense>
    {
        Task<IList<Expense>> ListarDespesasUsuario(string emailUsuario);

        Task<IList<Expense>> ListarDespesasUsuarioNaoPagasMesesAnterior(string emailUsuario);
    }
}
