using System;
using System.Windows.Forms;

namespace PuntosColombia
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null) throw new ArgumentNullException(nameof(args));
            Application.EnableVisualStyles();
            Application.Run(new Principal());
        }
    }
}
