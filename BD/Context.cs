using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbeer.BD
{
    class Context
    {
        public static BarberbeerEntities context = new BarberbeerEntities();

        public static BarberbeerEntities GetContext()
        {
            if (context == null)
            {
                context = new BarberbeerEntities();
            }
            return context;
        }
    }
}
