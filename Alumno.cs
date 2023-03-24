using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOC_Ejemplo1
{
    class Alumno
    {
        //Crear campos (variebles globales)
        //nombre, semstre, carreera, matricula, curp
        string matricula, nombreAlumno, primerApellidoAlumno, segundoApellidoAlumno;
        private string nombreCarreraAlumno, curpAlumno, semestreAlumno;
        private string calleAlumno, coloniaAlumno, noCasaAlumno, ciudadAlumno, cpAlumno, estadoAlumno, paisAlumno;
        private char grupoSanguineoAlumno, rhAlumno; 
        private DateTime fechaIngresoAlumno;
     
        //Constructores
        public Alumno() {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Registro de alumnos de nuevo ingreso");
            //Pedoir los valores de inicio
            Console.WriteLine("Ingresa la matricula del alumno:");
            this.matricula = Console.ReadLine();
            Console.WriteLine("Ingresa el nombre del alumno:");
            this.nombreAlumno = Console.ReadLine();
            Console.WriteLine("Ingresa el primer apellido del alumno:");
            this.primerApellidoAlumno = Console.ReadLine();
            Console.WriteLine("Ingresa el segundo apellido del alumno:");
            this.segundoApellidoAlumno = Console.ReadLine();
            Console.WriteLine("Ingresa la carrera del alumno (ISIC | IGEM | ILOG  | IIND):");
            this.nombreCarreraAlumno = Console.ReadLine();
            //INICIALIZAR VARIABLE SEMESTRE
            this.semestreAlumno = "1";
        }

        public Alumno(string matricula,string nombreAlumno,
           string primerApellidoAlumno,string segundoApellidoAlumno,
           string nombreCarreraAlumno) {
            //Adignar valores de parametros a campos
            this.matricula = matricula;
            this.nombreAlumno = nombreAlumno;
            this.primerApellidoAlumno = primerApellidoAlumno;
            this.segundoApellidoAlumno = segundoApellidoAlumno;
            this.nombreCarreraAlumno = nombreCarreraAlumno;
            this.semestreAlumno = "1";
        }

        //Propiedades
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        //propiedad para nombreAlumno
        public string NombreAlumno
        {
            get { return nombreAlumno; }
          
        }
        //propiedad para primerApellidoAlumno
        public string PrimerApellidoAlumno
        {
            get { return primerApellidoAlumno; }
            set { primerApellidoAlumno = value; }
        }

        //Metodos
        public void MostrarDetalles() {            
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;

            //Imprimir letreros
            Console.WriteLine("\t \t SistemaTec");
            Console.WriteLine("\t \t Bienvenidos a la impresión de detalles de un alumno.");
            Console.WriteLine("\n");
            Console.WriteLine("Matricula del alumno: {0}", matricula);
            Console.WriteLine("Nombre completo del alumno: {0} {1} {2}", nombreAlumno,primerApellidoAlumno,segundoApellidoAlumno);
            Console.WriteLine("Bienvenido al semestre {0}, de la carrera de {1}.", semestreAlumno, nombreCarreraAlumno);
            Console.WriteLine("\n");
            Console.WriteLine("\t \t SistemaTec ");
            Console.WriteLine("\n");
        }
    }
}
