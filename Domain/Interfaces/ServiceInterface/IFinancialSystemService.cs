using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.ServiceInterface
{
    public interface IFinancialSystemService
    {
        Task AdicionarSistemaFinanceiro(FinancialSystem sistemaFinanceiro);
        Task AtualizarSistemaFinanceiro(FinancialSystem sistemaFinanceiro);
    }
}
