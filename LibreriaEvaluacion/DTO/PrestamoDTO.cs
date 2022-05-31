using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEvaluacion.DTO
{
    public class PrestamoDTO
    {
        private int Id;
        private int monto;

        public static List<PrestamoDTO> datos = new List<PrestamoDTO>()
        {
            new PrestamoDTO() { Id= 2, monto= (int)50.000}
        };
        internal int id;

        public internal static bool RemoveAt(int indiceElementoBuscado)
        {
            throw new NotImplementedException();
        }

        internal static bool Add(PrestamoDTO dato)
        {
            throw new NotImplementedException();
        }
    }
}