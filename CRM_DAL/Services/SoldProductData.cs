using CRM_DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_DAL.Services
{
    public class SoldProductData
    {
        private readonly CoderContext _coderContext;

        public SoldProductData()
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
