using LibreriaEvaluacion.DTO; 

namespace LibreriaEvaluacion.DAL
{
    public class PrestamoDAL
    {
        public bool Insertar(PrestamoDTO dato)
        {
            return PrestamoDTO.Add(dato);
        }

        public List<PrestamoDTO> Listar()
        {
            return PrestamoDTO.datos;
        }

        public bool Eliminar(int id)
        {
            int indiceElementoBuscado = BuscarPorId(id);
            if (indiceElementoBuscado >= 0) 
            {
                return PrestamoDTO.RemoveAt(indiceElementoBuscado);
            }

            return false; 
        }

        public int BuscarPorId(int id)
        {
            for (int i = 0; i < PrestamoDTO.datos.Count; i++)
            {
                if (PrestamoDTO.datos[i].id != id)
                {
                    continue;
                }
                return i;
            }
            return -1;
        }

    }
}