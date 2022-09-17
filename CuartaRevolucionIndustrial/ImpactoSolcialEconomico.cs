using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuartaRevolucionIndustrial
{
    public class ImpactoSolcialEconomico
    {
        string impactoSocialEcomico;

        public ImpactoSolcialEconomico(string impactoSocialEcomico)
        {
            this.ImpactoSocialEcomico = impactoSocialEcomico;
        }

        public string ImpactoSocialEcomico { get => impactoSocialEcomico; set => impactoSocialEcomico = value; }
    }
}
