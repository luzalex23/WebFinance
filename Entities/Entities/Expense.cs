using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("Despesas")]
    public class Expense : Base
    {
        public decimal Value { get; set; }
        public int Moth { get; set; }
        public int Year { get; set; }

       // public EnumTipoDespesa TipoDespesa { get; set; }

        public DateTime Register { get; set; }

        public DateTime Update { get; set; }

        public DateTime PaidDate { get; set; }

        public DateTime DueData { get; set; }

        public bool PaidOut { get; set; }

        public bool LateExpense { get; set; }

        [ForeignKey("Categoria")]
        [Column(Order = 1)]
        public int IdCategoria { get; set; }
        public virtual Category Category { get; set; }
    }
}
