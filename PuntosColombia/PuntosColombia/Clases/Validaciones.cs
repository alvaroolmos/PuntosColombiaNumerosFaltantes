using System;
using System.Linq;

namespace PuntosColombia.Clases
{
    public class Validaciones
    {

        #region Metodos

        /// <summary>
        /// Realiza las validaciones de la Lista A
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public Respuesta ValidarValoresListaA(Respuesta lista)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Exito = true;
            respuesta.Mensaje = string.Empty;

            int valorMinimo = lista.Resultado.ObtenerValorMinimo();
            int valorMaximo = lista.Resultado.ObtenerValorMaximo();

            // Restricción 4: Xmax - Xmin < 100
            if (valorMaximo - valorMinimo > 100)
            {
                respuesta.Exito = false;
                respuesta.Mensaje = Recursos.Mensajes.RangoValoresSuperiorA100;
            }

            if (lista.Resultado.Valor.Count < 1)
            {
                respuesta.Exito = false;
                respuesta.Mensaje = Recursos.Mensajes.NumeroItemsInferiorAlEsperado;
            }
            else if (lista.Resultado.Valor.Count > 2 * Math.Pow(10, 5)) // Restricción 1: 1 <= n,m <= 2 * 10 ^ 5
            {
                respuesta.Exito = false;

                respuesta.Mensaje = Recursos.Mensajes.NumeroMaximoSuperaEsperado;
            }

            return respuesta;
        }

        /// <summary>
        /// Validaciones especificas para la Lista B
        /// Esta lista requiere ademas de las particulares para sí, las mismas de la lista A
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public Respuesta ValidarValoresListaB(Respuesta lista)
        {
            Respuesta respuesta = ValidarValoresListaA(lista);

            if (lista.Resultado.Valor.Count > Math.Pow(10, 4)) // Restricción 3: 1 <= x <= 10 ^ 4, x pertenezca a B
            {
                respuesta.Exito = false;

                respuesta.Mensaje = Recursos.Mensajes.NumeroMaximoSuperaEsperado;
            }

            return respuesta;
        }

        /// <summary>
        /// Compara las listas para validar faltantes numéricos y devuelve el numero de valores diferenciales.
        /// </summary>
        /// <param name="listaA"></param>
        /// <param name="listaB"></param>
        /// <returns></returns>
        public Respuesta CompararListas(Respuesta listaA, Respuesta listaB)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Exito = true;
            respuesta.Mensaje = string.Empty;

            // Restricción 2: n <= m
            if (listaA.Resultado.Valor.Count > listaB.Resultado.Valor.Count)
            {
                respuesta.Exito = false;
                respuesta.Mensaje = Recursos.Mensajes.ListaB_debe_tener_mas_elementos_ListaA;
            }

            var result =
                (
                    from i1 in listaA.Resultado.Valor.Except(listaB.Resultado.Valor)
                    select i1
                ).Union(
                    from i2 in listaB.Resultado.Valor.Except(listaA.Resultado.Valor)
                    select i2
                );

            if (result.Any())
            {
                respuesta.Exito = false;
                respuesta.Mensaje = Recursos.Mensajes.NumeroXNoEstaEnY;
            }


            if (respuesta.Exito)
            {


                var agrupaListaA = from r in listaA.Resultado.Valor
                                   orderby r
                                   group r by r
                    into grp
                                   select new { valor = grp.Key, cantidad = grp.Count() };

                var agrupaListaB = from r in listaB.Resultado.Valor
                                   orderby r
                                   group r by r
                    into grp
                                   select new { valor = grp.Key, cantidad = grp.Count() };

                foreach (var itemA in agrupaListaA)
                {
                    foreach (var itemB in agrupaListaB)
                    {
                        if (itemA.valor == itemB.valor)
                        {
                            if (itemA.cantidad != itemB.cantidad)
                            {
                                respuesta.Resultado.Valor.Add(itemA.valor);
                            }
                        }
                    }
                }
            }
            return respuesta;
        }

        #endregion

    }
}
