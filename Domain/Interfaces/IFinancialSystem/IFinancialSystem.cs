using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Interfaces.Generic;
using Entities.Entities;
using System.Threading.Tasks;

namespace Domain.Interfaces.IFinancialSystem
{
    public interface IFinancialSystem
    {
        Task AdicionarSistemaFinanceiro(FinancialSystem sistemaFinanceiro);
        Task AtualizarSistemaFinanceiro(FinancialSystem sistemaFinanceiro);
    }
}
