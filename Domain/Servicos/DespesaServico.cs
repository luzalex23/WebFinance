using Domain.Interfaces.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;
using Domain.Interfaces.IExpense;

namespace Domain.Servicos
{
    public class DespesaServico
    {
        private readonly IExpense _InterfaceDespesa;
        public DespesaServico(IExpense InterfaceServico)
        {
            _InterfaceDespesa = InterfaceServico;
        }
        public async Task AdicionarDespesa(Expense despesa)
        {
            var data = DateTime.UtcNow;
            despesa.Register = data;
            despesa.Year = data.Year;
            despesa.Moth = data.Month;

            var valido = despesa.PropertyValidationString(despesa.Nome, "Nome");
            if (valido)
                await _InterfaceDespesa.Add(despesa);

        }

        public async Task AtualizarDespesa(Expense despesa)
        {
            var data = DateTime.UtcNow;
            despesa.Update = data;

            if (despesa.PaidOut)
            {
                despesa.PaidDate = data;
            }

            var valido = despesa.PropertyValidationString(despesa.Nome, "Nome");
            if (valido)
                await _InterfaceDespesa.Update(despesa);
        }
    }
}
