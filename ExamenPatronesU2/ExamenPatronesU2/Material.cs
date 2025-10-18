using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPatronesU2
{
    public class Material
    {
        public string Nombre { get; set; }
        public bool EsReciclable { get; set; }

        public void Iniciar()
        {
            Nombre = string.Empty;
            EsReciclable = false;
        }
    }
}
