using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.ServiceInterface
{
    internal interface IServiceCategory
    {
        Task AdicionarCategoria(Category catagoria);
        Task AtualizarCategoria(Category catagoria);
    }
}
