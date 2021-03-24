using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WBL;

namespace MVCLaboratorio1.App
{
    public struct IApp
    {
        public static IEmpresaService empresaService => new EmpresaService();

    }
}