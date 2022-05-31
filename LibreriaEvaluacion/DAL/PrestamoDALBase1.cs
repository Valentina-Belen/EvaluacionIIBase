using LibreriaEvaluacion.DTO;

namespace LibreriaEvaluacion.DAL
{
    public class PrestamoDALBase1
    {
        public bool Insertar(PrestamoDTO dato)
        {
            return PrestamoDTO.Add(dato);
        }
    }
}