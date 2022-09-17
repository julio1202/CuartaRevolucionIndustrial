using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuartaRevolucionIndustrial
{
    public class Departamentos
    {
        string nombreDepartamento, codigoDepartamento;

        public Departamentos(string nombreDepartamento, string codigoDepartamento)
        {
            this.NombreDepartamento = nombreDepartamento;
            this.CodigoDepartamento = codigoDepartamento;
        }

        public string NombreDepartamento { get => nombreDepartamento; set => nombreDepartamento = value; }
        public string CodigoDepartamento { get => codigoDepartamento; set => codigoDepartamento = value; }
    }
}
