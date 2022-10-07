using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbeer.BD
{
    partial class Barber
    {
        public string BarberStatus
        {
            get
            {
                return ConBD.beerEN.Status.Where(u => u.Id == Status).Select(u => u.Description).FirstOrDefault();
            }
        }

    }
}
