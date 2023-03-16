using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("Categoria")]
    public class Category : Base
    {
        public Category() { }
        [ForeignKey("SistemaFinanceiro")]
        [Column(Order = 1)]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual FinancialSystem FinancialSystem { get; set; }

    }
}
