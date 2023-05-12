using Domain.Interfaces.Generic;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.ICategory
{
    public interface ICategory : InterfaceGeneric<Category>
    {
        Task<IList<Category>> GetAll();
        Task<IList<Category>> ListarCategoriasUsuario(string emailUsuario);

    }
}
