using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Barbeer.BD;

namespace Barbeer.BD
{
    partial class Record
    {
        public string ServiceView
        {
            get
            {
                return ConBD.beerEN.Service.Where(ux => ux.Id == ServiceId).Select(unx => unx.ServiceName).FirstOrDefault();
            }
        }

        public string BarberView
        {
            get
            {
                return ConBD.beerEN.Barber.Where(ux => ux.Id == BarberId).Select(unx => unx.Name).FirstOrDefault();
            }
        }

        public string CLientView
        {
            get
            {
                return ConBD.beerEN.Client.Where(ux => ux.Id == ClientId).Select(unx => unx.Name).FirstOrDefault();
            }
        }


    }
}
