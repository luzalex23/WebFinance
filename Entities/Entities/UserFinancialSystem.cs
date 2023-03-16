using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("UsuarioSistemaFinanceiro")]
    public class UserFinancialSystem : Base
    {
        public int Id { get; set; }
        public string EmailUser { get; set; }
        public bool Administrator { get; set; }
        public bool ActualSystem { get; set; }


        [ForeignKey("SistemaFinanceiro")]
        [Column(Order = 1)]
        public int IdSistema { get; set; }
        public virtual FinancialSystem FinancialSystem { get; set; }
    }
}
