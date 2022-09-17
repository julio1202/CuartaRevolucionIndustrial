using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuartaRevolucionIndustrial
{
    class Program
    {
        static void Main()
        {
            int secuencia = 0;

            List<IdeasNegocio> ideasGuardadas = new List<IdeasNegocio>();
            IdeasNegocio consultarIdeas = new IdeasNegocio();

            Boolean menu = true;
            while (menu)
            {
                Console.WriteLine("Seleccione la opción que desea: ");
                Console.WriteLine(" 1. Ingresar Idea de negocio \n 2. Buscar idea de negocio \n 3. Agregar integrantes de equipo " +
                    "\n 4. Eliminar integrantes de equipo \n 5. Modificar valor inversion y el total de ingresos \n 6. ksdhhkjllk \n 7. Salir");
                int opcion = Convert.ToInt16(Console.ReadLine());
                do
                {
                    switch (opcion)
                    {
                        case 1:
                            secuencia++;
                            ingresarIdeaNegocio(ideasGuardadas, secuencia);
                            opcion = 7;
                            break;
                        case 2:
                            consultarIdeas = consultarIdeasNegocio(ideasGuardadas);
                            if (consultarIdeas.Codigo != "")
                            {
                                Console.WriteLine("El codigo de la idea de negocio es: " + consultarIdeas.Codigo);
                                Console.WriteLine("El nombre de la idea de negocio es: " + consultarIdeas.NombreIdeaNegocio);

                                foreach (Departamentos departamentos in consultarIdeas.Departamentos)
                                {
                                    Console.WriteLine("Los departamentos beneficiados son: " + departamentos.CodigoDepartamento
                                        + " " + departamentos.NombreDepartamento);
                                }

                                foreach (Herramientas4RI herramientas4RI in consultarIdeas.Herramientas4RIs)
                                {
                                    Console.WriteLine("Las herramientas de la cuarta revolucion industrial son: " + herramientas4RI.NombreHerramienta);
                                }

                                Console.WriteLine("El total inversion es : " + consultarIdeas.ValInversion);
                                Console.WriteLine("Ingresos despues de tres años es : " + consultarIdeas.TotalIngresos);

                                foreach (ImpactoSolcialEconomico impactoSolcial in consultarIdeas.ImpactoSolcials)
                                {
                                    Console.WriteLine("El impacto social y economico es: " + impactoSolcial.ImpactoSocialEcomico);
                                }

                                foreach (IntegrantesEquipo integrantesEquipo in consultarIdeas.EquipoList)
                                {
                                    Console.WriteLine("Los participantes del equipo son: " + integrantesEquipo.Identificacion + " " +
                                        integrantesEquipo.Nombre + " " + integrantesEquipo.Apellido + " " +
                                        integrantesEquipo.RolEmprendimiento + " " + integrantesEquipo.Email);
                                }
                            }
                            opcion = 7;
                            break;
                        case 3:
                            IdeasNegocio ideasNegocio = consultarIdeasNegocio(ideasGuardadas);
                            Console.WriteLine("Ingrese el numero de integrantes que desea agregar: ");
                            int numIntegrantesEquipo = Convert.ToInt16(Console.ReadLine());
                            for (int i = 0; i < numIntegrantesEquipo; i++)
                            {
                                agregarIntegrantesEquipo(ideasNegocio);
                            }
                            opcion = 7;
                            break;
                        case 4:
                            ideasNegocio = consultarIdeasNegocio(ideasGuardadas);
                            Console.WriteLine("Ingrese el numero de integrantes que desea eliminar: ");
                            numIntegrantesEquipo = Convert.ToInt16(Console.ReadLine());
                            for (int i = 0; i < numIntegrantesEquipo; i++)
                            {
                                eliminarIntegranteEquipo(ideasNegocio);
                            }

                            opcion = 7;
                            break;
                        case 5:
                            modificarInversionIngresos(ideasGuardadas);
                            opcion = 7;
                            break;
                        case 6:
                            /*impactanMasDe3Departamentos(ideasGuardadas);
                            ideaMasDepartamentosTotalInversion(ideasGuardadas);
                            sumaTotalIngresos(ideasGuardadas);
                            sumaTotalInversion(ideasGuardadas);*/
                            opcion = 7;
                            break;
                        case 7:
                            menu = false;
                            Console.WriteLine("Usted va a salir del programa ");
                            break;


                        default:
                            Console.WriteLine("Seleccione una opción correcta ");
                            Console.WriteLine("1. Ingresar Idea de negocio \n 2. Buscar idea de negocio \n 3. Agregar integrantes de equipo " +
                                "\n 4. Eliminar integrantes de equipo \n 5. Modificar valor inversion y el total de ingresos \n 6. \n 7. Salir");
                            break;
                    }
                } while (opcion != 7);
            }
            Console.ReadKey();
        }

        public static void ingresarIdeaNegocio(List<IdeasNegocio> ideasNegocios, int secuencia)
        {
            string codigo, nombreIdea, impactoSocial;
            int valInvercion, totalIngresos;

            List<Departamentos> departamentos = new List<Departamentos>();
            List<ImpactoSolcialEconomico> impactoSolcials = new List<ImpactoSolcialEconomico>();
            List<IntegrantesEquipo> integrantesEquipos = new List<IntegrantesEquipo>();
            List<Herramientas4RI> herramientas4RI = new List<Herramientas4RI>();


            codigo = "" + secuencia;
            Console.WriteLine("Su codigo es: " + codigo);
            Console.WriteLine("Ingrese el nombre de la idea de negocio: ");
            nombreIdea = Console.ReadLine();
            Console.WriteLine("Ingrese el valor inversion: ");
            valInvercion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el total de ingresos despues de tres años: ");
            totalIngresos = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ingrese el numero de departamentos que impacta su idea: ");
            int numDepartamentos = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < numDepartamentos; i++)
            {
                string departamento, codigoDepartamento;
                Console.WriteLine("Ingrese el codigo del departamento: ");
                codigoDepartamento = Console.ReadLine();
                Console.WriteLine("Ingrese los departamentos beneficiados con la idea de negocio: ");
                departamento = Console.ReadLine();
                Departamentos departamento1 = new Departamentos(departamento, codigoDepartamento);
                departamentos.Add(departamento1);
            }


            Console.WriteLine("Ingrese el numero de integrantes del equipo: ");
            int numIntegrantesEquipo = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < numIntegrantesEquipo; i++)
            {
                string identificacion, nombre, apellidos, rolEmprendimiento, email;
                Console.WriteLine("Ingrese la identificacion del integrante: ");
                identificacion = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre del integrante: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese los apellidos del integrante ");
                apellidos = Console.ReadLine();
                Console.WriteLine("Ingrese el rol en el emprendimeinto: ");
                rolEmprendimiento = Console.ReadLine();
                Console.WriteLine("Ingrese el email del integrante ");
                email = Console.ReadLine();
                IntegrantesEquipo integrante1 = new IntegrantesEquipo(identificacion, nombre, apellidos, rolEmprendimiento, email);
                integrantesEquipos.Add(integrante1);
            }

            Console.WriteLine("Ingrese el impacto social o economico que genere su idea: ");
            impactoSocial = Console.ReadLine();
            ImpactoSolcialEconomico impacto = new ImpactoSolcialEconomico(impactoSocial);
            impactoSolcials.Add(impacto);

            Console.WriteLine("Ingrese el numero de Herramientas de la cuarta revolucion industrial: ");
            int numHerramientas = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < numHerramientas; i++)
            {
                string nombreHerramienta;


                Console.WriteLine("Ingrese el nombre de la herramienta: ");
                nombreHerramienta = Console.ReadLine();

                Herramientas4RI herramientas = new Herramientas4RI(nombreHerramienta);
                herramientas4RI.Add(herramientas);


            }

            IdeasNegocio ideas = new IdeasNegocio(codigo, nombreIdea, valInvercion, totalIngresos, integrantesEquipos,
                departamentos, impactoSolcials, herramientas4RI);
            ideasNegocios.Add(ideas);
        }

        public static IdeasNegocio consultarIdeasNegocio(List<IdeasNegocio> consultarIdeas)
        {
            string codigoConsultado;
            IdeasNegocio ideaConsultada = new IdeasNegocio();
            Console.WriteLine("Ingrese el código de la idea que desea consultar: ");
            codigoConsultado = Console.ReadLine();
            foreach (IdeasNegocio idea in consultarIdeas)
            {
                if (idea.Codigo == codigoConsultado)
                {
                    ideaConsultada = idea;
                    return ideaConsultada;
                }
            }
            return ideaConsultada;
        }

        public static IntegrantesEquipo agregarIntegrantesEquipo(IdeasNegocio ideaConsultada)
        {

            List<IntegrantesEquipo> agregarIntegrante = ideaConsultada.EquipoList;


            string identificacion, nombre, apellidos, rolEmprendimiento, email;
            Console.WriteLine("Ingrese la identificacion del integrante: ");
            identificacion = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del integrante: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese los apellidos del integrante ");
            apellidos = Console.ReadLine();
            Console.WriteLine("Ingrese el rol en el emprendimeinto: ");
            rolEmprendimiento = Console.ReadLine();
            Console.WriteLine("Ingrese el email del integrante ");
            email = Console.ReadLine();
            IntegrantesEquipo nuevoIntegranteEquipo = new IntegrantesEquipo(identificacion, nombre, apellidos, rolEmprendimiento, email);

            agregarIntegrante.Add(nuevoIntegranteEquipo);
            return nuevoIntegranteEquipo;


        }

        public static IntegrantesEquipo eliminarIntegranteEquipo(IdeasNegocio ideaConsultada)
        {
            List<IntegrantesEquipo> eliminarIntegrante = ideaConsultada.EquipoList;

            string identificacion;
            Console.WriteLine("Ingrese la identificacion del participante que desea eliminar: ");
            identificacion = Console.ReadLine();

            IntegrantesEquipo consultaIntegrante = consultarIntegrante(eliminarIntegrante, identificacion);
            if (consultarIntegrante != null)
            {
                eliminarIntegrante.Remove(consultaIntegrante);
            }
            else
                Console.WriteLine("No existe el participante");
            return consultaIntegrante;

        }

        public static IntegrantesEquipo consultarIntegrante(List<IntegrantesEquipo> consultaIntegrante, string identificacion)
        {
            IntegrantesEquipo auxIntegranteConsultado = null;
            foreach (IntegrantesEquipo integrantesEquipo in consultaIntegrante)
            {
                if (integrantesEquipo.Identificacion.Equals(identificacion))
                {
                    auxIntegranteConsultado = integrantesEquipo;
                }
            }
            return auxIntegranteConsultado;

        }

        public static IdeasNegocio modificarInversionIngresos(List<IdeasNegocio> ideasGuardadas)
        {

            IdeasNegocio modificarIdea = new IdeasNegocio();
            
            Console.WriteLine("Ingrese el código de la idea que desea consultar: ");
            string codigoConsultado = Console.ReadLine();
            foreach (IdeasNegocio idea in ideasGuardadas)
            {
                if (idea.Codigo == codigoConsultado)
                {
                    modificarIdea = idea;
                    Console.WriteLine("Ingreso el nuevo valor de inversión");
                    int valorInversion = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingreso el nuevo total de ingresos");
                    int totalIngresos = Convert.ToInt32(Console.ReadLine());
                    idea.ValInversion = valorInversion;
                    idea.TotalIngresos = totalIngresos;
                }
            }
            return modificarIdea;
        }

        /*NOTA: Se intento cumplir con las estadisticas que se desean conocer pero no pudimos resolver unos ciertos errores
        si que no funcionan pero asi serian sus sintaxis*/

        /*public static IdeasNegocio ideaMasDepartamentosTotalInversion(IdeasNegocio ideasGuardadas)
        {
            int maxDepartamentos = 0;
            int totalMaximo = 0;
            string nombreIdeaNegocio;
            foreach (array ideasNegocio in ideasGuardadas)
            {

                if (ideasNegocio.departamentos.Count() > maxDepartamentos && ideasNegocio.totalIngresos > totalMaximo)
                {

                    maxDepartamentos = ideasNegocio.departamentos.Count();
                    totalMaximo = ideasNegocio.totalIngresos;
                    nombreIdeaNegocio = ideasNegocio.nombre;


                }
                console.writeline("la idea de negocio con mayor numero de departamentos impactados y" +
                    " mayor valor de ingreso es", nombreIdeaNegocio);



            }

        }

        public static IdeasNegocio impactanMasDe3Departamentos(IdeasNegocio ideasGuardadas)
        {
            string nombreIdeaNegocio;
            foreach (array ideasNegocio in ideasGuardadas)
            {
                if (ideasNegocio.departamentos.Count () => 3)
                {
                    nombreIdeaNegocio = IdeasNegocio.nombreIdeasNegocio;

                }

            }
            console.writeline("las ideas de negocio con mas de 3 departamentos impctados son", nombreIdeaNegocio);
        }

        public static IdeasNegocio sumaTotalIngresos(IdeasNegocio ideasGuardadas)
        {
            float suma;
            IdeasNegocio sumaIngresos = new IdeasNegocio();
            foreach (array sumaIngresos in ideasGuardadas)
            {
                suma += ideasGuardadas.TotalIngresos;
            }
            console.writeline("el total de la suma de los ingresos es", suma);

        }
        public static IdeasNegocio sumaTotalInversion(IdeasNegocio ideasGuardadas)
        {
            float suma;
            IdeasNegocio sumaIngresos = new IdeasNegocio();
            foreach (array sumaIngresos in ideasGuardadas)
            {
                suma += ideasGuardadas.ValInvercion;
            }
            console.writeline("el total de la suma de la inversion es de", suma);

        }*/

    

    }  

    
}
