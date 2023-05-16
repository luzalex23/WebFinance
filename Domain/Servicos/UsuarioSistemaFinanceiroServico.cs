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
    public class UsuarioSistemaFinanceiroServico : IUserFinancial
    {
        private readonly IUserFinancial _userFinancialService;
        public UsuarioSistemaFinanceiroServico(IUserFinancial userFinancialService)
        {
            _userFinancialService = userFinancialService;
        }

        public Task Add(UserFinancialSystem Objeto)
        {
            throw new NotImplementedException();
        }

        public async Task CadastrarUsuarioNoSistema(UserFinancialSystem userFinancialSystem)
        {
            await _userFinancialService.Add(userFinancialSystem);
        }

        public Task Delete(UserFinancialSystem Objeto)
        {
            throw new NotImplementedException();
        }

        public Task<UserFinancialSystem> GetEntityById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserFinancialSystem>> List()
        {
            throw new NotImplementedException();
        }

        public Task<IList<UserFinancialSystem>> ListarUsuariosSistema(int IdSistema)
        {
            throw new NotImplementedException();
        }

        public Task<UserFinancialSystem> ObterUsuarioPorEmail(string emailUsuario)
        {
            throw new NotImplementedException();
        }

        public Task RemoveUsuarios(List<UserFinancialSystem> usuarios)
        {
            throw new NotImplementedException();
        }

        public Task Update(UserFinancialSystem Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
