using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PuntosColombia.Clases;

namespace PuntosColombia
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            // Carga inicial de valores
            txtValoresListaA.Text = @"203 204 205 206 207 208 203 204 205 206";
            txtValoresListaB.Text = @"203 204 204 205 206 207 205 208 203 206 205 206 204";
        }

        private void btnEvaluarListas_Click(object sender, EventArgs e)
        {
            try
            {
                //throw new Exception("Excepción Generada");
                List<string> listaA = txtValoresListaA.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).OrderBy(i => i).ToList();
                List<string> listaB = txtValoresListaB.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).OrderBy(i => i).ToList();

                Utilidades utilidades = new Utilidades();
                Respuesta respuestaListaA = utilidades.ConvertirLista(listaA);
                Respuesta respuestaListaB = utilidades.ConvertirLista(listaB);

                Validaciones validaciones = new Validaciones();

                if (respuestaListaA.Resultado.Valor.Count == 0 || respuestaListaB.Resultado.Valor.Count == 0)
                {
                    txtMensaje.Text = Recursos.Mensajes.UnaListaEstaVacia;
                    return;
                }

                Respuesta respuestaValidacionA = validaciones.ValidarValoresListaA(respuestaListaA);
                Respuesta respuestaValidacionB = validaciones.ValidarValoresListaB(respuestaListaB);


                if (!respuestaValidacionA.Exito)
                {
                    txtMensaje.Text = Recursos.Mensajes.En_la_lista_A + Environment.NewLine + respuestaValidacionA.Mensaje;
                    return;
                }
                if (!respuestaValidacionB.Exito)
                {
                    txtMensaje.Text = Recursos.Mensajes.En_la_lista_B + Environment.NewLine + respuestaValidacionB.Mensaje;
                    return;
                }

                Respuesta respuestaCompracion = validaciones.CompararListas(respuestaListaA, respuestaListaB);

                if (respuestaCompracion.Exito && respuestaCompracion.Resultado.Valor.Count > 0)
                {
                    string val = string.Empty;
                    foreach (int valor in respuestaCompracion.Resultado.Valor)
                    {
                        val += " " + valor.ToString();
                    }
                    txtMensaje.Text = val.Trim();
                }
                else if (respuestaCompracion.Exito && respuestaCompracion.Resultado.Valor.Count == 0)
                {
                    txtMensaje.Text = Recursos.Mensajes.NoHayDiferenciasEnListas;
                }
                else if (!respuestaCompracion.Exito)
                {
                    txtMensaje.Text = respuestaCompracion.Mensaje;
                }

            }
            catch (Exception ex)
            {
                txtMensaje.Text = Recursos.Mensajes.ErrorInesperado +
                                  Environment.NewLine + Environment.NewLine + ex.Message + 
                                  Environment.NewLine + Environment.NewLine + ex;
            }
        }
    }
}
