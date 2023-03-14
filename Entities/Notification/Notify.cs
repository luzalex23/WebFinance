using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Notification
{
    public class Notify
    {
        public Notify() 
        {
            notify = new List<Notify>();
        }

        [NotMapped]
        public string propertyName { get; set; }

        [NotMapped]
        public string message { get; set; }

        [NotMapped]
        public List<Notify> notify { get; set; }



        /*Validations*/

        public bool PropertyValidationStrin(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(propertyName))
            {
                notify.Add(new Notify
                {
                    message = "Campo Obrigatório",
                    NomePropriedade = propertyName
                });

                return false;
            }

            return true;
        }


        public bool PropertyValidationStrin(int value, string propertyName)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                notify.Add(new Notify
                {
                    message = "Campo Obrigatório",
                    NomePropriedade = propertyName
                });

                return false;
            }

            return true;
        }

    }
}
