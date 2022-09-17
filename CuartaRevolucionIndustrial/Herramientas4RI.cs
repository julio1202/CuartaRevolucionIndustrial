using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuartaRevolucionIndustrial
{
    public class Herramientas4RI
    {
        string  nombreHerramienta;

        public Herramientas4RI(string nombreHerramienta)
        {
            this.NombreHerramienta = nombreHerramienta;
        }

        public string NombreHerramienta { get => nombreHerramienta; set => nombreHerramienta = value; }
    }
}
