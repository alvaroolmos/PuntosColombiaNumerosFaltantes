using System.Collections.Generic;
using System.Linq;

namespace PuntosColombia.Clases
{
    public class Lista
    {
        public Lista()
        {
            Valor = new List<int>();
        }

        #region Propiedades

        public List<int> Valor { get; set; }

        #endregion

        #region Metodos

        public int ObtenerValorMaximo()
        {
            int max = Valor.Max(r => r);
            return max;
        }

        public int ObtenerValorMinimo()
        {
            int min = Valor.Min(r => r);
            return min;
        }

        #endregion

    }
}
