using Domain.Interfaces.Generic;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IUserFinancialSystem
{
    public interface IUserFinancial : InterfaceGeneric<UserFinancialSystem>
    {
        Task<IList<UserFinancialSystem>> ListarUsuariosSistema(int IdSistema);

        Task RemoveUsuarios(List<UserFinancialSystem> usuarios);

        Task<UserFinancialSystem> ObterUsuarioPorEmail(string emailUsuario);
    }
}
