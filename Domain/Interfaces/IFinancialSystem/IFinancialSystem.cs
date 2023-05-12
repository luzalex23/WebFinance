using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Interfaces.Generic;
using Entities.Entities;
using System.Threading.Tasks;

namespace Domain.Interfaces.IFinancialSystem
{
    public interface IFinancialSystem : InterfaceGeneric<FinancialSystem>
    {
        Task<IList<FinancialSystem>> ListaSistemasUsuario(string emailUsuario);

    }
}
