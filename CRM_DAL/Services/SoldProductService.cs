using CRM_DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_DAL.Services
{
    public class SoldProductService
    {
        private readonly CoderContext _coderContext;

        public SoldProductService()
        {
            _coderContext = new CoderContext();
        }

        //Metodos:
        //obtenerprodvendido
        //listarprodvendido
        //crearprodvendido
        //modificarprodvendido
        //eliminarprodvendido

    }
}
