using CRM_DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_DAL.Services
{
    public class SalesService
    {
        private readonly CoderContext _coderContext;

        public SalesService()
        {
            _coderContext = new CoderContext();
        }

        //Metodos:
        //obtenervetna
        //listarventa
        //crearventa
        //modificarventa
        //eliminar venta

    }
}
