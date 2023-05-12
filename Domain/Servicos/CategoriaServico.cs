using Domain.Interfaces.ServiceInterface;
using Domain.Interfaces.ICategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace Domain.Servicos
{
    public class CategoriaServico : IServiceCategory
    {
        private readonly ICategory _interfaceCategoria;

        public CategoriaServico(ICategory interfaceCategoria)
        {
            _interfaceCategoria = interfaceCategoria;
        }
        public async Task AdicionarCategoria(Category catagoria)
        {
            var valido = catagoria.PropertyValidationString(catagoria.Nome, "Nome");
            if (valido)
                await _interfaceCategoria.Add(catagoria);
        }

        public async Task AtualizarCategoria(Category catagoria)
        {
            var valido = catagoria.PropertyValidationString(catagoria.Nome, "Nome");
            if (valido)
                await _interfaceCategoria.Update(catagoria);
        }
    }
}
