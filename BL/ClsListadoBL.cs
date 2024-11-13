using DAL;
using ENT;

namespace BL
{
    public class ClsListadoBL
    {
        public static List<ClsPersona> listadoPersonasBL()
        {
            List<ClsPersona> lista = new List<ClsPersona>();

            lista= ClsListadoDAL.listadoPersonas();

            return lista;
        }
    }
}
