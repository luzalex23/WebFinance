using Domain.Interfaces.ServiceInterface;
using Entities.Entities;
using Domain.Interfaces.IUserFinancialSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Servicos
{
    public class UsuarioSistemaFinanceiroServico
    {
        private readonly IUserFinancial _userFinancialService;
        public UsuarioSistemaFinanceiroServico(IUserFinancial userFinancialService)
        {
            _userFinancialService = userFinancialService;
        }
        public async Task CadastrarUsuarioNoSistema(UserFinancialSystem userFinancialSystem)
        {
            await _userFinancialService.Add(userFinancialSystem);
        }
    }
}
