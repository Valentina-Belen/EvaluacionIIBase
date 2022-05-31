using LibreriaEvaluacion.DTO;

namespace LibreriaEvaluacion.DAL
{
    public class PrestamoDALBase
    {

        public int BuscarPorId(int id);

        public int BuscarPorId(int id)
        {
            for (int i = 0; i < PrestamoDTO.datos.Count; i++)
            {
                if (PrestamoDTO.datos[i].Id == id)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}