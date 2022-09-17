using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuartaRevolucionIndustrial
{
    public class IdeasNegocio
    {
        
        string codigo, nombreIdeaNegocio;
        int valInversion, totalIngresos;
        public List<IntegrantesEquipo> equipoList;
        public List<Departamentos> departamentos;
        public List<ImpactoSolcialEconomico> impactoSolcials;
        public List<Herramientas4RI> herramientas4RIs;

        public IdeasNegocio(string codigo, string nombreIdeaNegocio, int valInversion, int totalIngresos, List<IntegrantesEquipo> equipoList,
            List<Departamentos> departamentos, List<ImpactoSolcialEconomico> impactoSolcials, List<Herramientas4RI> herramientas4RIs)
        {
            this.Codigo = codigo;
            this.NombreIdeaNegocio = nombreIdeaNegocio;
            this.ValInversion = valInversion;
            this.TotalIngresos = totalIngresos;
            this.EquipoList = equipoList;
            this.Departamentos = departamentos;
            this.ImpactoSolcials = impactoSolcials;
            this.Herramientas4RIs = herramientas4RIs;
        }


        public IdeasNegocio()
        {

        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string NombreIdeaNegocio { get => nombreIdeaNegocio; set => nombreIdeaNegocio = value; }
        public int ValInversion { get => valInversion; set => valInversion = value; }
        public int TotalIngresos { get => totalIngresos; set => totalIngresos = value; }
        public List<IntegrantesEquipo> EquipoList { get => equipoList; set => equipoList = value; }
        public List<Departamentos> Departamentos { get => departamentos; set => departamentos = value; }
        public List<ImpactoSolcialEconomico> ImpactoSolcials { get => impactoSolcials; set => impactoSolcials = value; }
        public List<Herramientas4RI> Herramientas4RIs { get => herramientas4RIs; set => herramientas4RIs = value; }
    }
    
}
