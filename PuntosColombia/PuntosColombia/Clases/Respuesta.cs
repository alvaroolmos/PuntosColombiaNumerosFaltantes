namespace PuntosColombia.Clases
{
    public class Respuesta
    {
        public Respuesta()
        {
            Resultado = new Lista();
        }

        #region Propiedades

        public bool Exito { get; set; }
        public string Mensaje { get; set; }
        public Lista Resultado { get; set; }

        #endregion
    }
}
