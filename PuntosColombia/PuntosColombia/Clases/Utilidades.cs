using System;
using System.Collections.Generic;
using System.Linq;

namespace PuntosColombia.Clases
{
    public class Utilidades
    {

        #region Metodos

        /// <summary>
        /// Convierte una lista con valores string en valores integer.
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public Respuesta ConvertirLista(List<string> lista)
        {
            Respuesta respuesta = new Respuesta();

            try
            {
                foreach (var valor in lista)
                {
                    int val;
                    bool parseado = int.TryParse(valor, out val);
                    if (parseado)
                    {
                        respuesta.Resultado.Valor.Add(val);
                    }
                }
                respuesta.Exito = true;
            }
            catch (Exception e)
            {
                respuesta.Exito = false;
                respuesta.Mensaje = e.Message;
            }

            return respuesta;
        }

        #endregion

    }
}
