using DataAccess;
using Entity;
using Entity.dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IEmpresaService : IDisposable
    {
        List<EmpresaEntity> ObtenerLista();
        DBEntity Insertar(EmpresaEntity entity);
    }
    public class EmpresaService : IEmpresaService
    {
        public IBD sql = new BD("Conn");

        public void Dispose()
        {
            sql = null;
        }

        public List<EmpresaEntity> ObtenerLista()
        {
            try
            {
                var result = sql.Query<EmpresaEntity>("EmpresasObtener");
                return result;
            }
            catch (Exception ex)
            {

                throw (ex);
            }
        }

        public DBEntity Insertar(EmpresaEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("EmpresaInsertar", new
                {
                    NombreEmpresa = entity.NombreEmpresa,
                    entity.Estado,

                });
                return result;
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }
    }
}
