using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuartaRevolucionIndustrial
{
    public class IntegrantesEquipo
    {
        string identificacion, nombre, apellido, rolEmprendimiento, email;

        public IntegrantesEquipo(string identificacion, string nombre, string apellido, string rolEmprendimiento, string email)
        {
            this.Identificacion = identificacion;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.RolEmprendimiento = rolEmprendimiento;
            this.Email = email;
        }

       
      

        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string RolEmprendimiento { get => rolEmprendimiento; set => rolEmprendimiento = value; }
        public string Email { get => email; set => email = value; }
    }
}
