using Domain.Interfaces.ServiceInterface;
using Domain.Interfaces.IFinancialSystem;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace Domain.Servicos
{
    public class SistemaFinanceiroServico : IFinancialSystemService
    {
        private readonly IFinancialSystemService _interfaceSistemaFinanceiro;
        public SistemaFinanceiroServico(IFinancialSystemService interfaceSistemaFinanceiro)
        {
            _interfaceSistemaFinanceiro = interfaceSistemaFinanceiro;
        }

        public async Task AdicionarSistemaFinanceiro(FinancialSystem sistemaFinanceiro)
        {
            var valido = sistemaFinanceiro.PropertyValidationString(sistemaFinanceiro.Nome, "Nome");
            if (valido)
            {
                var data = DateTime.Now;

                sistemaFinanceiro.ClosureDay = 1;
                sistemaFinanceiro.Year = data.Year;
                sistemaFinanceiro.Month = data.Month;
                sistemaFinanceiro.YearCopy = data.Year;
                sistemaFinanceiro.MonthCopy = data.Month;
                sistemaFinanceiro.GenerateExpenseCopy = true;

                await _interfaceSistemaFinanceiro.Add(sistemaFinanceiro);
            }
        }

        public async Task AtualizarSistemaFinanceiro(FinancialSystem sistemaFinanceiro)
        {
            var valido = sistemaFinanceiro.PropertyValidationString(sistemaFinanceiro.Nome, "Nome");
            if (valido)
            {
                sistemaFinanceiro.ClosureDay = 1;
                await _interfaceSistemaFinanceiro.Update(sistemaFinanceiro);
            }

        }
    }
}
